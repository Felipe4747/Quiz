namespace Quiz
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pergunta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pont = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.tempobtn = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.combotext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "(nenhum/a)";
            this.button1.Location = new System.Drawing.Point(42, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(500, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(635, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(500, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(42, 555);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(500, 110);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(635, 555);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(500, 110);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primeira Guerra";
            // 
            // pergunta
            // 
            this.pergunta.AutoSize = true;
            this.pergunta.BackColor = System.Drawing.Color.Transparent;
            this.pergunta.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pergunta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pergunta.Location = new System.Drawing.Point(36, 145);
            this.pergunta.Name = "pergunta";
            this.pergunta.Size = new System.Drawing.Size(115, 33);
            this.pergunta.TabIndex = 5;
            this.pergunta.Text = "Pergunta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(949, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pontuação:";
            // 
            // pont
            // 
            this.pont.AutoSize = true;
            this.pont.BackColor = System.Drawing.Color.Transparent;
            this.pont.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pont.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pont.Location = new System.Drawing.Point(1081, 9);
            this.pont.Name = "pont";
            this.pont.Size = new System.Drawing.Size(30, 33);
            this.pont.TabIndex = 7;
            this.pont.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(987, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tempo:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(1081, 40);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(54, 33);
            this.time.TabIndex = 9;
            this.time.Text = "20s";
            // 
            // tempo
            // 
            this.tempo.Enabled = true;
            this.tempo.Interval = 1000;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // tempobtn
            // 
            this.tempobtn.Interval = 1000;
            this.tempobtn.Tick += new System.EventHandler(this.tempobtn_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(981, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Combo:";
            // 
            // combotext
            // 
            this.combotext.AutoSize = true;
            this.combotext.BackColor = System.Drawing.Color.Transparent;
            this.combotext.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.combotext.Location = new System.Drawing.Point(1081, 71);
            this.combotext.Name = "combotext";
            this.combotext.Size = new System.Drawing.Size(42, 33);
            this.combotext.TabIndex = 11;
            this.combotext.Text = "0x";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1180, 678);
            this.Controls.Add(this.combotext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pergunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pergunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Timer tempobtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label combotext;
    }
}

