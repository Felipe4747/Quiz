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
        int cont = 10;
        int contbtn = 1;
        string respCerta;
        int combo = 0;
        int contperg = 0;
        List<string> perguntas;
        List<string> respostas;
        
        
        public Main()
        {
            InitializeComponent();

            perguntas = new List<string>();
            respostas = new List<string>();
            
            _banco.DBNome = "quiz";
            _banco.Conectar();
            DataSet perguntasDataset = _banco.Buscar("select * from perguntas;");
            for (int i = 0; i < perguntasDataset.Tables["tbl_resultado"].Rows.Count; i++)
            {
                perguntas.Add(perguntasDataset.Tables["tbl_resultado"].Rows[i]["enunciadoperg"].ToString());
            }
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            if (contperg <= 10)
            {
                cont--;
                time.Text = cont + "s";
                if (cont == 0)
                {
                    combo = 0;
                    combotext.Text = combo.ToString() + "x";
                    MudaPergunta();
                }
            }
            else
            {
                this.Close();
            }

        }

        #region Métodos
        public void MudaPergunta()
        {
            contperg++;
            cont = 10;
            tempo.Enabled = true;

            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;

            
            Random rdn = new Random();
            int num;
            num = rdn.Next(0, perguntas.Count-1);
            num++;
            pergunta.Text = Convert.ToString(perguntas[num]);

            DataSet respDataset = _banco.Buscar("select * from respostas where id_perg = " + (num + 1));
            
            for (int i = 0; i < respDataset.Tables["tbl_resultado"].Rows.Count; i++)
            {
                respostas.Add(respDataset.Tables["tbl_resultado"].Rows[i]["enunciadoresp"].ToString());
            }

            DataSet respCertaDataset = _banco.Buscar("select * from respostas where id_perg = " + (num + 1) + " and correta = true;");
            respCerta = respCertaDataset.Tables["tbl_resultado"].Rows[0]["enunciadoresp"].ToString();

            button1.Text = respostas[0];
            button2.Text = respostas[1];
            button3.Text = respostas[2];
            button4.Text = respostas[3];

            for (int i = 0; i < respDataset.Tables["tbl_resultado"].Rows.Count; i++)
            {
                respostas.Remove(respostas[0]);
            }
            perguntas.Remove(perguntas[num]);

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        public void PerguntaCerta(Button btn)
        {
            btn.BackColor = Color.Green;
            combo++;
            combotext.Text = combo.ToString() + "x";
            pontos += cont*combo;
            pont.Text = pontos.ToString();
            tempobtn.Enabled = true;
        }

        public void PerguntaErrada(Button btn)
        {
            btn.BackColor = Color.Red;
            combo = 0;
            combotext.Text = combo.ToString() + "x";
            tempobtn.Enabled = true;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            Button btn = (Button)sender;
            tempo.Enabled = false;
            if (contperg <= 10)
            {
                if (btn.Text == respCerta)
                {
                    pontos++;
                    PerguntaCerta(btn);
                }
                else
                {
                    PerguntaErrada(btn);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void tempobtn_Tick(object sender, EventArgs e)
        {
            contbtn--;
            if (contbtn == 0)
            {
                BackColor = Color.WhiteSmoke;
                tempobtn.Enabled = false;
                contbtn = 1;
                MudaPergunta();
            }
        }
    }
}