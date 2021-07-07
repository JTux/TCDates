
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
            this.dateDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateCountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.exportButton.Location = new System.Drawing.Point(334, 270);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(146, 51);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export Dates";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dates currently stored:";
            // 
            // dateDisplay
            // 
            this.dateDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateDisplay.AutoSize = true;
            this.dateDisplay.Location = new System.Drawing.Point(306, 7);
            this.dateDisplay.Name = "dateDisplay";
            this.dateDisplay.Size = new System.Drawing.Size(107, 15);
            this.dateDisplay.TabIndex = 5;
            this.dateDisplay.Text = "No dates recorded.";
            this.dateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.98077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.01923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel1.Controls.Add(this.dateDisplay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateCountLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 235);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 29);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dateCountLabel
            // 
            this.dateCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateCountLabel.AutoSize = true;
            this.dateCountLabel.Location = new System.Drawing.Point(134, 7);
            this.dateCountLabel.Name = "dateCountLabel";
            this.dateCountLabel.Size = new System.Drawing.Size(13, 15);
            this.dateCountLabel.TabIndex = 6;
            this.dateCountLabel.Text = "0";
            // 
            // DateTimeRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.bigRedButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "DateTimeRecorder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Date Time Recorder";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bigRedButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label dateCountLabel;
    }
}

