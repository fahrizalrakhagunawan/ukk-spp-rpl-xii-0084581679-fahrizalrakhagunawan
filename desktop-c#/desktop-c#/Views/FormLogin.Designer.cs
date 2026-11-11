namespace desktop_c_.Views
{
    partial class FormLogin
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(245, 120);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(289, 20);
            this.textBoxUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(245, 194);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(289, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(245, 272);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(459, 272);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(75, 23);
            this.buttonBatal.TabIndex = 5;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Location = new System.Drawing.Point(357, 322);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(55, 13);
            this.linkLabelRegister.TabIndex = 6;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "linkLabel1";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
    }
}