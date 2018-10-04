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
        int pontos = 0;
        int cont = 20;
        public Main()
        {
            InitializeComponent();
            
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            cont--;
            time.Text = cont + "s";
            if (cont == 0)
            {
                tempo.Enabled = false;
                MessageBox.Show("O tempo acabou! :( !");
            }
        }
    }
}
