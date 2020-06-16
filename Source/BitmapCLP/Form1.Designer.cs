namespace BitmapCLP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressBarRecebida = new System.Windows.Forms.ProgressBar();
            this.pbImagemRecebida = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBarTratada = new System.Windows.Forms.ProgressBar();
            this.pbImagemTratada = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInicioImagemTratada = new System.Windows.Forms.TextBox();
            this.txtDBImagemTratada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInicioRecebimento = new System.Windows.Forms.TextBox();
            this.txtDbRecebimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEscala = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLarguraImagem = new System.Windows.Forms.TextBox();
            this.txtAlturaImagem = new System.Windows.Forms.TextBox();
            this.btnBuscarDados = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLidoRecebida = new System.Windows.Forms.Label();
            this.lblLidoTratada = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemRecebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemTratada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP CLP:";
            // 
            // txtIp
            // 
            this.txtIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtIp.Location = new System.Drawing.Point(98, 17);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(207, 30);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "192.168.0.1";
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnConectar.Location = new System.Drawing.Point(311, 17);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(128, 30);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.splitContainer1);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.btnBuscarDados);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(0, 53);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1036, 599);
            this.panel.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 206);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblLidoRecebida);
            this.splitContainer1.Panel1.Controls.Add(this.progressBarRecebida);
            this.splitContainer1.Panel1.Controls.Add(this.pbImagemRecebida);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblLidoTratada);
            this.splitContainer1.Panel2.Controls.Add(this.progressBarTratada);
            this.splitContainer1.Panel2.Controls.Add(this.pbImagemTratada);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 369);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 14;
            // 
            // progressBarRecebida
            // 
            this.progressBarRecebida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarRecebida.Location = new System.Drawing.Point(6, 338);
            this.progressBarRecebida.Name = "progressBarRecebida";
            this.progressBarRecebida.Size = new System.Drawing.Size(483, 23);
            this.progressBarRecebida.TabIndex = 15;
            // 
            // pbImagemRecebida
            // 
            this.pbImagemRecebida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagemRecebida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemRecebida.Location = new System.Drawing.Point(6, 20);
            this.pbImagemRecebida.Name = "pbImagemRecebida";
            this.pbImagemRecebida.Size = new System.Drawing.Size(483, 315);
            this.pbImagemRecebida.TabIndex = 14;
            this.pbImagemRecebida.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Imagem recebida";
            // 
            // progressBarTratada
            // 
            this.progressBarTratada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarTratada.Location = new System.Drawing.Point(4, 337);
            this.progressBarTratada.Name = "progressBarTratada";
            this.progressBarTratada.Size = new System.Drawing.Size(527, 23);
            this.progressBarTratada.TabIndex = 16;
            // 
            // pbImagemTratada
            // 
            this.pbImagemTratada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagemTratada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemTratada.Location = new System.Drawing.Point(3, 20);
            this.pbImagemTratada.Name = "pbImagemTratada";
            this.pbImagemTratada.Size = new System.Drawing.Size(528, 315);
            this.pbImagemTratada.TabIndex = 15;
            this.pbImagemTratada.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Imagem tratada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtEscala);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLarguraImagem);
            this.groupBox1.Controls.Add(this.txtAlturaImagem);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 186);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracoes";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtInicioImagemTratada);
            this.panel2.Controls.Add(this.txtDBImagemTratada);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(5, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 29);
            this.panel2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Inicio:";
            // 
            // txtInicioImagemTratada
            // 
            this.txtInicioImagemTratada.Location = new System.Drawing.Point(250, 4);
            this.txtInicioImagemTratada.Name = "txtInicioImagemTratada";
            this.txtInicioImagemTratada.Size = new System.Drawing.Size(66, 20);
            this.txtInicioImagemTratada.TabIndex = 19;
            this.txtInicioImagemTratada.Text = "0";
            // 
            // txtDBImagemTratada
            // 
            this.txtDBImagemTratada.Location = new System.Drawing.Point(132, 3);
            this.txtDBImagemTratada.Name = "txtDBImagemTratada";
            this.txtDBImagemTratada.Size = new System.Drawing.Size(66, 20);
            this.txtDBImagemTratada.TabIndex = 18;
            this.txtDBImagemTratada.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "DB Imagem processada:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtInicioRecebimento);
            this.panel1.Controls.Add(this.txtDbRecebimento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(5, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 29);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Inicio:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtInicioRecebimento
            // 
            this.txtInicioRecebimento.Location = new System.Drawing.Point(250, 3);
            this.txtInicioRecebimento.Name = "txtInicioRecebimento";
            this.txtInicioRecebimento.Size = new System.Drawing.Size(66, 20);
            this.txtInicioRecebimento.TabIndex = 18;
            this.txtInicioRecebimento.Text = "0";
            this.txtInicioRecebimento.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDbRecebimento
            // 
            this.txtDbRecebimento.Location = new System.Drawing.Point(132, 4);
            this.txtDbRecebimento.Name = "txtDbRecebimento";
            this.txtDbRecebimento.Size = new System.Drawing.Size(66, 20);
            this.txtDbRecebimento.TabIndex = 17;
            this.txtDbRecebimento.Text = "1";
            this.txtDbRecebimento.TextChanged += new System.EventHandler(this.txtInicioInputRecebimento_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "DB Recebimento:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEscala
            // 
            this.txtEscala.Location = new System.Drawing.Point(138, 155);
            this.txtEscala.Name = "txtEscala";
            this.txtEscala.Size = new System.Drawing.Size(66, 20);
            this.txtEscala.TabIndex = 12;
            this.txtEscala.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Escala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Largura Imagem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Altura Imagem:";
            // 
            // txtLarguraImagem
            // 
            this.txtLarguraImagem.Location = new System.Drawing.Point(138, 19);
            this.txtLarguraImagem.Name = "txtLarguraImagem";
            this.txtLarguraImagem.Size = new System.Drawing.Size(66, 20);
            this.txtLarguraImagem.TabIndex = 4;
            this.txtLarguraImagem.Text = "10";
            // 
            // txtAlturaImagem
            // 
            this.txtAlturaImagem.Location = new System.Drawing.Point(138, 53);
            this.txtAlturaImagem.Name = "txtAlturaImagem";
            this.txtAlturaImagem.Size = new System.Drawing.Size(66, 20);
            this.txtAlturaImagem.TabIndex = 5;
            this.txtAlturaImagem.Text = "10";
            // 
            // btnBuscarDados
            // 
            this.btnBuscarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBuscarDados.Location = new System.Drawing.Point(537, 146);
            this.btnBuscarDados.Name = "btnBuscarDados";
            this.btnBuscarDados.Size = new System.Drawing.Size(249, 52);
            this.btnBuscarDados.TabIndex = 6;
            this.btnBuscarDados.Text = "Buscar Dados";
            this.btnBuscarDados.UseVisualStyleBackColor = true;
            this.btnBuscarDados.Click += new System.EventHandler(this.btnBuscarDados_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLidoRecebida
            // 
            this.lblLidoRecebida.AutoSize = true;
            this.lblLidoRecebida.Location = new System.Drawing.Point(421, 4);
            this.lblLidoRecebida.Name = "lblLidoRecebida";
            this.lblLidoRecebida.Size = new System.Drawing.Size(30, 13);
            this.lblLidoRecebida.TabIndex = 16;
            this.lblLidoRecebida.Text = "Lido:";
            // 
            // lblLidoTratada
            // 
            this.lblLidoTratada.AutoSize = true;
            this.lblLidoTratada.Location = new System.Drawing.Point(501, 4);
            this.lblLidoTratada.Name = "lblLidoTratada";
            this.lblLidoTratada.Size = new System.Drawing.Size(30, 13);
            this.lblLidoTratada.TabIndex = 17;
            this.lblLidoTratada.Text = "Lido:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "byte";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(324, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "byte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 635);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Teste AMBEV ROBOSOFT";
            this.panel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemRecebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemTratada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtAlturaImagem;
        private System.Windows.Forms.TextBox txtLarguraImagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEscala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInicioRecebimento;
        private System.Windows.Forms.TextBox txtDbRecebimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInicioImagemTratada;
        private System.Windows.Forms.TextBox txtDBImagemTratada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbImagemRecebida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbImagemTratada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBarRecebida;
        private System.Windows.Forms.ProgressBar progressBarTratada;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLidoRecebida;
        private System.Windows.Forms.Label lblLidoTratada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

