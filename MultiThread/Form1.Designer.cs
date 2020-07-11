namespace MultiThread
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
            this.Thread1Button = new System.Windows.Forms.Button();
            this.Thread2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Thread1Button
            // 
            this.Thread1Button.Location = new System.Drawing.Point(12, 12);
            this.Thread1Button.Name = "Thread1Button";
            this.Thread1Button.Size = new System.Drawing.Size(75, 23);
            this.Thread1Button.TabIndex = 0;
            this.Thread1Button.Text = "Thread 1";
            this.Thread1Button.UseVisualStyleBackColor = true;
            this.Thread1Button.Click += new System.EventHandler(this.Thread1Button_Click);
            // 
            // Thread2Button
            // 
            this.Thread2Button.Location = new System.Drawing.Point(93, 12);
            this.Thread2Button.Name = "Thread2Button";
            this.Thread2Button.Size = new System.Drawing.Size(75, 23);
            this.Thread2Button.TabIndex = 1;
            this.Thread2Button.Text = "Thread 2";
            this.Thread2Button.UseVisualStyleBackColor = true;
            this.Thread2Button.Click += new System.EventHandler(this.Thread2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Thread2Button);
            this.Controls.Add(this.Thread1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Thread1Button;
        private System.Windows.Forms.Button Thread2Button;
    }
}

