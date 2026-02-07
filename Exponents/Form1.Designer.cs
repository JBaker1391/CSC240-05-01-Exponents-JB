namespace Exponents
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
            this.XInputTextBox = new System.Windows.Forms.TextBox();
            this.XInputLabel = new System.Windows.Forms.Label();
            this.XOutputLabel = new System.Windows.Forms.Label();
            this.XGoButton = new System.Windows.Forms.Button();
            this.XResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XInputTextBox
            // 
            this.XInputTextBox.Location = new System.Drawing.Point(92, 45);
            this.XInputTextBox.Name = "XInputTextBox";
            this.XInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.XInputTextBox.TabIndex = 1;
            // 
            // XInputLabel
            // 
            this.XInputLabel.AutoSize = true;
            this.XInputLabel.Location = new System.Drawing.Point(92, 27);
            this.XInputLabel.Name = "XInputLabel";
            this.XInputLabel.Size = new System.Drawing.Size(85, 13);
            this.XInputLabel.TabIndex = 0;
            this.XInputLabel.Text = "Enter an integer:";
            // 
            // xOutputLabel
            // 
            this.XOutputLabel.AutoSize = true;
            this.XOutputLabel.Location = new System.Drawing.Point(102, 181);
            this.XOutputLabel.Name = "xOutputLabel";
            this.XOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.XOutputLabel.TabIndex = 3;
            this.XOutputLabel.Visible = false;
            // 
            // XGoButton
            // 
            this.XGoButton.Location = new System.Drawing.Point(92, 96);
            this.XGoButton.Name = "XGoButton";
            this.XGoButton.Size = new System.Drawing.Size(75, 67);
            this.XGoButton.TabIndex = 2;
            this.XGoButton.Text = "Go!";
            this.XGoButton.UseVisualStyleBackColor = true;
            this.XGoButton.Click += new System.EventHandler(this.XGoButton_Click);
            // 
            // XResetButton
            // 
            this.XResetButton.Location = new System.Drawing.Point(95, 212);
            this.XResetButton.Name = "XResetButton";
            this.XResetButton.Size = new System.Drawing.Size(75, 23);
            this.XResetButton.TabIndex = 4;
            this.XResetButton.Text = "Reset";
            this.XResetButton.UseVisualStyleBackColor = true;
            this.XResetButton.Click += new System.EventHandler(this.XResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.XResetButton);
            this.Controls.Add(this.XGoButton);
            this.Controls.Add(this.XOutputLabel);
            this.Controls.Add(this.XInputLabel);
            this.Controls.Add(this.XInputTextBox);
            this.Name = "Form1";
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XInputTextBox;
        private System.Windows.Forms.Label XInputLabel;
        private System.Windows.Forms.Label XOutputLabel;
        private System.Windows.Forms.Button XGoButton;
        private System.Windows.Forms.Button XResetButton;
    }
}

