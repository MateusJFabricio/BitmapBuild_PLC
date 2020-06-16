using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapCLP
{
    public partial class Form1 : Form
    {
        Conexao conn = new Conexao();
        private Task taskRecebida;
        private Task taskImagemTratada;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (txtIp.TextLength > 0)
            {
                try
                {
                    if (conn.Conectar(txtIp.Text))
                    {
                        btnConectar.Enabled = false;
                        panel.Enabled = true;
                        txtIp.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Nao foi possivel conectar");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnBuscarDados_Click(object sender, EventArgs e)
        {
            int larguraImagem, alturaImage, dbRecebimento, dbImagemTratada, inicioRecebimento, inicioImagemTratada, escala;

            if (!int.TryParse(txtAlturaImagem.Text, out alturaImage))
            {
                MessageBox.Show("Altura da imagem nao esta preenchido ou nao e um valor numerico");
                return;
            }

            if (!int.TryParse(txtLarguraImagem.Text, out larguraImagem))
            {
                MessageBox.Show("Largura da imagem nao esta preenchido ou nao e um valor numerico");
                return;
            }

            if (!int.TryParse(txtDbRecebimento.Text, out dbRecebimento))
            {
                MessageBox.Show("DB recebimento da imagem nao esta preenchido ou nao e um valor numerico");
                return;
            }

            if (!int.TryParse(txtDBImagemTratada.Text, out dbImagemTratada))
            {
                MessageBox.Show("Numero da DB da imagem tratada nao esta preenchido ou nao e um valor numerico");
                return;
            }

            if (!int.TryParse(txtInicioRecebimento.Text, out inicioRecebimento))
            {
                MessageBox.Show("Inicio do recebimento nao esta preenchido ou nao e um valor numerico");
                return;
            }

            if (!int.TryParse(txtInicioImagemTratada.Text, out inicioImagemTratada))
            {
                MessageBox.Show("Inicio da imagem tratada nao esta preenchido ou nao e um valor numerico");
                return;
            }

            if (!int.TryParse(txtEscala.Text, out escala))
            {
                MessageBox.Show("A escada da imagem nao esta preenchido ou nao e um valor numerico");
                return;
            }

            try
            {
                btnConectar.Enabled = false;

                if (!conn.Conectado)
                {
                    conn.Conectar(txtIp.Text);
                    Thread.Sleep(1000);
                }
                    

                progressBarRecebida.Value = 0;
                progressBarRecebida.PerformStep();
                taskRecebida = null;
                taskRecebida = new Task(
                    () =>
                    {
                        
                        pbImagemRecebida.Image = conn.BuscarBitmapDadosRecebidos(larguraImagem, alturaImage, dbRecebimento, inicioRecebimento, escala);
                    }
                    
                );
                taskRecebida.Start();
                taskRecebida.Wait();

                progressBarTratada.Value = 0;
                progressBarTratada.PerformStep();

                taskImagemTratada = new Task(
                    () =>
                    {
                        pbImagemTratada.Image = conn.BuscarBitmapDadosProcessados(larguraImagem, alturaImage, dbImagemTratada, inicioImagemTratada, escala);
                    }
                );

                taskImagemTratada.Start();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtInicioInputRecebimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool fin1 = false, fin2 = false;

            if (taskImagemTratada != null && taskRecebida != null)
            {
                if (taskImagemTratada.Status == TaskStatus.RanToCompletion)
                {
                    progressBarTratada.Value = progressBarTratada.Maximum;
                    fin1 = true;
                }

                if (taskRecebida.Status == TaskStatus.RanToCompletion)
                {
                    progressBarRecebida.Value = progressBarRecebida.Maximum;
                    fin2 = true;
                }

                btnBuscarDados.Enabled = fin1 && fin2;
                
            }

            lblLidoRecebida.Text = conn.bytesLidosRecebidos.ToString();
            lblLidoTratada.Text = conn.bytesLidosProcessado.ToString();

        }
    }
}
