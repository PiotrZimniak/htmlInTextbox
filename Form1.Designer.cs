namespace htmlInTextbox
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
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.test1Button = new System.Windows.Forms.Button();
            this.test2Button = new System.Windows.Forms.Button();
            this.test3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(12, 43);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(408, 20);
            this.valueTextBox.TabIndex = 0;
            // 
            // test1Button
            // 
            this.test1Button.Location = new System.Drawing.Point(12, 12);
            this.test1Button.Name = "test1Button";
            this.test1Button.Size = new System.Drawing.Size(132, 25);
            this.test1Button.TabIndex = 1;
            this.test1Button.Text = "test1";
            this.test1Button.UseVisualStyleBackColor = true;
            this.test1Button.Click += new System.EventHandler(this.test1Button_Click);
            // 
            // test2Button
            // 
            this.test2Button.Location = new System.Drawing.Point(150, 12);
            this.test2Button.Name = "test2Button";
            this.test2Button.Size = new System.Drawing.Size(132, 25);
            this.test2Button.TabIndex = 2;
            this.test2Button.Text = "test2";
            this.test2Button.UseVisualStyleBackColor = true;
            this.test2Button.Click += new System.EventHandler(this.test2Button_Click);
            // 
            // test3Button
            // 
            this.test3Button.Location = new System.Drawing.Point(288, 12);
            this.test3Button.Name = "test3Button";
            this.test3Button.Size = new System.Drawing.Size(132, 25);
            this.test3Button.TabIndex = 3;
            this.test3Button.Text = "test3";
            this.test3Button.UseVisualStyleBackColor = true;
            this.test3Button.Click += new System.EventHandler(this.test3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 82);
            this.Controls.Add(this.test3Button);
            this.Controls.Add(this.test2Button);
            this.Controls.Add(this.test1Button);
            this.Controls.Add(this.valueTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button test1Button;
        private System.Windows.Forms.Button test2Button;
        private System.Windows.Forms.Button test3Button;
    }
}

