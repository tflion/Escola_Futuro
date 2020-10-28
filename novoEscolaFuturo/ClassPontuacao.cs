using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace novoEscolaFuturo
{
    class ClassPontuacao
    {
        ClassAcessoBD bd = new ClassAcessoBD();

        public int curso_codCurso { get; set; }
        public int aluno_codAluno { get; set; }
        public string descricao { get; set; }
        public int pontuacao { get; set; }

        int codPontuacaoClicada = 0;

        int codAlunoClicado = 0;

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO pontuacao (curso_codCurso,aluno_codAluno,descricao,pontuacao) VALUES ({0},{1},'{2}',{3})", curso_codCurso, aluno_codAluno, descricao, pontuacao));
                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar a pontuação do aluno. ");
            }
        }

        public bool Editar()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE pontuacao SET curso_codCurso = {0}, aluno_codAluno = {1}, descricao = '{2}', pontuacao = {3} WHERE codPontuacao LIKE {4}", curso_codCurso, aluno_codAluno, descricao, pontuacao, codPontuacaoClicada));
                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar a pontuacão!");
            }
        }

        public bool Excluir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM pontuacao WHERE codPontuacao LIKE {0}", codPontuacaoClicada));
                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir a pontuacão!");
            }
        }
    }
}