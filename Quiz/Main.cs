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
        int cont = 20;
        string respCerta;
        List<string> perguntas;
        DataSet respostasDataset;
        
        public Main()
        {
            InitializeComponent();

            perguntas = new List<string>();
            
            _banco.DBNome = "quiz";
            _banco.Conectar();
            DataSet perguntasDataset = _banco.Buscar("select * from perguntas;");
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
            cont = 20;
            Random rdn = new Random();
            int num;
            num = rdn.Next(0, perguntas.Count-1);
            num++;
            pergunta.Text = Convert.ToString(perguntas[num]);


            DataSet respDataset = _banco.Buscar("select * from perguntas");
           
            respCerta = respDataset.Tables["tbl_resultado"].Rows[0]["resp_certa"].ToString();
            respostasDataset = _banco.Buscar("select * from perguntas where id = " + num + ";");

            label2.Text = "select* from perguntas where id = " + num + "; ";
            
            button1.Text = respostasDataset.Tables["tbl_resultado"].Rows[0]["resp1"].ToString();
            respostasDataset = _banco.Buscar("select * from perguntas where id = " + num + ";");

            button2.Text = respostasDataset.Tables["tbl_resultado"].Rows[0]["resp2"].ToString();
            respostasDataset = _banco.Buscar("select * from perguntas where id = " + num + ";");

            button3.Text = respostasDataset.Tables["tbl_resultado"].Rows[0]["resp3"].ToString();
            respostasDataset = _banco.Buscar("select * from perguntas where id = " + num + ";");

            button4.Text = respostasDataset.Tables["tbl_resultado"].Rows[0]["resp4"].ToString();
            respostasDataset = _banco.Buscar("select * from perguntas where id = " + num + ";");
            
            perguntas.Remove(perguntas[num]);
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