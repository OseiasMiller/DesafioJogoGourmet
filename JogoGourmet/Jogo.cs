using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet
{
    class Jogo
    {

        List<TipoPrato> tipoPratos { get; set; }

        public Jogo()
        {
            tipoPratos = new List<TipoPrato>();

            Prato lasanha = new Prato("Lasanha");
            TipoPrato massa = new TipoPrato("Massa");
            massa.Pratos.Add(lasanha);

            TipoPrato bolo = new TipoPrato("Bolo de Chocolate");

            tipoPratos.Add(massa);
            tipoPratos.Add(bolo);

        }

        public void Iniciar()
        {
            for (int i = 0; i<  tipoPratos.Count; i ++) {
                TipoPrato tipo = tipoPratos[i];               
                string nome =    tipo.Nome;
                DialogResult dialogResult = MessageBox.Show($"O prato que você pensou é {nome}", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Acertei(tipo);
                    break;

                } else if (dialogResult == DialogResult.No)
                {
                    if ((i + 1) == tipoPratos.Count)
                    {
                        NovoTipo();
                        break;
                    }
                }

            }
        }

        private void Acertei(TipoPrato tipo)
        {
            if (tipo.Pratos.Count > 0)
            {
                for (int i = 0; i < tipo.Pratos.Count; i++)
                {
                    string nome = tipo.Pratos[i].Nome;
                
                    DialogResult dialogResult = MessageBox.Show($"O prato que você pensou é {nome}", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Finalizar();
                        break;

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        if ((i + 1) == tipo.Pratos.Count)
                        {
                            Prato novoPrato = NovoPrato();
                            tipo.Pratos.Insert(0, novoPrato);
                            break;
                        }
                    }
                }
            } else
            {
                Finalizar();
            }
        }

        private Prato NovoPrato()
        {
            string novoPrato = Interaction.InputBox("Qual prato você pensou ?", "Desisto");
            return new Prato(novoPrato);            
            
        }

        private void NovoTipo()
        {
            Prato novoPrato = NovoPrato();
            string novoTipo = Interaction.InputBox($"{novoPrato.Nome} é _________ mas bolo de chocolate não ?", "Desisto");
            TipoPrato tipoPrato = new TipoPrato(novoTipo);
            tipoPrato.Pratos.Insert(0, novoPrato);
            tipoPratos.Insert( tipoPratos.Count - 1 , tipoPrato);         

        }

        private void Finalizar()
        {
            MessageBox.Show("Acertei de novo!", "Acertei",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





    }
}
