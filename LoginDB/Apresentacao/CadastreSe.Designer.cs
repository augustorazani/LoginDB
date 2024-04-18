namespace LoginDB.Apresentacao
{
    partial class CadastreSe
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.lbCrieUser = new System.Windows.Forms.Label();
            this.checkBoxSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Purple;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(30, 203);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(150, 35);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUser.Location = new System.Drawing.Point(78, 53);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(55, 17);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "Usuário:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbSenha.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSenha.Location = new System.Drawing.Point(83, 94);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(45, 17);
            this.lbSenha.TabIndex = 9;
            this.lbSenha.Text = "Senha:";
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbConfirmarSenha.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbConfirmarSenha.Location = new System.Drawing.Point(53, 137);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(105, 17);
            this.lbConfirmarSenha.TabIndex = 10;
            this.lbConfirmarSenha.Text = "Confirmar senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(30, 73);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(150, 20);
            this.txtLogin.TabIndex = 11;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(30, 114);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(150, 20);
            this.txtSenha.TabIndex = 12;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfSenha.Location = new System.Drawing.Point(30, 157);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '•';
            this.txtConfSenha.Size = new System.Drawing.Size(150, 20);
            this.txtConfSenha.TabIndex = 13;
            // 
            // lbCrieUser
            // 
            this.lbCrieUser.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrieUser.ForeColor = System.Drawing.Color.Purple;
            this.lbCrieUser.Location = new System.Drawing.Point(20, 20);
            this.lbCrieUser.Name = "lbCrieUser";
            this.lbCrieUser.Size = new System.Drawing.Size(170, 30);
            this.lbCrieUser.TabIndex = 14;
            this.lbCrieUser.Text = "Crie seu usuário";
            this.lbCrieUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxSenha
            // 
            this.checkBoxSenha.AutoSize = true;
            this.checkBoxSenha.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSenha.Location = new System.Drawing.Point(58, 181);
            this.checkBoxSenha.Name = "checkBoxSenha";
            this.checkBoxSenha.Size = new System.Drawing.Size(95, 19);
            this.checkBoxSenha.TabIndex = 15;
            this.checkBoxSenha.Text = "Mostrar senha";
            this.checkBoxSenha.UseVisualStyleBackColor = true;
            this.checkBoxSenha.CheckedChanged += new System.EventHandler(this.checkBoxSenha_CheckedChanged);
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 291);
            this.Controls.Add(this.checkBoxSenha);
            this.Controls.Add(this.lbCrieUser);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lbConfirmarSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastreSe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastre-se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label lbCrieUser;
        private System.Windows.Forms.CheckBox checkBoxSenha;
    }
}