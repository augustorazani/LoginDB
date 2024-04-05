using System.Drawing;
using System;
using System.Windows.Forms;
namespace LoginDB
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
            this.txtLogin = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.checkBoxSenha = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lbCriarConta = new System.Windows.Forms.Label();
            this.lkLbCriarConta = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.Purple;
            this.txtLogin.Location = new System.Drawing.Point(28, 45);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(150, 25);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "Tela de Login";
            this.txtLogin.Click += new System.EventHandler(this.txtLogin_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUser.Location = new System.Drawing.Point(28, 101);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(53, 15);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "Usuário:";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Location = new System.Drawing.Point(28, 119);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(150, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(28, 160);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(150, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbSenha.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSenha.Location = new System.Drawing.Point(28, 142);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(42, 15);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha:";
            // 
            // checkBoxSenha
            // 
            this.checkBoxSenha.AutoSize = true;
            this.checkBoxSenha.Location = new System.Drawing.Point(85, 185);
            this.checkBoxSenha.Name = "checkBoxSenha";
            this.checkBoxSenha.Size = new System.Drawing.Size(93, 17);
            this.checkBoxSenha.TabIndex = 5;
            this.checkBoxSenha.Text = "Mostrar senha";
            this.checkBoxSenha.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Purple;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(27, 208);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 30);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Gray;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(27, 241);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(150, 30);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // lbCriarConta
            // 
            this.lbCriarConta.AutoSize = true;
            this.lbCriarConta.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCriarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCriarConta.Location = new System.Drawing.Point(43, 274);
            this.lbCriarConta.Name = "lbCriarConta";
            this.lbCriarConta.Size = new System.Drawing.Size(119, 12);
            this.lbCriarConta.TabIndex = 8;
            this.lbCriarConta.Text = "Não possui uma conta?";
            this.lbCriarConta.Click += new System.EventHandler(this.lbCriarConta_Click);
            // 
            // lkLbCriarConta
            // 
            this.lkLbCriarConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lkLbCriarConta.AutoSize = true;
            this.lkLbCriarConta.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLbCriarConta.LinkColor = System.Drawing.Color.Purple;
            this.lkLbCriarConta.Location = new System.Drawing.Point(61, 295);
            this.lkLbCriarConta.Name = "lkLbCriarConta";
            this.lkLbCriarConta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lkLbCriarConta.Size = new System.Drawing.Size(87, 17);
            this.lkLbCriarConta.TabIndex = 9;
            this.lkLbCriarConta.TabStop = true;
            this.lkLbCriarConta.Text = "Criar Conta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 361);
            this.Controls.Add(this.lkLbCriarConta);
            this.Controls.Add(this.lbCriarConta);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.checkBoxSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Acessar Conta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.CheckBox checkBoxSenha;
        private Button btnLogin;
        private Button btnApagar;
        private Label lbCriarConta;
        private LinkLabel lkLbCriarConta;
    }
}

