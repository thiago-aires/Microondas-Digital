using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas
{
    public class Controlador
    {
        private frmMicroondas frmMicroondas;
        private Log log;
        private int tempo;
        private int potencia;
        private string nomeAlimento;
        private Microondas mi;
        private string caracterInfo;
        private int contador;
        private Timer timer;

        public Controlador(frmMicroondas frm)
        {
            frmMicroondas = frm;
            log = new Log();
            mi = new Microondas();
            frmMicroondas.setListaProgramas(mi.getProgramas());
            timer = new Timer();
        }

        private Boolean setEntrada(string entrada, int padraoPotencia)
        {
            if (validaEntrada(entrada, padraoPotencia))
            {
                imprimeLog("Entrada Valida");
                return true;
            }
            else
            {
                imprimeLog("entrada inválida, por favor digite novamente.");
                return false;
                
            }
        }
        

        /*
         * Método para validar a entrada, verifica se está no padrão
         * e já armazena nas variáveis
         */
        private bool validaEntrada(string entrada, int padraoPotencia)
        {
            string[] entrada_dividida = entrada.Split('/');
            

            //se potencia padrão for 8 é início rápido, portanto só aquecer
            if(padraoPotencia == 8)
            {
                this.nomeAlimento = entrada_dividida[0];
                this.tempo = 30; //padrão
                this.potencia = padraoPotencia;
                return true;
            }

            try
            {
                if (entrada_dividida.Length > 3)
                {
                    imprimeLog("Exemplo Entrada: 'Frango/30/10', 'Frango/89', 'Frango'");
                    return false;
                }

                switch (entrada_dividida.Length)
                {
                    case 1:
                        imprimeLog("É necessário digitar o tempo");
                        return false;
                    case 2:
                        this.nomeAlimento = entrada_dividida[0];
                        this.tempo = int.Parse(entrada_dividida[1]);
                        this.potencia = padraoPotencia; 
                        break;
                    case 3:
                        this.nomeAlimento = entrada_dividida[0];
                        this.tempo = int.Parse(entrada_dividida[1]);
                        this.potencia = int.Parse(entrada_dividida[2]);
                        break;
                }

                if (this.tempo > 120 | this.tempo < 1)
                {
                    imprimeLog("Tempo de aquecimento fora do limite: min 1s, max 120s");
                    return false;
                }

                if(this.potencia > 10 | this.potencia < 1)
                {
                    imprimeLog("Potencia de aquecimento fora do limite: min 1, max 10");
                    return false;
                }

                return true;
            }
            catch
            {
                imprimeLog("Digite somente numeros para tempo e potencia");
                return false;
            }
        }

        public int getPotencia()
        {
            return this.potencia;
        }

        public string getCaracterInformativo()
        {
            return this.caracterInfo;
        }

        public Boolean microondasAtivado()
        {
            return mi.estaAquecendo();
        }

        private void imprimeLog(string msg)
        {
            log.add(msg);
            frmMicroondas.printLog(log.getLog());
        }

        public void iniciar(string entrada, int indexProg)
        {
            if(indexProg == 99999) //caso seja igual significa que não escolheu um programa pré definido
            { 
                // 10 é a potência padrão para o botao iniciar
                if (setEntrada(entrada, 10))
                {
                    this.caracterInfo = ".";
                    //microondas pode aquecer
                    aquecer();

                }
            } else
            {
                string[] e = entrada.Split('/');

                //verificando se contem o nome do alimento no nome do programa
                if (mi.getPrograma(indexProg).getNomeAlimento().Contains(e[0]))
                {
                    setVariaveisPrograma(indexProg);
                    imprimeLog("Aquecer pelo programa: " + nomeAlimento);
                    aquecer();
                } else
                {
                    imprimeLog("Alimento incompatível com o programa");
                }

                
            }

        }

        public void iniciarRapido(string entrada)
        {                           //8 é a potência padrão para o botão inicar rápido
            if (setEntrada(entrada, 8))
            {
                //microondas pode aquecer
                this.caracterInfo = ".";
                aquecer();
            }
        }

        private void aquecer()
        {
            frmMicroondas.setProgressBar(tempo);
            mi.aquecer(tempo, potencia);
            timer.Interval = 1000;
            contador = 1;
            timer.Start();
            timer.Tick += new EventHandler(TimerEventProcessor);
        }

        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            frmMicroondas.informaUsuario(caracterInfo, potencia);
            imprimeLog("Aquecendo... " + contador);
            contador++;
            if(contador > tempo)
            {
                mi.pararAquecer();
                timer.Stop();
                imprimeLog("Terminou Aquecimento");
                frmMicroondas.informaUsuarioTerminou();
            }
        }

        public void cancelar()
        {
            if (mi.estaAquecendo())
            {
                mi.cancelar();
                imprimeLog("AQUECIMENTO CANCELADO");
                timer.Stop();
            }
        }

        public void pausar()
        {
            if (mi.estaAquecendo())
            {
                timer.Stop();
                imprimeLog("Aquecimento Pausado aos " + contador + " segundos");
            }
            
        }

        public void retomar()
        {
            if (mi.estaAquecendo())
            {
                timer.Start();
                imprimeLog("Aquecimento Retomado, faltam: " + (tempo - contador) + " segundos");
            }
        }

        private void setVariaveisPrograma(int index)
        {
            Programa p = mi.getPrograma(index);
            this.tempo = p.getTempo();
            this.potencia = p.getPotencia();
            this.caracterInfo = p.getcaractereInformativo();
            this.nomeAlimento = p.getNomeAlimento();
        }

        public void addPrograma(Programa prog)
        {
            if (verificaPrograma(prog))
            {
                mi.addPrograma(prog);
                imprimeLog("Programa adicionado com sucesso!");
                frmMicroondas.setListaProgramas(mi.getProgramas());
            }else
            {
                imprimeLog("Programa não adicionado");
            }
        }

        private Boolean verificaPrograma(Programa prog)
        {
            if(prog.getTempo() > 120 | prog.getTempo() < 1)
            {
                imprimeLog("Tempo do programa fora do limite 1s - 120s");
                return false;
            }

            if (prog.getPotencia() > 10 | prog.getPotencia() < 1)
            {
                imprimeLog("Potência do programa fora do limite 1 - 10");
                return false;
            }

            return true;
        }

        public string pegaInfoPrograma(int index)
        {
            return mi.getPrograma(index).imprime();
        }
    }
}
