namespace WFAStartF
{
    partial class FormA
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
            this.ourTxt = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ourTxt
            // 
            this.ourTxt.Location = new System.Drawing.Point(139, 57);
            this.ourTxt.Name = "ourTxt";
            this.ourTxt.Size = new System.Drawing.Size(157, 20);
            this.ourTxt.TabIndex = 0;
            this.ourTxt.Text = "1234";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(332, 55);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Click";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.testLabel.Location = new System.Drawing.Point(208, 133);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(147, 24);
            this.testLabel.TabIndex = 2;
            this.testLabel.Text = "Welcome here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 398);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.ourTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ourTxt;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label testLabel;
    }
}

