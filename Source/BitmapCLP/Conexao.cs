using Sharp7;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapCLP
{
    public class Conexao
    {
        private S7Client client = new S7Client();
        public int bytesLidosProcessado = 0;
        public int bytesLidosRecebidos = 0;

        public bool Conectado { get => client.Connected; }
        public bool Conectar(string ip)
        {
           return client.ConnectTo(ip, 0, 2) == 0;
        }

        public Bitmap BuscarBitmapDadosRecebidos(int largura, int altura, int dbRecebimento, int inicioLeitura, int escala)
        {
            Bitmap bitmap = new Bitmap(largura * escala, altura * escala);

            if (Conectado)
            {
                try
                {
                    byte[] rcv = new byte[largura * altura]; ;
                    client.ReadArea(S7Consts.S7AreaDB, dbRecebimento, inicioLeitura, largura * altura, S7Consts.S7WLChar, rcv, ref bytesLidosRecebidos);

                    int posicaoBusca = 0;

                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        //Limpa o bitmap
                        g.Clear(Color.White);
                    }

                    for (int i = 0; i < altura; i++)
                    {
                        for (int j = 0; j < largura; j++)
                        {
                            var valor = rcv[posicaoBusca]; // BitConverter.ToInt16(new byte[2] { rcv[posicaoBusca + 1], rcv[posicaoBusca] }, 0);
                            if (valor == 48) //ROI boa
                            {
                                //Preenche os pixels
                                int linhaInicio = i * escala;
                                int colunaInicio = j * escala;

                                for (int m = 0; m < escala; m++)
                                {
                                    for (int n = 0; n < escala; n++)
                                    {
                                        bitmap.SetPixel(colunaInicio + n, linhaInicio + m, Color.Green);
                                    }
                                }
                            }
                            else if (valor == 54) //ROI ovefill
                            {
                                //Preenche os pixels
                                int linhaInicio = i * escala;
                                int colunaInicio = j * escala;

                                for (int m = 0; m < escala; m++)
                                {
                                    for (int n = 0; n < escala; n++)
                                    {
                                        bitmap.SetPixel(colunaInicio + n, linhaInicio + m, Color.Red);
                                    }
                                }
                            }
                            else if (valor == 55) //ROI underfill
                            {
                                //Preenche os pixels
                                int linhaInicio = i * escala;
                                int colunaInicio = j * escala;

                                for (int m = 0; m < escala; m++)
                                {
                                    for (int n = 0; n < escala; n++)
                                    {
                                        bitmap.SetPixel(colunaInicio + n, linhaInicio + m, Color.Black);
                                    }
                                }
                            }

                            posicaoBusca ++;
                        }
                    }

                    return bitmap;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return bitmap;
        }

        public Bitmap BuscarBitmapDadosProcessados(int largura, int altura, int numeroDB, int inicio, int escala)
        {
            Bitmap bitmap = new Bitmap(largura * escala, altura * escala);
            if (Conectado)
            {
                try
                {
                    int quantidadeBytes = Convert.ToInt32(Math.Floor((double)((largura * altura) / 8) + 1));
                    byte[] rcv = new byte[largura * altura + 10];                    
                    byte[] rcvTemp = new byte[quantidadeBytes];

                    client.ReadArea(S7Consts.S7AreaDB, numeroDB, inicio, quantidadeBytes, S7Consts.S7WLByte, rcvTemp, ref bytesLidosProcessado);

                    if (bytesLidosProcessado == 0)
                        return bitmap;

                    int index = 0;
                    for (int i = 0; i < quantidadeBytes; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            rcv[index++] = ConvertByteToBitAddres(rcvTemp[i], j);
                        }
                    }

                    if (bytesLidosProcessado == 1)
                        bytesLidosProcessado = largura * altura;

                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        //Limpa o bitmap
                        g.Clear(Color.White);
                    }

                    int posicaoBusca = 0;
                    for (int i = 0; i < altura; i++)
                    {
                        for (int j = 0; j < largura; j++)
                        {
                            if (rcv[posicaoBusca] == 1) //ROI boa
                            {
                                //Preenche os pixels
                                int linhaInicio = i * escala;
                                int colunaInicio = j * escala;

                                for (int m = 0; m < escala; m++)
                                {
                                    for (int n = 0; n < escala; n++)
                                    {
                                        bitmap.SetPixel(colunaInicio + n, linhaInicio + m,  Color.Black);
                                    }
                                }
                            }
                            posicaoBusca += 1;
                        }
                    }

                    return bitmap;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            return bitmap;
        }

        private byte ConvertByteToBitAddres(byte byteToConvert, int bitToReturn)
        {
            int mask = 1 << bitToReturn;
            if ((byteToConvert & mask) == mask)
            {
                return 1;
            }else
                return 0;
        }
    }
}
