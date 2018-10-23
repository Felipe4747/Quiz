﻿using System;
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
        int cont;
        int contbtn = 1;
        int contresp;
        int combo = 0;
        int contperg = 0;
        public int num;

        List<string> perguntas;
        List<string> respostas;
        List<bool> respcerta;
        
        
        public Main()
        {
            InitializeComponent();

            perguntas = new List<string>();
            respostas = new List<string>();
            respcerta = new List<bool>();

            DesativarAtivar(false);
            _banco.DBNome = "quiz";
            _banco.Conectar();
            DataSet perguntasDataset = _banco.Buscar("select * from perguntas;");
            for (int i = 0; i < perguntasDataset.Tables["tbl_resultado"].Rows.Count; i++)
            {
                perguntas.Add(perguntasDataset.Tables["tbl_resultado"].Rows[i]["enunciadoperg"].ToString());
            }
            DataSet respostasDataset = _banco.Buscar("select * from respostas;");
            for (int i = 0; i < respostasDataset.Tables["tbl_resultado"].Rows.Count; i++)
            {
                respostas.Add(respostasDataset.Tables["tbl_resultado"].Rows[i]["enunciadoresp"].ToString());
                respcerta.Add(Convert.ToBoolean(respostasDataset.Tables["tbl_resultado"].Rows[i]["correta"]));
            }
            MudaPergunta();
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

            DataSet respostasDataset = new DataSet();
            Random rdn = new Random();
            num = rdn.Next(0, perguntas.Count - 1);

            pergunta.Text = Convert.ToString(perguntas[num]);
            button1.Text = respostas[4 * num];
            button2.Text = respostas[4 * num + 1];
            button3.Text = respostas[4 * num + 2];
            button4.Text = respostas[4 * num + 3];

            DesativarAtivar(true);
            /*
            Console.WriteLine(perguntas[num] + " " + respostas[4*num] + " " + respcerta[4*num]);
            Console.WriteLine(perguntas[num] + " " + respostas[4 * num+1] + " " + respcerta[4 * num + 1]);
            Console.WriteLine(perguntas[num] + " " + respostas[4 * num + 2] + " " + respcerta[4 * num + 2]);
            Console.WriteLine(perguntas[num] + " " + respostas[4 * num + 3] + " " + respcerta[4 * num + 3]);
            */
        }

        public void DesativarAtivar(bool Ativar)
        {
            if (Ativar)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        public void RemoveTudo()
        {
            for(int i = 0; i < 4; i++)
            {
                respcerta.Remove(respcerta[4 * num]);
                respostas.Remove(respostas[4 * num]);
            }
            perguntas.Remove(perguntas[num]);
        }

        public void ButtonClick(Button btn, int contresp)
        {
            DesativarAtivar(false);
            tempo.Enabled = false;
            if (contperg <= 10)
            {
                if (respcerta[4 * num + contresp] == true)
                {
                    pontos++;
                    CertaErrada(true, btn);
                    RemoveTudo();
                }
                else
                {
                    CertaErrada(false, btn);
                    RemoveTudo();
                }
            }
            else
            {
                MessageBox.Show("Acabaste");
            }
        }

        public void CertaErrada(bool certa, Button btn)
        {
            if (certa)
            {
                btn.BackColor = Color.Green;
                combo++;
                combotext.Text = combo.ToString() + "x";
                pontos += cont * combo;
                pont.Text = pontos.ToString();
                tempobtn.Enabled = true;
            }
            else
            {
                btn.BackColor = Color.Red;
                combo = 0;
                combotext.Text = combo.ToString() + "x";
                tempobtn.Enabled = true;
            }
        }
        #endregion

        #region Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            contresp = 0;
            ButtonClick(btn, contresp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            contresp = 1;
            ButtonClick(btn, contresp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            contresp = 2;
            ButtonClick(btn, contresp);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            contresp = 3;
            ButtonClick(btn, contresp);
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
                MessageBox.Show("Acabaste");
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
        #endregion
    }
}