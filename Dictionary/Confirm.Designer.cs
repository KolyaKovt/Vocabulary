namespace Vocabulary
{
    partial class Confirm
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
            this.bYes = new System.Windows.Forms.Button();
            this.bNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bYes
            // 
            this.bYes.Location = new System.Drawing.Point(52, 70);
            this.bYes.Name = "bYes";
            this.bYes.Size = new System.Drawing.Size(75, 23);
            this.bYes.TabIndex = 0;
            this.bYes.Text = "Yes";
            this.bYes.UseVisualStyleBackColor = true;
            this.bYes.Click += new System.EventHandler(this.bYes_Click);
            // 
            // bNo
            // 
            this.bNo.Location = new System.Drawing.Point(177, 70);
            this.bNo.Name = "bNo";
            this.bNo.Size = new System.Drawing.Size(75, 23);
            this.bNo.TabIndex = 1;
            this.bNo.Text = "No";
            this.bNo.UseVisualStyleBackColor = true;
            this.bNo.Click += new System.EventHandler(this.bNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // FormAreYouSure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNo);
            this.Controls.Add(this.bYes);
            this.Name = "FormAreYouSure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAreYouSure";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAreYouSure_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.FormAreYouSure_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bYes;
        private System.Windows.Forms.Button bNo;
        private System.Windows.Forms.Label label1;
    }
}