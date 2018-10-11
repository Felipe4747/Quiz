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
        int contbtn = 2;
        string respCerta;
        List<string> perguntas;
        DataSet respostas_certaDataset;
        DataSet respostasDataSet;
        
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


            DataSet respDataset = _banco.Buscar("select * from respostas where id_perg = " + (num + 1));          
            
            respCerta = respDataset.Tables["tbl_resultado"].Rows[0]["enunciado"].ToString();
            respCerta = respDataset.Tables["tbl_resultado"].Rows[1]["enunciado"].ToString();

            Convert.ToString(correta) = respDataset.Tables["tbl_resultado"].Rows[1]["correta"].ToString();


            respostas_certaDataset = _banco.Buscar("select * from respostas where id_perg = " + (num+1) + " and correta = true;");

            respostasDataSet = _banco.Buscar("select * from respostas where id_perg = " + (num+1));
            Console.WriteLine("respostasDataSet" + respostasDataSet.Tables["tbl_resultado"].Rows[0]["enunciado"].ToString());
            
            /*
            button1.Text = respostasDataset.Tables["tbl_resultado"].Rows[0]["enunciado"].ToString();
            respostasDataset = _banco.Buscar("select * from respostas where id_perg = " + (num + 1) + ";");

            button2.Text = respostasDataset.Tables["tbl_resultado"].Rows[0]["resp2"].ToString();
            respostasDataset = _banco.Buscar("select * from respostas where id_perg = " + (num + 1) + ";");

            button3.Text = respostasDataset.Tables["tbl_resultado"].Rows[0]["resp3"].ToString();
            respostasDataset = _banco.Buscar("select * from respostas where id_perg = " + (num + 1) + ";");

            button4.Text = respostasDataset.Tables["tbl_resultado"].Rows[0]["resp4"].ToString();
            respostasDataset = _banco.Buscar("select * from respostas where id_perg = " + (num + 1) + ";");
            */
            perguntas.Remove(perguntas[num]);
        }

        public void PerguntaCerta(Button btn)
        {
            btn.BackColor = Color.Green;
            tempobtn.Enabled = true;
        }

        public void PerguntaErrada(Button btn)
        {
            btn.BackColor = Color.Red;
            tempobtn.Enabled = true;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (respCerta == btn.Text)
            {
                pontos++;
                PerguntaCerta(btn);
            } 
            PerguntaErrada(btn);
            MudaPergunta();
        }

        private void tempobtn_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            contbtn--;
            if (contbtn == 0)
            {
                BackColor = Color.WhiteSmoke;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                contbtn = 2;
                tempobtn.Enabled = false;
            }
        }
    }
}