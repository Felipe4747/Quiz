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
        List<DataSet> perguntas = new List<DataSet>();
        public Main()
        {
            InitializeComponent();
            _banco.DBNome = "quiz";
            _banco.Conectar();
            for (int i = 1; i < 31; i++)
            {
                perguntas.Add(_banco.Buscar("select pergunta from perguntas where id = " + i.ToString() + ";"));
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
            num = rdn.Next(1, 30);
            pergunta.Text = Convert.ToString(perguntas[num]);
            perguntas.Remove(perguntas[num]);
        }
        #endregion
    }
}