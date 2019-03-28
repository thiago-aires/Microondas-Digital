using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas
{
    public partial class addPrograma : Form
    {
        private Controlador controlador;

        public addPrograma()
        {
            InitializeComponent();
        }

        public void setControlador(Controlador controlador)
        {
            this.controlador = controlador;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNomeAlimento.Text.Equals("") | txtIntrucoes.Text.Equals("")
                | txtTempo.Text.Equals("") | txtPotencia.Text.Equals("")
                | txtCaracterInfo.Text.Equals(""))
            {
                MessageBox.Show("Informe todos os dados");
                return;
            }

            controlador.addPrograma(new Programa(txtNomeAlimento.Text, txtCaracterInfo.Text, 
                int.Parse(txtTempo.Text), int.Parse(txtPotencia.Text), txtIntrucoes.Text));
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
