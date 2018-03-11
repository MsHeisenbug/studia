namespace TestyWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbNumberOfQuestions = new System.Windows.Forms.TextBox();
            this.btnGenerateTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumberOfQuestions
            // 
            this.tbNumberOfQuestions.Location = new System.Drawing.Point(163, 81);
            this.tbNumberOfQuestions.Name = "tbNumberOfQuestions";
            this.tbNumberOfQuestions.Size = new System.Drawing.Size(119, 20);
            this.tbNumberOfQuestions.TabIndex = 0;
            // 
            // btnGenerateTest
            // 
            this.btnGenerateTest.Location = new System.Drawing.Point(163, 125);
            this.btnGenerateTest.Name = "btnGenerateTest";
            this.btnGenerateTest.Size = new System.Drawing.Size(119, 23);
            this.btnGenerateTest.TabIndex = 1;
            this.btnGenerateTest.Text = "OK";
            this.btnGenerateTest.UseVisualStyleBackColor = true;
            this.btnGenerateTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ile pytań wygenerować? Max 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateTest);
            this.Controls.Add(this.tbNumberOfQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Generator testów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumberOfQuestions;
        private System.Windows.Forms.Button btnGenerateTest;
        private System.Windows.Forms.Label label1;
    }
}

