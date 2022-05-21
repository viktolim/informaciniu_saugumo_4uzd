
namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.setUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slapyvardis:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // setUsername
            // 
            this.setUsername.Location = new System.Drawing.Point(302, 106);
            this.setUsername.Name = "setUsername";
            this.setUsername.Size = new System.Drawing.Size(288, 22);
            this.setUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Slaptažodis:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // setPassword
            // 
            this.setPassword.Location = new System.Drawing.Point(302, 154);
            this.setPassword.Name = "setPassword";
            this.setPassword.Size = new System.Drawing.Size(288, 22);
            this.setPassword.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Prisijungti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.setPassword);
            this.Controls.Add(this.setUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox setUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox setPassword;
        private System.Windows.Forms.Button button1;
    }
}

