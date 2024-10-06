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
    public partial class Frm_Tela7 : Form
    {
        public Frm_Tela7()
        {
            InitializeComponent();
        }

        private void Frm_Tela7_Load(object sender, EventArgs e)
        {
            string[] vetor5 = new string[7];

            List_Vetor5.Items.Add(vetor5[0] = "Domingo");
            List_Vetor5.Items.Add(vetor5[1] = "Segunda");
            List_Vetor5.Items.Add(vetor5[2] = "Terça");
            List_Vetor5.Items.Add(vetor5[3] = "Quarta");
            List_Vetor5.Items.Add(vetor5[4] = "Quinta");
            List_Vetor5.Items.Add(vetor5[5] = "Sexta");
            List_Vetor5.Items.Add(vetor5[6] = "Sábado");

        }
    }
}
