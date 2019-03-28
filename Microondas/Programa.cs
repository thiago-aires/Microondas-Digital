using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    public class Programa
    {
        private string nomeAlimento;
        private string caractereInformativo;
        private int tempo;
        private int potencia;
        private string instrucoes;

        public Programa(string nomeAlimento, string caractereInformativo, int tempo, int potencia, string instrucoes)
        {
            this.nomeAlimento = nomeAlimento;
            this.caractereInformativo = caractereInformativo;
            this.tempo = tempo;
            this.potencia = potencia;
            this.instrucoes = instrucoes;
        }

        public string getNomeAlimento()
        {
            return this.nomeAlimento;
        }

        public void setNomeAlimento(string nomeAlimento)
        {
            this.nomeAlimento = nomeAlimento;
        }

        public string getcaractereInformativo()
        {
            return this.caractereInformativo;
        }

        public void setCaractereInformativo(string caractereInformativo)
        {
            this.caractereInformativo = caractereInformativo;
        }

        public int getTempo()
        {
            return this.tempo;
        }

        public void setTempo(int tempo)
        {
            this.tempo = tempo;
        }

        public int getPotencia()
        {
            return this.potencia;
        }

        public void setPotencia(int potencia)
        {
            this.potencia = potencia;
        }

        public string getInstrucoes()
        {
            return this.instrucoes;
        }

        public void setInstrucoes(string instrucoes)
        {
            this.instrucoes = instrucoes;
        }

        public string imprime()
        {
            return "Programa para " + nomeAlimento + "; instruções: " + instrucoes + "\nTempo: " + tempo +
                "s Potência: " + potencia + "; Caracter informativo: " + caractereInformativo;
        }
    }
}
