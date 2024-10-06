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
    public partial class Frm_Tela4 : Form
    {
        public Frm_Tela4()
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

        private void Txt_Numero1_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Numero1.Text == "")
            {
                List_Contagem1.Items.Clear();
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
                    List_Contagem2.Items.Clear();

                    for (contador = numero; contador >= 0; contador--)
                    {
                        List_Contagem2.Items.Add(contador);
                    }
                }
            }
        }

        private void Txt_Numero2_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Numero2.Text == "")
            {
                List_Contagem2.Items.Clear();
            }
        }

        private void Txt_Numero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // verifica se realmente as teclas selecionadas são iguais da condição
                
                MessageBox.Show("Somente Números!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyChar == 13)
            {
                if (Txt_Numero1.Text != "")
                {
                    numero = int.Parse(Txt_Numero1.Text);
                    List_Contagem1.Items.Clear();
                    for (contador = 0; contador <= numero; contador++)
                    {
                        List_Contagem1.Items.Add(contador);
                    }
                }
            }
        }
    }
}
