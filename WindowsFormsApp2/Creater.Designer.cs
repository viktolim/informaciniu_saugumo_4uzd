
namespace WindowsFormsApp2
{
    partial class Creater
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
            this.setName = new System.Windows.Forms.TextBox();
            this.SetPassword = new System.Windows.Forms.TextBox();
            this.SetUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.setComment = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pavadinimas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // setName
            // 
            this.setName.Location = new System.Drawing.Point(292, 94);
            this.setName.Name = "setName";
            this.setName.Size = new System.Drawing.Size(207, 22);
            this.setName.TabIndex = 1;
            // 
            // SetPassword
            // 
            this.SetPassword.Location = new System.Drawing.Point(292, 139);
            this.SetPassword.Name = "SetPassword";
            this.SetPassword.Size = new System.Drawing.Size(207, 22);
            this.SetPassword.TabIndex = 2;
            this.SetPassword.Click += new System.EventHandler(this.SetPassword_Click);
            // 
            // SetUrl
            // 
            this.SetUrl.Location = new System.Drawing.Point(292, 186);
            this.SetUrl.Name = "SetUrl";
            this.SetUrl.Size = new System.Drawing.Size(207, 22);
            this.SetUrl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Slaptažodis:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "URL:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Komentaras:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kurti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ieškoti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // setComment
            // 
            this.setComment.Location = new System.Drawing.Point(292, 232);
            this.setComment.Name = "setComment";
            this.setComment.Size = new System.Drawing.Size(207, 93);
            this.setComment.TabIndex = 8;
            this.setComment.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Rodyti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Dešifruoti";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(520, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "Naikinti";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(661, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 29);
            this.button6.TabIndex = 12;
            this.button6.Text = "Keisti";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Creater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.setComment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SetUrl);
            this.Controls.Add(this.SetPassword);
            this.Controls.Add(this.setName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Creater";
            this.Text = "Creater";
            this.Load += new System.EventHandler(this.Creater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox setName;
        private System.Windows.Forms.TextBox SetPassword;
        private System.Windows.Forms.TextBox SetUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox setComment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}