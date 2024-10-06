using System;
using System.Windows.Forms;

namespace projeto_loop_arrays
{
    public partial class Frm_Tela5 : Form
    {
        public Frm_Tela5()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }

        private void Frm_Tela5_Load(object sender, EventArgs e)
        {
            int[] vetor1 = { 10, 9, 8, 7, 6 };

            List_Vetor1.Items.Add("1º Vetor: " + vetor1[0]);
            List_Vetor1.Items.Add("2º Vetor: " + vetor1[1]);
            List_Vetor1.Items.Add("3º Vetor: " + vetor1[2]);
            List_Vetor1.Items.Add("4º Vetor: " + vetor1[3]);
            List_Vetor1.Items.Add("5º Vetor: " + vetor1[4]);

            int[] vetor2 = { 60, 50, 40, 30, 20, 10 };

            List_Vetor2.Items.Clear();

            for (int i = 0; i < vetor2.Length; i++)
            {
                List_Vetor2.Items.Add("Vetor [" + i + "]: " + vetor2[i]);
            }

            int[] vetor3 = new int[3];

            List_Vetor3.Items.Add(vetor3[0] = 15);
            List_Vetor3.Items.Add(vetor3[1] = 25);
            List_Vetor3.Items.Add(vetor3[2] = 35);

            int[] vetor4 = new int[3] { 6, 8, 6 };

            List_Vetor4.Items.Clear();
            for (int i = 0; i < vetor4.Length; i++)
            {
                List_Vetor4.Items.Add(vetor4[i]);
            }

        }
    }
}