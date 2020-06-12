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
    public partial class FrmCurso : Form
    {
        public FrmCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso(txtNome.Text,int.Parse(txtCarga.Text),double.Parse(txtValor.Text));
            curso.Inserir(curso);
            MessageBox.Show("Curso Inserido!");
        }

        private void LimparCampos()
        { 
            txtNome.Clear();
            txtCarga.Clear();
            txtValor.Clear();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Nome = txtNome.Text;
            curso.CargaHoraria = Convert.ToInt32(txtCarga.Text);
            curso.Valor = Convert.ToInt32(txtValor.Text);
            curso.Alterar(curso);
            MessageBox.Show("Curso Alterado!");
        }
    }
}
