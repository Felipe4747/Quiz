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
            DataSet posicoesDataset = _banco.Buscar("select nome, pontuacao from Usuario order by pontuacao desc limit 10;");
            for (int i = 0; i < posicoesDataset.Tables["tbl_resultado"].Rows.Count; i++)
            {
                posicoes.Add(posicoesDataset.Tables["tbl_resultado"].Rows[i]["enunciadoperg"].ToString());
            }
            label1.Text = posicoes[0];
            label2.Text = posicoes[1];
            label3.Text = posicoes[2];
            label4.Text = posicoes[3];
            label5.Text = posicoes[4];
            label6.Text = posicoes[5];
            label7.Text = posicoes[6];
            label8.Text = posicoes[7];
            label9.Text = posicoes[8];
            label10.Text = posicoes[9];
            sua_posicao.Text = "" + _banco.Buscar("select nome, pontuacao from Usuario order by id desc limit 1;").ToString();
        }

        private void jogar_novamente_Click(object sender, EventArgs e)
        {            
        }
    }
}
