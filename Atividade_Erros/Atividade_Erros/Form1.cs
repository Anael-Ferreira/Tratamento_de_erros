using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Erros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtvUm_Click(object sender, EventArgs e)
        {
            Atividade1 atv1 = new Atividade1();
            atv1.ShowDialog();
        }

        private void btnAtvDois_Click(object sender, EventArgs e)
        {
            Atividade2 atv2 = new Atividade2();
            atv2.ShowDialog();
        }

        private void btnAtvTres_Click(object sender, EventArgs e)
        {
            Atividade3 atv3 = new Atividade3();
            atv3.ShowDialog();
        }
    }
}
