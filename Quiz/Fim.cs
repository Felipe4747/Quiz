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
        private DAL _banco = new DAL();
        public Fim()
        {
            InitializeComponent();
            _banco.DBNome = "quiz";
            _banco.Conectar();
            List<string> posicoes;
            posicoes = new List<string>();
            DataSet posicoesDataset = _banco.Buscar("select pontuacao, nome from Usuario order by pontuacao desc limit 10;");
            for (int i = 0; i < posicoesDataset.Tables["tbl_resultado"].Rows.Count; i++)
            {
                posicoes.Add(posicoesDataset.Tables["tbl_resultado"].Rows[i]["pontuacao"].ToString());
                posicoes[i] += " - " + posicoesDataset.Tables["tbl_resultado"].Rows[i]["nome"].ToString();
            }
            for (int i = 0; i < posicoesDataset.Tables["tbl_resultado"].Rows.Count && i < 11; i++)
            {
                listBox1.Items.Add((i+1) + "° - " + posicoes[i]);
            }         
            listBox1.Items.Add("º - " + _banco.Buscar("select pontuacao, nome from Usuario order by id desc limit 1;").ToString());
            DataSet pontuacaoUsuarioDataset = _banco.Buscar("select pontuacao from Usuario order by id desc limit 1;");
            int pontuacao = Convert.ToInt32(pontuacaoUsuarioDataset.Tables["tbl_resultado"].Rows[0]["pontuacao"]);
            DataSet maiorPontuacaoDataset = _banco.Buscar("select pontuacao from Usuario order by pontuacao desc limit 1;");
            int maior_pontuacao = Convert.ToInt32(pontuacaoUsuarioDataset.Tables["tbl_resultado"].Rows[0]["pontuacao"]);
            if (pontuacao >= maior_pontuacao)
            {
                pictureBox1.Visible = true;
            }
        }

        private void jogar_novamente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}