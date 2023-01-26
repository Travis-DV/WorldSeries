namespace WorldSeries
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.teamsLBOX = new System.Windows.Forms.ListBox();
            this.outputLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // teamsLBOX
            // 
            this.teamsLBOX.FormattingEnabled = true;
            this.teamsLBOX.Location = new System.Drawing.Point(13, 13);
            this.teamsLBOX.Name = "teamsLBOX";
            this.teamsLBOX.Size = new System.Drawing.Size(171, 199);
            this.teamsLBOX.TabIndex = 0;
            this.teamsLBOX.SelectedIndexChanged += new System.EventHandler(this.teamsLBOX_SelectedIndexChanged);
            // 
            // outputLB
            // 
            this.outputLB.AutoSize = true;
            this.outputLB.Location = new System.Drawing.Point(190, 105);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(35, 13);
            this.outputLB.TabIndex = 1;
            this.outputLB.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 225);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.teamsLBOX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox teamsLBOX;
        private System.Windows.Forms.Label outputLB;
    }
}

