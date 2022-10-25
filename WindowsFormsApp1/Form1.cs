using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Aluno> ListaAlunos = new List<Aluno>();

        public void carregarLista()
        {
            dataGridView1.Rows.Clear();
            foreach (Aluno a in ListaAlunos)
            {
                dataGridView1.Rows.Add(a.RA, a.Nome, a.n1, a.n2, a.n3, a.n4, a.media, a.situacao);
            }
        }


        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.RA = textBox1.Text;
            aluno.Nome = textBox2.Text;
            aluno.n1 = Convert.ToDouble(textBox3.Text);
            aluno.n2 = Convert.ToDouble(textBox4.Text);
            aluno.n3 = Convert.ToDouble(textBox5.Text);
            aluno.n4 = Convert.ToDouble(textBox6.Text);
            aluno.CalcMedia();
            aluno.defSituacao();

            bool existe = false;
            foreach (Aluno a in ListaAlunos)
            {
                if (a.RA == aluno.RA)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                ListaAlunos.Add(aluno);
                carregarLista();
                MessageBox.Show("Aluno adicionado com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Aluno já existe!!!");
            }



        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
