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
    public partial class Atividade2 : Form
    {
        public Atividade2()
        {
            InitializeComponent();
        }

        Class2 area = new Class2();
        double B, H;

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                double b , h;

                area.Base = double.Parse(txtBase.Text);
                area.Altura = double.Parse(txtAltura.Text);

                b = area.Base;
                h = area.Altura;
                MessageBox.Show(area.CalcularArea(b,h).ToString());
                MessageBox.Show(area.Exibir());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
