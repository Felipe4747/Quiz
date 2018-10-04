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
        List<string> perguntas = new List<string>();
        public Main()
        {
            InitializeComponent();
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
        }
        #endregion
    }
}