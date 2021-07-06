
namespace TCDates
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bigRedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bigRedButton
            // 
            this.bigRedButton.BackColor = System.Drawing.Color.Red;
            this.bigRedButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigRedButton.ForeColor = System.Drawing.Color.White;
            this.bigRedButton.Location = new System.Drawing.Point(295, 159);
            this.bigRedButton.Name = "bigRedButton";
            this.bigRedButton.Size = new System.Drawing.Size(215, 90);
            this.bigRedButton.TabIndex = 0;
            this.bigRedButton.Text = "Click Me";
            this.bigRedButton.UseVisualStyleBackColor = false;
            this.bigRedButton.Click += new System.EventHandler(this.bigRedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bigRedButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bigRedButton;
    }
}

