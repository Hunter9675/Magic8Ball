namespace Magic8Ball
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
            this.eightBallButton = new System.Windows.Forms.Button();
            this.eightBallOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eightBallButton
            // 
            this.eightBallButton.BackColor = System.Drawing.Color.Transparent;
            this.eightBallButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eightBallButton.Location = new System.Drawing.Point(-15, -8);
            this.eightBallButton.Name = "eightBallButton";
            this.eightBallButton.Size = new System.Drawing.Size(702, 573);
            this.eightBallButton.TabIndex = 0;
            this.eightBallButton.UseVisualStyleBackColor = false;
            this.eightBallButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // eightBallOutput
            // 
            this.eightBallOutput.AutoSize = true;
            this.eightBallOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBallOutput.ForeColor = System.Drawing.Color.White;
            this.eightBallOutput.Location = new System.Drawing.Point(37, 498);
            this.eightBallOutput.Name = "eightBallOutput";
            this.eightBallOutput.Size = new System.Drawing.Size(0, 29);
            this.eightBallOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(633, 549);
            this.Controls.Add(this.eightBallOutput);
            this.Controls.Add(this.eightBallButton);
            this.Name = "Form1";
            this.Text = "Magic 8 Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eightBallButton;
        private System.Windows.Forms.Label eightBallOutput;
    }
}

