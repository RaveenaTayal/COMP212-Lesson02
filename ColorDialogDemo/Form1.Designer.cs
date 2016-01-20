namespace ColorDialogDemo
{
    partial class DemoForm
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
            this.fontButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(66, 39);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(99, 23);
            this.fontButton.TabIndex = 0;
            this.fontButton.Text = "Change Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(66, 92);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(99, 23);
            this.colorButton.TabIndex = 1;
            this.colorButton.Text = "Change Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(66, 166);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(122, 13);
            this.displayLabel.TabIndex = 2;
            this.displayLabel.Text = "Hello, Raveena Tayal !!!";
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.fontButton);
            this.Name = "DemoForm";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

