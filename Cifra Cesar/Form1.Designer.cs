namespace WindowsFormsApplication1
{
    partial class frmCifra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCifra));
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.txt_mensagem = new System.Windows.Forms.TextBox();
            this.lbl_introduzir_passo = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_encriptar = new System.Windows.Forms.Button();
            this.btn_desencriptar = new System.Windows.Forms.Button();
            this.numeric_passo = new System.Windows.Forms.NumericUpDown();
            this.lbl_teste = new System.Windows.Forms.Label();
            this.lbl_passo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_passo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Location = new System.Drawing.Point(20, 11);
            this.lbl_mensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(114, 13);
            this.lbl_mensagem.TabIndex = 0;
            this.lbl_mensagem.Text = "Introduzir a Mensagem";
            // 
            // txt_mensagem
            // 
            this.txt_mensagem.Location = new System.Drawing.Point(22, 47);
            this.txt_mensagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_mensagem.Multiline = true;
            this.txt_mensagem.Name = "txt_mensagem";
            this.txt_mensagem.Size = new System.Drawing.Size(304, 84);
            this.txt_mensagem.TabIndex = 1;
            // 
            // lbl_introduzir_passo
            // 
            this.lbl_introduzir_passo.AutoSize = true;
            this.lbl_introduzir_passo.Location = new System.Drawing.Point(20, 140);
            this.lbl_introduzir_passo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_introduzir_passo.Name = "lbl_introduzir_passo";
            this.lbl_introduzir_passo.Size = new System.Drawing.Size(92, 13);
            this.lbl_introduzir_passo.TabIndex = 2;
            this.lbl_introduzir_passo.Text = "Introduza o Passo";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(20, 323);
            this.txt_resultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(306, 82);
            this.txt_resultado.TabIndex = 4;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(20, 287);
            this.lbl_resultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 5;
            this.lbl_resultado.Text = "Resultado";
            // 
            // btn_encriptar
            // 
            this.btn_encriptar.Location = new System.Drawing.Point(22, 219);
            this.btn_encriptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_encriptar.Name = "btn_encriptar";
            this.btn_encriptar.Size = new System.Drawing.Size(89, 28);
            this.btn_encriptar.TabIndex = 6;
            this.btn_encriptar.Text = "Encriptar";
            this.btn_encriptar.UseVisualStyleBackColor = true;
            this.btn_encriptar.Click += new System.EventHandler(this.btn_encriptar_Click);
            // 
            // btn_desencriptar
            // 
            this.btn_desencriptar.Location = new System.Drawing.Point(145, 219);
            this.btn_desencriptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_desencriptar.Name = "btn_desencriptar";
            this.btn_desencriptar.Size = new System.Drawing.Size(89, 28);
            this.btn_desencriptar.TabIndex = 7;
            this.btn_desencriptar.Text = "Desencriptar";
            this.btn_desencriptar.UseVisualStyleBackColor = true;
            this.btn_desencriptar.Click += new System.EventHandler(this.btn_desencriptar_Click);
            // 
            // numeric_passo
            // 
            this.numeric_passo.Location = new System.Drawing.Point(22, 176);
            this.numeric_passo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeric_passo.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numeric_passo.Name = "numeric_passo";
            this.numeric_passo.Size = new System.Drawing.Size(90, 20);
            this.numeric_passo.TabIndex = 8;
            // 
            // lbl_teste
            // 
            this.lbl_teste.AutoSize = true;
            this.lbl_teste.Location = new System.Drawing.Point(399, 326);
            this.lbl_teste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_teste.Name = "lbl_teste";
            this.lbl_teste.Size = new System.Drawing.Size(34, 13);
            this.lbl_teste.TabIndex = 9;
            this.lbl_teste.Text = "Teste";
            this.lbl_teste.Visible = false;
            // 
            // lbl_passo
            // 
            this.lbl_passo.AutoSize = true;
            this.lbl_passo.Location = new System.Drawing.Point(402, 353);
            this.lbl_passo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_passo.Name = "lbl_passo";
            this.lbl_passo.Size = new System.Drawing.Size(20, 13);
            this.lbl_passo.TabIndex = 10;
            this.lbl_passo.Text = "P=";
            this.lbl_passo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(402, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 84);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(402, 246);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // frmCifra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 460);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_passo);
            this.Controls.Add(this.lbl_teste);
            this.Controls.Add(this.numeric_passo);
            this.Controls.Add(this.btn_desencriptar);
            this.Controls.Add(this.btn_encriptar);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.lbl_introduzir_passo);
            this.Controls.Add(this.txt_mensagem);
            this.Controls.Add(this.lbl_mensagem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCifra";
            this.Text = "Cifra de Caesar";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_passo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mensagem;
        private System.Windows.Forms.TextBox txt_mensagem;
        private System.Windows.Forms.Label lbl_introduzir_passo;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_encriptar;
        private System.Windows.Forms.Button btn_desencriptar;
        private System.Windows.Forms.NumericUpDown numeric_passo;
        private System.Windows.Forms.Label lbl_teste;
        private System.Windows.Forms.Label lbl_passo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

