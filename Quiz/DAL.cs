using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Quiz
{
    class DAL
    {
        #region Atributos
        private MySqlConnection _conexao;
        private MySqlCommand _comandoDB;
        private MySqlDataAdapter _adaptador;
        private DataSet _dados;
        #endregion

        #region Getters e Setters 
        public string Host { get; set; } = "localhost";
        public string DBNome { get; set; } = "quiz";
        public string Usuario { get; set; } = "root";
        public string Senha { get; set; } = "";
        public string Pergunta { get; set; } = "";
        #endregion

        #region Construtor
        public DAL() { }
        #endregion

        #region Métodos
        public void Conectar()
        {
            string strConexao = "Server=" + Host;
            strConexao += ";Database=" + DBNome;
            strConexao += ";Uid=" + Usuario;
            strConexao += ";Pwd=" + Senha;
            strConexao += ";SSL Mode=None";
            try
            {      
                _conexao = new MySqlConnection(strConexao);
                if (_conexao.State.Equals(ConnectionState.Closed))
                {
                    _conexao.Open();
                }

            }
            catch (MySqlException erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                _conexao.Dispose();
            }
        }
 
       public void Inserir(string strSQL)
        {
            try
            {
                if (_conexao.State.Equals(ConnectionState.Closed))
                {
                    _conexao.Open();
                }

                _comandoDB = _conexao.CreateCommand();
                _comandoDB.CommandText = strSQL;

                if (_comandoDB.ExecuteNonQuery() != 1)
                {
                    throw new Exception("Falha ao inserir");
                }
            }
            catch (MySqlException erro)
            {
                throw new Exception("Erro ao inserir: " + erro.Message);
            }
        }
        public DataSet Buscar(string strSQL)
        {
            _dados = new DataSet();
            _adaptador = new MySqlDataAdapter(strSQL, _conexao);
            _adaptador.Fill(_dados, "tbl_resultado");
            return _dados;
        }
        public void Atualizar() { }
        public void Excluir() { }
        #endregion
    }
}