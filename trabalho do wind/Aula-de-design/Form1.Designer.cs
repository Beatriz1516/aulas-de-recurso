namespace Aula_de_design
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
            this.Nome = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.Label();
            this.Endereço = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AccessibleName = "";
            this.Nome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nome.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(12, 17);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(132, 30);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sobrenome
            // 
            this.Sobrenome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sobrenome.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sobrenome.Location = new System.Drawing.Point(12, 82);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(132, 30);
            this.Sobrenome.TabIndex = 1;
            this.Sobrenome.Text = "Sobrenome";
            this.Sobrenome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Sobrenome.Click += new System.EventHandler(this.label2_Click);
            // 
            // Endereço
            // 
            this.Endereço.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Endereço.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereço.Location = new System.Drawing.Point(12, 218);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(132, 30);
            this.Endereço.TabIndex = 3;
            this.Endereço.Text = "Endereço";
            this.Endereço.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Telefone
            // 
            this.Telefone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Telefone.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(12, 153);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(132, 30);
            this.Telefone.TabIndex = 2;
            this.Telefone.Text = "Telefone";
            this.Telefone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 277);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 30);
            this.label.TabIndex = 4;
            this.label.Text = "Cidade";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNome.Location = new System.Drawing.Point(166, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 22);
            this.txtNome.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSobrenome.Location = new System.Drawing.Point(166, 90);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(400, 22);
            this.txtSobrenome.TabIndex = 6;
            // 
            // txtEndereço
            // 
            this.txtEndereço.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEndereço.Location = new System.Drawing.Point(166, 226);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(400, 22);
            this.txtEndereço.TabIndex = 8;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTelefone.Location = new System.Drawing.Point(166, 161);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(400, 22);
            this.txtTelefone.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCidade.Location = new System.Drawing.Point(166, 285);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(400, 22);
            this.txtCidade.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(166, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Sobrenome;
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button button1;
    }
}

