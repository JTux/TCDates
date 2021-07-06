
namespace TCDates
{
    partial class DateTimeRecorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateTimeRecorder));
            this.bigRedButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bigRedButton
            // 
            this.bigRedButton.BackColor = System.Drawing.Color.Red;
            this.bigRedButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigRedButton.ForeColor = System.Drawing.Color.White;
            this.bigRedButton.Location = new System.Drawing.Point(200, 110);
            this.bigRedButton.Name = "bigRedButton";
            this.bigRedButton.Size = new System.Drawing.Size(416, 119);
            this.bigRedButton.TabIndex = 0;
            this.bigRedButton.Text = "Record Current DateTime";
            this.bigRedButton.UseVisualStyleBackColor = false;
            this.bigRedButton.Click += new System.EventHandler(this.bigRedButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(335, 300);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(146, 51);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export Dates";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dates currently stored:";
            // 
            // dateCount
            // 
            this.dateCount.Enabled = false;
            this.dateCount.Location = new System.Drawing.Point(335, 271);
            this.dateCount.Name = "dateCount";
            this.dateCount.ReadOnly = true;
            this.dateCount.Size = new System.Drawing.Size(146, 23);
            this.dateCount.TabIndex = 4;
            this.dateCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.bigRedButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Date Time Recorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bigRedButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateCount;
    }
}

