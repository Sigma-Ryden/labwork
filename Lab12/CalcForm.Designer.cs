namespace Lab_12
{
    partial class CalcForm
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
            if (disposing && (components != null)) {
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
            this.TextField = new System.Windows.Forms.TextBox();
            this.ChangeSignButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.KeyboardLayout = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TextField
            // 
            this.TextField.Location = new System.Drawing.Point(12, 12);
            this.TextField.Name = "TextField";
            this.TextField.ReadOnly = true;
            this.TextField.Size = new System.Drawing.Size(153, 20);
            this.TextField.TabIndex = 0;
            this.TextField.Text = "0";
            this.TextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ChangeSignButton
            // 
            this.ChangeSignButton.Location = new System.Drawing.Point(12, 38);
            this.ChangeSignButton.Name = "ChangeSignButton";
            this.ChangeSignButton.Size = new System.Drawing.Size(43, 29);
            this.ChangeSignButton.TabIndex = 1;
            this.ChangeSignButton.Text = "+/-";
            this.ChangeSignButton.UseVisualStyleBackColor = true;
            this.ChangeSignButton.Click += new System.EventHandler(this.ChangeSignButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(124, 38);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(41, 29);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // KeyboardLayout
            // 
            this.KeyboardLayout.BackColor = System.Drawing.SystemColors.Window;
            this.KeyboardLayout.Location = new System.Drawing.Point(13, 77);
            this.KeyboardLayout.Name = "KeyboardLayout";
            this.KeyboardLayout.Size = new System.Drawing.Size(152, 149);
            this.KeyboardLayout.TabIndex = 3;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(177, 238);
            this.Controls.Add(this.KeyboardLayout);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ChangeSignButton);
            this.Controls.Add(this.TextField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalcForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel KeyboardLayout;

        private System.Windows.Forms.Button ClearButton;

        private System.Windows.Forms.Button ChangeSignButton;

        private System.Windows.Forms.TextBox TextField;
        #endregion
    }
}