using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Microondas
{
    class Microondas
    {
        private List<Programa> programas;
        private Boolean aquecendo;

        public Microondas()
        {
            programas = new List<Programa>();
            programas.Add(new Programa("pipoca", "P", 120, 5, "Estourar Pipoca"));
            programas.Add(new Programa("pizza", "Z", 45, 10, "Esquentar pizza"));
            programas.Add(new Programa("pudim, bolo, bolo de caneca", "X", 120, 10, "Fazer bolos, pudins que demoram mais tempo de cozimento"));
            programas.Add(new Programa("congelados, descongelados", "C", 10, 1, "Congelados que não vão descongelar"));
            programas.Add(new Programa("arroz, batata, mandioca, ovo", "A", 87, 3, "Fazer arroz microondas?"));
        }

        public Programa getPrograma(int index)
        {
            return this.programas[index];
        }

        public List<Programa> getProgramas()
        {
            return this.programas;
        }

        public void addPrograma(Programa prog)
        {
            this.programas.Add(prog);
        }

        public Boolean estaAquecendo()
        {
            return aquecendo;
        }

        public void aquecer(int tempo, int potencia)
        {
            // aquece por tempo / potencia
            this.aquecendo = true;
        }

        public void pausar()
        {

        }

        public void cancelar()
        {
            this.aquecendo = false;
        }

        public void pararAquecer()
        {
            this.aquecendo = false;
        }
    }
}
