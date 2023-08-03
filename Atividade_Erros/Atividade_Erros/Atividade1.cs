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
    public partial class Atividade1 : Form
    {
        public Atividade1()
        {
            InitializeComponent();
        }

        Class1 Animal = new Class1();
        int cont = 0;
        string animal;

        private void btnAnimais_Click(object sender, EventArgs e)
        {

            try
            {
                animal = txtAnimais.Text;
                Animal.tipoAnimal(animal);
                cont++;
                
                if(cont == 5)
                {
                    MessageBox.Show(Animal.qntiAnimais());
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool Mostrar(int cont)
        {
            if (cont == 5)
                return true;
            else return false;
        }
    }
}
