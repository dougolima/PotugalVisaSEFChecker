namespace PortugalVistoCheckerTraySystem
{
    partial class FormLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastExcution = new System.Windows.Forms.Label();
            this.lblLastResult = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblNextExecution = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Execution:";
            // 
            // lblLastExcution
            // 
            this.lblLastExcution.AutoSize = true;
            this.lblLastExcution.Location = new System.Drawing.Point(218, 48);
            this.lblLastExcution.Name = "lblLastExcution";
            this.lblLastExcution.Size = new System.Drawing.Size(73, 19);
            this.lblLastExcution.TabIndex = 1;
            this.lblLastExcution.Text = "Date Hour";
            this.lblLastExcution.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLastResult
            // 
            this.lblLastResult.AutoSize = true;
            this.lblLastResult.Location = new System.Drawing.Point(218, 15);
            this.lblLastResult.Name = "lblLastResult";
            this.lblLastResult.Size = new System.Drawing.Size(46, 19);
            this.lblLastResult.TabIndex = 4;
            this.lblLastResult.Text = "Result";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(218, 81);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(46, 19);
            this.lblInterval.TabIndex = 5;
            this.lblInterval.Text = "Result";
            // 
            // lblNextExecution
            // 
            this.lblNextExecution.AutoSize = true;
            this.lblNextExecution.Location = new System.Drawing.Point(218, 114);
            this.lblNextExecution.Name = "lblNextExecution";
            this.lblNextExecution.Size = new System.Drawing.Size(73, 19);
            this.lblNextExecution.TabIndex = 3;
            this.lblNextExecution.Text = "Date Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Next Execution:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Interval:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Last Status:";
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 157);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblLastResult);
            this.Controls.Add(this.lblNextExecution);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLastExcution);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Execution Logs";
            this.Load += new System.EventHandler(this.FormLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastExcution;
        private System.Windows.Forms.Label lblLastResult;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblNextExecution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}