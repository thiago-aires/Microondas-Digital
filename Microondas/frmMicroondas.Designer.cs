namespace Microondas
{
    partial class frmMicroondas
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
            this.lblTextoExplicativo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionarPrograma = new System.Windows.Forms.Button();
            this.prbProgresso = new System.Windows.Forms.ProgressBar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPrograma = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtEntradaTempoPotencia = new System.Windows.Forms.TextBox();
            this.btnInicioRapido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLog = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTextoExplicativo
            // 
            this.lblTextoExplicativo.AutoSize = true;
            this.lblTextoExplicativo.Location = new System.Drawing.Point(585, 46);
            this.lblTextoExplicativo.Name = "lblTextoExplicativo";
            this.lblTextoExplicativo.Size = new System.Drawing.Size(154, 17);
            this.lblTextoExplicativo.TabIndex = 4;
            this.lblTextoExplicativo.Text = "Label para Explicações";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAdicionarPrograma);
            this.panel1.Controls.Add(this.prbProgresso);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnPausar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbPrograma);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.txtEntradaTempoPotencia);
            this.panel1.Controls.Add(this.btnInicioRapido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 359);
            this.panel1.TabIndex = 3;
            // 
            // btnAdicionarPrograma
            // 
            this.btnAdicionarPrograma.Location = new System.Drawing.Point(419, 140);
            this.btnAdicionarPrograma.Name = "btnAdicionarPrograma";
            this.btnAdicionarPrograma.Size = new System.Drawing.Size(39, 22);
            this.btnAdicionarPrograma.TabIndex = 5;
            this.btnAdicionarPrograma.Text = "+";
            this.btnAdicionarPrograma.UseVisualStyleBackColor = true;
            this.btnAdicionarPrograma.Click += new System.EventHandler(this.btnAdicionarPrograma_Click);
            // 
            // prbProgresso
            // 
            this.prbProgresso.Location = new System.Drawing.Point(31, 309);
            this.prbProgresso.Name = "prbProgresso";
            this.prbProgresso.Size = new System.Drawing.Size(428, 23);
            this.prbProgresso.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(252, 245);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(207, 44);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(28, 245);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(207, 44);
            this.btnPausar.TabIndex = 6;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Programa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entrada:";
            // 
            // cbbPrograma
            // 
            this.cbbPrograma.FormattingEnabled = true;
            this.cbbPrograma.Location = new System.Drawing.Point(28, 139);
            this.cbbPrograma.Name = "cbbPrograma";
            this.cbbPrograma.Size = new System.Drawing.Size(376, 24);
            this.cbbPrograma.TabIndex = 4;
            this.cbbPrograma.SelectedIndexChanged += new System.EventHandler(this.cbbPrograma_SelectedIndexChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(28, 183);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(207, 46);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnIniciar_MouseClick);
            // 
            // txtEntradaTempoPotencia
            // 
            this.txtEntradaTempoPotencia.Location = new System.Drawing.Point(28, 71);
            this.txtEntradaTempoPotencia.Name = "txtEntradaTempoPotencia";
            this.txtEntradaTempoPotencia.Size = new System.Drawing.Size(431, 22);
            this.txtEntradaTempoPotencia.TabIndex = 0;
            this.txtEntradaTempoPotencia.Text = "frango/30";
            this.txtEntradaTempoPotencia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEntradaTempoPotencia_MouseClick);
            // 
            // btnInicioRapido
            // 
            this.btnInicioRapido.Location = new System.Drawing.Point(252, 183);
            this.btnInicioRapido.Name = "btnInicioRapido";
            this.btnInicioRapido.Size = new System.Drawing.Size(207, 46);
            this.btnInicioRapido.TabIndex = 2;
            this.btnInicioRapido.Text = "Iniciar Rapido";
            this.btnInicioRapido.UseVisualStyleBackColor = true;
            this.btnInicioRapido.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnInicioRapido_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Microondas Digital";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lblLog);
            this.panel2.Location = new System.Drawing.Point(61, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 190);
            this.panel2.TabIndex = 6;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(15, 18);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(32, 17);
            this.lblLog.TabIndex = 6;
            this.lblLog.Text = "Log";
            // 
            // frmMicroondas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1220, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTextoExplicativo);
            this.Controls.Add(this.panel1);
            this.Name = "frmMicroondas";
            this.Text = "Microondas Digital - Prova Técnica Benner - Desenvolvido por Thiago Aires";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoExplicativo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdicionarPrograma;
        private System.Windows.Forms.ProgressBar prbProgresso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPrograma;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtEntradaTempoPotencia;
        private System.Windows.Forms.Button btnInicioRapido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Timer timer;
    }
}

