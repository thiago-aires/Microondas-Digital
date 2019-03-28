namespace Microondas
{
    partial class addPrograma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAlimento = new System.Windows.Forms.TextBox();
            this.txtIntrucoes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCaracterInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Alimento";
            // 
            // txtNomeAlimento
            // 
            this.txtNomeAlimento.Location = new System.Drawing.Point(16, 33);
            this.txtNomeAlimento.Name = "txtNomeAlimento";
            this.txtNomeAlimento.Size = new System.Drawing.Size(191, 22);
            this.txtNomeAlimento.TabIndex = 0;
            // 
            // txtIntrucoes
            // 
            this.txtIntrucoes.Location = new System.Drawing.Point(16, 93);
            this.txtIntrucoes.Name = "txtIntrucoes";
            this.txtIntrucoes.Size = new System.Drawing.Size(191, 22);
            this.txtIntrucoes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instruções de uso";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(251, 33);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(191, 22);
            this.txtTempo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tempo";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(251, 93);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(191, 22);
            this.txtPotencia.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Potência";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 195);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(191, 35);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(251, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(191, 35);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCaracterInfo
            // 
            this.txtCaracterInfo.Location = new System.Drawing.Point(16, 148);
            this.txtCaracterInfo.Name = "txtCaracterInfo";
            this.txtCaracterInfo.Size = new System.Drawing.Size(191, 22);
            this.txtCaracterInfo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Caracter Informativo";
            // 
            // addPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 259);
            this.Controls.Add(this.txtCaracterInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIntrucoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAlimento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addPrograma";
            this.Text = "addPrograma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAlimento;
        private System.Windows.Forms.TextBox txtIntrucoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCaracterInfo;
        private System.Windows.Forms.Label label5;
    }
}