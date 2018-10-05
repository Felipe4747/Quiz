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
    public partial class Main : Form
    {
        private DAL _banco = new DAL();
        int pontos = 0;
        int cont = 5;
        string respCerta;
        List<string> perguntas = new List<string>();
        DataSet respostasDataset;
        List<string> respostas = new List<string>();
        
        public Main()
        {
            InitializeComponent();
            respostas.Add("resp1");
            respostas.Add("resp2");
            respostas.Add("resp3");
            respostas.Add("resp4");
            _banco.DBNome = "quiz";
            _banco.Conectar();
            DataSet perguntasDataset = _banco.Buscar("select pergunta from perguntas;");
            for (int i = 0; i < perguntasDataset.Tables["tbl_resultado"].Rows.Count; i++)
            {
                perguntas.Add(perguntasDataset.Tables["tbl_resultado"].Rows[i]["pergunta"].ToString());
            }
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            cont--;
            time.Text = cont + "s";
            if (cont == 0)
            {
                MudaPergunta();
            }
        }

        #region Métodos
        public void MudaPergunta()
        {
            //Fazer as coisas pra mudar a pergunta
            cont = 5;
            Random rdn = new Random();
            int num;
            num = rdn.Next(1, perguntas.Count);
            pergunta.Text = Convert.ToString(perguntas[num]);
            perguntas.Remove(perguntas[num]);
            DataSet respDataset = _banco.Buscar("select resp_certa from perguntas where id = " + num + ";");
            respCerta = respDataset.Tables["tbl_resultado"].Rows[num]["resp_certa"].ToString();
            respostasDataset = _banco.Buscar("select " + respostas[3] + " from perguntas where id = " + num + ";");
            button1.Text = respostasDataset.Tables["tbl_resultado"].Rows[num][respostas[3]].ToString();
            respostasDataset = _banco.Buscar("select " + respostas[4] + " from perguntas where id = " + num + ";");
            button2.Text = respostasDataset.Tables["tbl_resultado"].Rows[num][respostas[4]].ToString();
            respostasDataset = _banco.Buscar("select " + respostas[5] + " from perguntas where id = " + num + ";");
            button3.Text = respostasDataset.Tables["tbl_resultado"].Rows[num][respostas[5]].ToString();
            respostasDataset = _banco.Buscar("select " + respostas[6] + " from perguntas where id = " + num + ";");
            button4.Text = respostasDataset.Tables["tbl_resultado"].Rows[num][respostas[6]].ToString();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (respCerta == "a")
            {
                pontos++;
            }
            MudaPergunta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (respCerta == "b")
            {
                pontos++;
            }
            MudaPergunta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (respCerta == "c")
            {
                pontos++;
            }
            MudaPergunta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (respCerta == "d")
            {
                pontos++;
            }
            MudaPergunta();
        }
    }
}