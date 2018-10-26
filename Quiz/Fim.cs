using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Fim : Form
    {
        RegistroUsuario registroUsuario = new RegistroUsuario();
        private DAL _banco = new DAL();
        public Fim()
        {
            InitializeComponent();
            _banco.DBNome = "quiz";
            _banco.Conectar();
            List<string> posicoes;
            List<int> rank;
            posicoes = new List<string>();
            rank = new List<int>();

            DataSet posicoesDataset = _banco.Buscar("select id, pontuacao, nome from Usuario order by pontuacao desc;");
            for (int i = 0; i < 10 && i < posicoesDataset.Tables["tbl_resultado"].Rows.Count; i++)
            {
                posicoes.Add(posicoesDataset.Tables["tbl_resultado"].Rows[i]["pontuacao"].ToString());
                posicoes[i] += " - " + posicoesDataset.Tables["tbl_resultado"].Rows[i]["nome"].ToString();
                listBox1.Items.Add((i + 1) + "° - " + posicoes[i]);
            }         

            DataSet usuarioDataset = _banco.Buscar("select id, pontuacao, nome from Usuario order by id desc limit 1;");
            int pontuacao = Convert.ToInt32(usuarioDataset.Tables["tbl_resultado"].Rows[0]["pontuacao"]);
            int maior_pontuacao = Convert.ToInt32(usuarioDataset.Tables["tbl_resultado"].Rows[0]["pontuacao"]);
            int id_usuario = Convert.ToInt32(usuarioDataset.Tables["tbl_resultado"].Rows[0]["id"]);

            for (int i = 0; i < posicoesDataset.Tables["tbl_resultado"].Rows.Count; i++)
            {
                rank.Add(Convert.ToInt32(posicoesDataset.Tables["tbl_resultado"].Rows[i]["id"]));
                /*if (Convert.ToInt32(posicoesDataset.Tables["tbl_resultado"].Rows[id_usuario]["id"]) == rank[i])
                {
                    listBox1.Items.Add("Sua Posição: " + (i + 1) + "º - " + usuarioDataset.Tables["tbl_resultado"].Rows[0]["pontuacao"].ToString() + " - " + usuarioDataset.Tables["tbl_resultado"].Rows[0]["nome"].ToString());
                }*/
            }

            if (pontuacao >= maior_pontuacao)
            {
                pictureBox1.Visible = true;
            }
        }

        private void jogar_novamente_Click(object sender, EventArgs e)
        {
            this.Close();
            registroUsuario.Show();
        }
    }
}