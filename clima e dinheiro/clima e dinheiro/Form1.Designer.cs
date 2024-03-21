namespace clima_e_dinheiro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.lblclima = new System.Windows.Forms.Label();
            this.lbldinheiro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbclima = new System.Windows.Forms.ComboBox();
            this.tbxdinheiro = new System.Windows.Forms.TextBox();
            this.pbclima = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbclima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.Location = new System.Drawing.Point(583, 333);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(118, 36);
            this.btnconfirmar.TabIndex = 0;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // lblclima
            // 
            this.lblclima.AutoSize = true;
            this.lblclima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclima.Location = new System.Drawing.Point(467, 171);
            this.lblclima.Name = "lblclima";
            this.lblclima.Size = new System.Drawing.Size(68, 25);
            this.lblclima.TabIndex = 3;
            this.lblclima.Text = "Clima:";
            // 
            // lbldinheiro
            // 
            this.lbldinheiro.AutoSize = true;
            this.lbldinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldinheiro.Location = new System.Drawing.Point(467, 233);
            this.lbldinheiro.Name = "lbldinheiro";
            this.lbldinheiro.Size = new System.Drawing.Size(90, 25);
            this.lbldinheiro.TabIndex = 4;
            this.lbldinheiro.Text = "Dinheiro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerador de Rolês";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbclima
            // 
            this.cbclima.FormattingEnabled = true;
            this.cbclima.Items.AddRange(new object[] {
            "sol",
            "chuva"});
            this.cbclima.Location = new System.Drawing.Point(583, 171);
            this.cbclima.Name = "cbclima";
            this.cbclima.Size = new System.Drawing.Size(121, 21);
            this.cbclima.TabIndex = 8;
            // 
            // tbxdinheiro
            // 
            this.tbxdinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxdinheiro.Location = new System.Drawing.Point(583, 233);
            this.tbxdinheiro.Name = "tbxdinheiro";
            this.tbxdinheiro.Size = new System.Drawing.Size(121, 21);
            this.tbxdinheiro.TabIndex = 9;
            // 
            // pbclima
            // 
            this.pbclima.Location = new System.Drawing.Point(878, 134);
            this.pbclima.Name = "pbclima";
            this.pbclima.Size = new System.Drawing.Size(343, 235);
            this.pbclima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclima.TabIndex = 10;
            this.pbclima.TabStop = false;
            this.pbclima.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "O melhor sugestor de passeios do Brasil";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 209);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1283, 589);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbclima);
            this.Controls.Add(this.tbxdinheiro);
            this.Controls.Add(this.cbclima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldinheiro);
            this.Controls.Add(this.lblclima);
            this.Controls.Add(this.btnconfirmar);
            this.Name = "Form1";
            this.Text = "Rolês";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbclima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label lblclima;
        private System.Windows.Forms.Label lbldinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbclima;
        private System.Windows.Forms.TextBox tbxdinheiro;
        private System.Windows.Forms.PictureBox pbclima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

