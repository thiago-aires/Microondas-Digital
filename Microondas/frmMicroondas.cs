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
    public partial class frmMicroondas : Form
    {
        private Controlador controlador;
        private int flag_pausar_retomar; //0 pausar, 1 retomar

        public frmMicroondas()
        {
            InitializeComponent();
            controlador = new Controlador(this);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lblLog.Text = "";

            flag_pausar_retomar = 0;
            btnPausar.Text = "Pausar"; //por padrão o inicial será pausar

            lblTextoExplicativo.Text = "Para utilizar o microondas é necessário digitar" +
                "\no nome do alimento / tempo de aquecimento\n" +
                "Por exemplo: 'Frango/30' e clicar no botão iniciar" +
                "\nPor padrão o microondas assume a potência 10, " +
                "\ncaso deseje trocar basta adicionar após o tempo '/potência desejada'" +
                "\nPor Exemplo: 'Frango/30/5'" +
                "\n\nCaso deseje iniciar um programa pré existente digite apenas o nome do alimento," +
                "\nselecione o programa desejado e clique em iniciar." +
                "\n\nÉ possível criar um novo programa clicando no botão '+'" +
                "\n\nCaso deseje iniciar rapidamente digite apenas o nome do alimento e clique em  'Iniciar Rapido'" +
                "\npor padrão o tempo é de 30 segundos e potência 8";
        }


        /*
         * Método que adiciona caracteres na textbox de entrada 
         * para informar ao usuário a situação do aquecimento
         * 
         * string info =  caractere que será adicionado a cada segundo
         * int qtd = representa a potencia, o numero de info que será add.
         */
        public void informaUsuario(string info, int qtd)
        {
            if(prbProgresso.Value != prbProgresso.Maximum)
            {
                prbProgresso.Value += 1;
            }
            
            for (int i = 1; i <= qtd; i++)
            {
                txtEntradaTempoPotencia.Text += info;
            }
        }

        public void informaUsuarioTerminou()
        {
            txtEntradaTempoPotencia.Text += "\taquecida";
            btnIniciar.Enabled = true;
            btnInicioRapido.Enabled = true;
            cbbPrograma.Text = "";
        }

        public void setProgressBar(int max)
        {
            prbProgresso.Maximum = max;
        }

        public void setListaProgramas(List<Programa> progs)
        {
            cbbPrograma.Items.Clear();
            foreach(Programa p in progs)
            {
                cbbPrograma.Items.Add(p.getNomeAlimento());
            }
        }

        public void printLog(string log)
        {
            lblLog.Text = log;
        }

        private void btnIniciar_MouseClick(object sender, MouseEventArgs e)
        {
            btnIniciar.Enabled = false;
            btnInicioRapido.Enabled = false;
            prbProgresso.Value = 0;
            int i = 99999;
            if (!cbbPrograma.Text.Equals(""))
                i = cbbPrograma.SelectedIndex;

            controlador.iniciar(txtEntradaTempoPotencia.Text, i);
        }

        private void btnInicioRapido_MouseClick(object sender, MouseEventArgs e)
        {
            btnIniciar.Enabled = false;
            btnInicioRapido.Enabled = false;
            prbProgresso.Value = 0;
            controlador.iniciarRapido(txtEntradaTempoPotencia.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!controlador.microondasAtivado()) return;
            controlador.cancelar();
            prbProgresso.Value = 0;
            txtEntradaTempoPotencia.Text = "CANCELADO";
            btnIniciar.Enabled = true;
            btnInicioRapido.Enabled = true;
            cbbPrograma.Text = "";
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (!controlador.microondasAtivado()) return;


            if(flag_pausar_retomar == 0) //atualmente é pausar?
            {
                controlador.pausar();
                flag_pausar_retomar = 1;
                btnPausar.Text = "Retomar";
            } else
            {
                controlador.retomar();
                flag_pausar_retomar = 0;
                btnPausar.Text = "Pausar";
            }
        }

        private void btnAdicionarPrograma_Click(object sender, EventArgs e)
        {
            addPrograma f = new addPrograma();
            f.setControlador(controlador);
            f.Show();
        }

        private void cbbPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            printLog(controlador.pegaInfoPrograma(cbbPrograma.SelectedIndex) +"\n"+
                lblLog.Text);
        }

        private void txtEntradaTempoPotencia_MouseClick(object sender, MouseEventArgs e)
        {
            btnIniciar.Enabled = true;
            btnInicioRapido.Enabled = true;
        }
    }
}
