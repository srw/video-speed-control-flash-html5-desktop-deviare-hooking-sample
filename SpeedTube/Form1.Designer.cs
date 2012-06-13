namespace DeviareTest
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
            this.SlowButton = new System.Windows.Forms.RadioButton();
            this.FastButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // SlowButton
            // 
            this.SlowButton.AutoSize = true;
            this.SlowButton.Location = new System.Drawing.Point(49, 49);
            this.SlowButton.Name = "SlowButton";
            this.SlowButton.Size = new System.Drawing.Size(48, 17);
            this.SlowButton.TabIndex = 0;
            this.SlowButton.TabStop = true;
            this.SlowButton.Text = "Slow";
            this.SlowButton.UseVisualStyleBackColor = true;
            this.SlowButton.CheckedChanged += new System.EventHandler(this.SlowButton_CheckedChanged);
            // 
            // FastButton
            // 
            this.FastButton.AutoSize = true;
            this.FastButton.Location = new System.Drawing.Point(160, 49);
            this.FastButton.Name = "FastButton";
            this.FastButton.Size = new System.Drawing.Size(45, 17);
            this.FastButton.TabIndex = 1;
            this.FastButton.TabStop = true;
            this.FastButton.Text = "Fast";
            this.FastButton.UseVisualStyleBackColor = true;
            this.FastButton.CheckedChanged += new System.EventHandler(this.FastButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 115);
            this.Controls.Add(this.FastButton);
            this.Controls.Add(this.SlowButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton SlowButton;
        private System.Windows.Forms.RadioButton FastButton;


    }
}

