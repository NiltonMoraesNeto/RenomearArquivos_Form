namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAntigo = new System.Windows.Forms.TextBox();
            this.txtNovo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRenomear = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho do Arquivo:";
            // 
            // txtCaminho
            // 
            this.txtCaminho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaminho.Location = new System.Drawing.Point(185, 45);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(676, 13);
            this.txtCaminho.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Antigo:";
            // 
            // txtAntigo
            // 
            this.txtAntigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAntigo.Location = new System.Drawing.Point(185, 82);
            this.txtAntigo.Name = "txtAntigo";
            this.txtAntigo.Size = new System.Drawing.Size(676, 13);
            this.txtAntigo.TabIndex = 3;
            // 
            // txtNovo
            // 
            this.txtNovo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNovo.Location = new System.Drawing.Point(185, 120);
            this.txtNovo.Name = "txtNovo";
            this.txtNovo.Size = new System.Drawing.Size(676, 13);
            this.txtNovo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome Novo:";
            // 
            // btnRenomear
            // 
            this.btnRenomear.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRenomear.FlatAppearance.BorderSize = 0;
            this.btnRenomear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenomear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenomear.ForeColor = System.Drawing.Color.White;
            this.btnRenomear.Location = new System.Drawing.Point(185, 233);
            this.btnRenomear.Name = "btnRenomear";
            this.btnRenomear.Size = new System.Drawing.Size(97, 23);
            this.btnRenomear.TabIndex = 6;
            this.btnRenomear.Text = "RENOMEAR";
            this.btnRenomear.UseVisualStyleBackColor = false;
            this.btnRenomear.Click += new System.EventHandler(this.btnRenomear_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(764, 233);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(879, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecione a Pasta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(994, 268);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRenomear);
            this.Controls.Add(this.txtNovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAntigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(994, 268);
            this.MinimumSize = new System.Drawing.Size(994, 268);
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENOMEAR ARQUIVOS";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAntigo;
        private System.Windows.Forms.TextBox txtNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRenomear;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
    }
}

