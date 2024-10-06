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
    public partial class Frm_Abertura : Form
    {
        public Frm_Abertura()
        {
            InitializeComponent();
        }

        private void Frm_Abertura_Load(object sender, EventArgs e)
        {
            Wmp_Video.URL = "Vinheta.mp4";
            Wmp_Video.uiMode = "None";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Stop();
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }
    }
}
