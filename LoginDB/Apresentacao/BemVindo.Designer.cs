namespace LoginDB.Apresentacao
{
    partial class BemVindo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BemVindo));
            this.lbBemVindo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBemVindo
            // 
            this.lbBemVindo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBemVindo.BackColor = System.Drawing.SystemColors.Control;
            this.lbBemVindo.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBemVindo.ForeColor = System.Drawing.Color.Purple;
            this.lbBemVindo.Location = new System.Drawing.Point(12, 62);
            this.lbBemVindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBemVindo.Name = "lbBemVindo";
            this.lbBemVindo.Size = new System.Drawing.Size(383, 92);
            this.lbBemVindo.TabIndex = 0;
            this.lbBemVindo.Text = "Bem Vindo!";
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 233);
            this.Controls.Add(this.lbBemVindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BemVindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BemVindo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBemVindo;
    }
}