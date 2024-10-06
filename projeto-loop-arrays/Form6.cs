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
    public partial class Frm_Tela6 : Form
    {
        public Frm_Tela6()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }

        private void Frm_Tela6_Load(object sender, EventArgs e)
        {
            int[,] matriz1 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7 , 8 }, { 9, 10 } };

            List_Matriz1.Items.Add("Matriz [0, 0]: " + matriz1[0, 0]);
            List_Matriz1.Items.Add("Matriz [0, 1]: " + matriz1[0, 1]);
            List_Matriz1.Items.Add("Matriz [1, 0]: " + matriz1[1, 0]);
            List_Matriz1.Items.Add("Matriz [1, 1]: " + matriz1[1, 1]);
            List_Matriz1.Items.Add("Matriz [2, 0]: " + matriz1[2, 0]);
            List_Matriz1.Items.Add("Matriz [2, 1]: " + matriz1[2, 1]);
            List_Matriz1.Items.Add("Matriz [3, 0]: " + matriz1[3, 0]);
            List_Matriz1.Items.Add("Matriz [3, 1]: " + matriz1[3, 1]);
            List_Matriz1.Items.Add("Matriz [4, 0]: " + matriz1[4, 0]);
            List_Matriz1.Items.Add("Matriz [4, 1]: " + matriz1[4, 1]);

            string[,] matriz2 = new string[1, 5];

            List_Matriz2.Items.Add(matriz2[0, 0] = "S");
            List_Matriz2.Items.Add(matriz2[0, 1] = "E");
            List_Matriz2.Items.Add(matriz2[0, 2] = "N");
            List_Matriz2.Items.Add(matriz2[0, 3] = "A");
            List_Matriz2.Items.Add(matriz2[0, 4] = "C");
        }
    }
}
