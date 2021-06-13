namespace Corrida1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numCachorro = new System.Windows.Forms.NumericUpDown();
            this.btnCorram = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.btnAposta = new System.Windows.Forms.Button();
            this.lblApostaNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblApostaAlfredo = new System.Windows.Forms.Label();
            this.lblApostaBeto = new System.Windows.Forms.Label();
            this.lblApostaJoao = new System.Windows.Forms.Label();
            this.rbtAlfredo = new System.Windows.Forms.RadioButton();
            this.rbtBeto = new System.Windows.Forms.RadioButton();
            this.rbtJoao = new System.Windows.Forms.RadioButton();
            this.lblApostaMinima = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.picPista = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCachorro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numCachorro);
            this.groupBox1.Controls.Add(this.btnCorram);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numValor);
            this.groupBox1.Controls.Add(this.btnAposta);
            this.groupBox1.Controls.Add(this.lblApostaNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rbtAlfredo);
            this.groupBox1.Controls.Add(this.rbtBeto);
            this.groupBox1.Controls.Add(this.rbtJoao);
            this.groupBox1.Controls.Add(this.lblApostaMinima);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balcão de Apostas";
            // 
            // numCachorro
            // 
            this.numCachorro.Location = new System.Drawing.Point(361, 180);
            this.numCachorro.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numCachorro.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCachorro.Name = "numCachorro";
            this.numCachorro.Size = new System.Drawing.Size(52, 20);
            this.numCachorro.TabIndex = 11;
            this.numCachorro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCorram
            // 
            this.btnCorram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorram.Location = new System.Drawing.Point(453, 173);
            this.btnCorram.Name = "btnCorram";
            this.btnCorram.Size = new System.Drawing.Size(107, 32);
            this.btnCorram.TabIndex = 10;
            this.btnCorram.Text = "Corram !";
            this.btnCorram.UseVisualStyleBackColor = true;
            this.btnCorram.Click += new System.EventHandler(this.btnCorram_Click_1);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(256, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "reais no cão número";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numValor
            // 
            this.numValor.Location = new System.Drawing.Point(185, 181);
            this.numValor.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numValor.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(65, 20);
            this.numValor.TabIndex = 7;
            this.numValor.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnAposta
            // 
            this.btnAposta.Location = new System.Drawing.Point(104, 178);
            this.btnAposta.Name = "btnAposta";
            this.btnAposta.Size = new System.Drawing.Size(75, 23);
            this.btnAposta.TabIndex = 6;
            this.btnAposta.Text = "Aposta";
            this.btnAposta.UseVisualStyleBackColor = true;
            this.btnAposta.Click += new System.EventHandler(this.btnAposta_Click);
            // 
            // lblApostaNome
            // 
            this.lblApostaNome.Location = new System.Drawing.Point(12, 178);
            this.lblApostaNome.Name = "lblApostaNome";
            this.lblApostaNome.Size = new System.Drawing.Size(86, 23);
            this.lblApostaNome.TabIndex = 5;
            this.lblApostaNome.Text = "---";
            this.lblApostaNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          //  this.lblApostaNome.Click += new System.EventHandler(this.lblApostaNome_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 1);
            this.label2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblApostaAlfredo);
            this.groupBox2.Controls.Add(this.lblApostaBeto);
            this.groupBox2.Controls.Add(this.lblApostaJoao);
            this.groupBox2.Location = new System.Drawing.Point(273, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 127);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apostas";
            // 
            // lblApostaAlfredo
            // 
            this.lblApostaAlfredo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApostaAlfredo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostaAlfredo.Location = new System.Drawing.Point(6, 94);
            this.lblApostaAlfredo.Name = "lblApostaAlfredo";
            this.lblApostaAlfredo.Size = new System.Drawing.Size(275, 22);
            this.lblApostaAlfredo.TabIndex = 3;
            this.lblApostaAlfredo.Text = "Aposta de Alfredo";
            this.lblApostaAlfredo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
           

            // 
            // lblApostaBeto
            // 
            this.lblApostaBeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApostaBeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostaBeto.Location = new System.Drawing.Point(6, 63);
            this.lblApostaBeto.Name = "lblApostaBeto";
            this.lblApostaBeto.Size = new System.Drawing.Size(275, 22);
            this.lblApostaBeto.TabIndex = 2;
            this.lblApostaBeto.Text = "Aposta de Beto";
            this.lblApostaBeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApostaJoao
            // 
            this.lblApostaJoao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApostaJoao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostaJoao.Location = new System.Drawing.Point(6, 30);
            this.lblApostaJoao.Name = "lblApostaJoao";
            this.lblApostaJoao.Size = new System.Drawing.Size(275, 22);
            this.lblApostaJoao.TabIndex = 1;
            this.lblApostaJoao.Text = "Aposta de João";
            this.lblApostaJoao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtAlfredo
            // 
            this.rbtAlfredo.AutoSize = true;
            this.rbtAlfredo.Location = new System.Drawing.Point(6, 124);
            this.rbtAlfredo.Name = "rbtAlfredo";
            this.rbtAlfredo.Size = new System.Drawing.Size(58, 17);
            this.rbtAlfredo.TabIndex = 2;
            this.rbtAlfredo.TabStop = true;
            this.rbtAlfredo.Text = "Alfredo";
            this.rbtAlfredo.UseVisualStyleBackColor = true;
            this.rbtAlfredo.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // rbtBeto
            // 
            this.rbtBeto.AutoSize = true;
            this.rbtBeto.Location = new System.Drawing.Point(6, 93);
            this.rbtBeto.Name = "rbtBeto";
            this.rbtBeto.Size = new System.Drawing.Size(47, 17);
            this.rbtBeto.TabIndex = 2;
            this.rbtBeto.TabStop = true;
            this.rbtBeto.Text = "Beto";
            this.rbtBeto.UseVisualStyleBackColor = true;
            this.rbtBeto.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // rbtJoao
            // 
            this.rbtJoao.AutoSize = true;
            this.rbtJoao.Location = new System.Drawing.Point(6, 60);
            this.rbtJoao.Name = "rbtJoao";
            this.rbtJoao.Size = new System.Drawing.Size(48, 17);
            this.rbtJoao.TabIndex = 2;
            this.rbtJoao.TabStop = true;
            this.rbtJoao.Text = "João";
            this.rbtJoao.UseVisualStyleBackColor = true;
            this.rbtJoao.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // lblApostaMinima
            // 
            this.lblApostaMinima.AutoSize = true;
            this.lblApostaMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostaMinima.Location = new System.Drawing.Point(119, 27);
            this.lblApostaMinima.Name = "lblApostaMinima";
            this.lblApostaMinima.Size = new System.Drawing.Size(14, 13);
            this.lblApostaMinima.TabIndex = 1;
            this.lblApostaMinima.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aposta mínima: ";
            // 
            // pic4
            // 
            this.pic4.Image = global::Corrida1.Properties.Resources.dog1;
            this.pic4.Location = new System.Drawing.Point(0, 155);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(113, 30);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 5;
            this.pic4.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::Corrida1.Properties.Resources.dog1;
            this.pic3.Location = new System.Drawing.Point(0, 103);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(113, 30);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 4;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::Corrida1.Properties.Resources.dog1;
            this.pic2.Location = new System.Drawing.Point(0, 51);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(113, 30);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 3;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::Corrida1.Properties.Resources.dog;
            this.pic1.Location = new System.Drawing.Point(0, 4);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(113, 30);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            // 
            // picPista
            // 
            this.picPista.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPista.Image = global::Corrida1.Properties.Resources.racetrack;
            this.picPista.Location = new System.Drawing.Point(0, 0);
            this.picPista.Name = "picPista";
            this.picPista.Size = new System.Drawing.Size(590, 196);
            this.picPista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPista.TabIndex = 0;
            this.picPista.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 424);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picPista);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Apostas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCachorro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtJoao;
        private System.Windows.Forms.Label lblApostaMinima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtAlfredo;
        private System.Windows.Forms.RadioButton rbtBeto;
        private System.Windows.Forms.Button btnCorram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Button btnAposta;
        private System.Windows.Forms.Label lblApostaNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblApostaAlfredo;
        private System.Windows.Forms.Label lblApostaBeto;
        private System.Windows.Forms.Label lblApostaJoao;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.NumericUpDown numCachorro;
    }
}

