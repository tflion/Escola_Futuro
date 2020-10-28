using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novoEscolaFuturo
{
    public partial class UserControlCadAluno : UserControl
    {
        ClassAluno aluno = new ClassAluno();
        int codAlunoClicado = 0;

        public UserControlCadAluno()
        {
            InitializeComponent();
        }

        private void btnMostrarCurso_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtNome.Text;
            aluno.Rg = txtRg.Text;
            aluno.Telefone = txtTelefone.Text;
            aluno.Endereco = txtEndereço.Text;

            if (aluno.Inserir() == true)
            {
                MessageBox.Show("Aluno cadastrado com sucesso!");
                dgvCadAluno.DataSource = aluno.RetAlunos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastraro aluno!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtNome.Text;
            aluno.Rg = txtRg.Text;
            aluno.Telefone = txtTelefone.Text;
            aluno.Endereco = txtEndereço.Text;

            if (aluno.Editar(codAlunoClicado) == true)
            {
                MessageBox.Show("Aluno foi editado com sucesso!");
                dgvCadAluno.DataSource = aluno.RetAlunos();
            }
            else
            {
                MessageBox.Show("Erro ao editar o aluno!");
            }
        }

        private void dgvCadAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCadAluno.Rows[e.RowIndex].Cells["codAluno"].
                       Value.ToString() != "")
                {
                    codAlunoClicado = int.Parse(dgvCadAluno.Rows
                        [e.RowIndex].Cells["codServico"].Value.ToString());
                }

                txtCurso.Text = dgvCadAluno.Rows[e.RowIndex].Cells["curso_codCurso"].Value.ToString();
                txtEndereço.Text = dgvCadAluno.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
                txtNome.Text = dgvCadAluno.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtRg.Text = dgvCadAluno.Rows[e.RowIndex].Cells["rg"].Value.ToString();
                txtTelefone.Text = dgvCadAluno.Rows[e.RowIndex].Cells["telefone"].Value.ToString();


                dgvCadAluno.DataSource = aluno.RetAlunos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtNome.Text;
            aluno.Rg = txtRg.Text;
            aluno.Telefone = txtTelefone.Text;
            aluno.Endereco = txtEndereço.Text;

            if (aluno.Excluir(codAlunoClicado) == true)
            {
                MessageBox.Show("O aluno foi excluído com sucesso!");
                dgvCadAluno.DataSource = aluno.RetAlunos();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvCadAluno.DataSource = aluno.RetAlunosNome(txtBucsar.Text);
        }
    }
}
