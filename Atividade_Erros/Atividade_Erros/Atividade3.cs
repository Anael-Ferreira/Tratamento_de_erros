using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Atividade_Erros.Class3;

namespace Atividade_Erros
{
    public partial class Atividade3 : Form
    {
        public Atividade3()
        {
            InitializeComponent();
        }

        Class3 pessoa = new Class3();

        private void Atividade3_Load(object sender, EventArgs e)
        {

        }

        private void btnEncontrarMaisVelha_Click(object sender, EventArgs e)
        {
            if (pessoa.Idades == 0)
            {
                MessageBox.Show("Nenhuma pessoa cadastrada!");
            }
            else
            {
                MessageBox.Show("A pessoa mais velha é:");
                MessageBox.Show(pessoa.ExibirDados());
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = 0;

            if (int.TryParse(txtIdade.Text, out idade))
            {
                txtNome.Clear();
                txtIdade.Clear();

                MessageBox.Show("Pessoa cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Digite um valor válido para a idade!");
            }
        }

    }
}

