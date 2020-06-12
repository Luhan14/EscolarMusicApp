using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolarMusicApp
{
    public partial class FrmProfessor : Form
    {
        public FrmProfessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor(
                txtNome.Text, txtCpf.Text, txtEmail.Text, txtTelefone.Text
                );

            professor.Inserir(professor);
            MessageBox.Show("Professor inserido com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            Professor professor = new Professor();
            foreach (var item in professor.ListarTodos())
            {
                Lista.Items.Add(item.Id + " - " + item.Nome + " - " + item.Email + " - " + item.DataCadastro);
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Nome = txtNome.Text;
            professor.Telefone = txtTelefone.Text;
            professor.Alterar(professor);
            MessageBox.Show("Professor Alterado com sucesso!");
        }
    }
}
