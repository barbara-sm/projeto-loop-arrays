using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_loop_arrays
{
    public partial class Frm_Tela3 : Form
    {
        public Frm_Tela3()
        {
            InitializeComponent();
        }

        int numero, contador;

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }

        private void Chk_For_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_For.Checked) // se a opção for marcada
            {
                Grp_Tabuada1.Visible = true;
            }
            else // se a opção NÃO for selecionada
            {
                Grp_Tabuada1.Visible = false;
            }
        }

        private void Txt_Numero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // verifica se realmente as teclas selecionadas são iguais da condição
                MessageBox.Show("Somente Números!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyChar == 13) // se pressionar a tecla ENTER
            {
                if (Txt_Numero1.Text != "")
                {
                    numero = int.Parse(Txt_Numero1.Text);
                    List_Tabuada1.Items.Clear(); // limpar os itens da lista

                    for (contador = 0; contador <= 10; contador++)
                    {
                        List_Tabuada1.Items.Add(numero + " x " + contador + " = " + numero * contador); // exibindo o resultado da tabuada
                    }
                }
            }
        }

        private void Txt_Numero1_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Numero1.Text == "")
            {
                List_Tabuada1.Items.Clear();
            }
        }

        private void Txt_Numero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Somente Números!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyChar == 13)
            {
                if (Txt_Numero2.Text != "")
                {
                    numero = int.Parse(Txt_Numero2.Text);
                    contador = 0;
                    List_Tabuada2.Items.Clear();
                    while (contador <= 10)
                    {
                        List_Tabuada2.Items.Add(numero + " x " + contador + " = " + numero * contador);
                        contador++;
                    }
                }
            }
        }

        private void Txt_Numero2_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Numero2.Text == "")
            {
                List_Tabuada2.Items.Clear();
            }
        }

        private void Chk_While_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_While.Checked)
            {
                Grp_Tabuada2.Visible = true;
            }
            else
            {
                Grp_Tabuada2.Visible = false;
            }
        }
    }
}
