namespace Vocabulary
{
    partial class PlaySecondGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.lWordToGuess = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.bRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(243, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Choose the right translation";
            // 
            // bBack
            // 
            this.bBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bBack.Location = new System.Drawing.Point(12, 12);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 17;
            this.bBack.TabStop = false;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lWordToGuess
            // 
            this.lWordToGuess.AutoSize = true;
            this.lWordToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWordToGuess.Location = new System.Drawing.Point(393, 64);
            this.lWordToGuess.Name = "lWordToGuess";
            this.lWordToGuess.Size = new System.Drawing.Size(0, 29);
            this.lWordToGuess.TabIndex = 19;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButtons.Location = new System.Drawing.Point(31, 109);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(732, 222);
            this.pnlButtons.TabIndex = 20;
            // 
            // bRestart
            // 
            this.bRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRestart.Location = new System.Drawing.Point(637, 12);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(146, 43);
            this.bRestart.TabIndex = 21;
            this.bRestart.Text = "Restart";
            this.bRestart.UseVisualStyleBackColor = true;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // PlaySecondGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.bBack;
            this.ClientSize = new System.Drawing.Size(799, 339);
            this.Controls.Add(this.bRestart);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lWordToGuess);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.label1);
            this.Name = "PlaySecondGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormForPlaySecondGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForPlaySecondGame_FormClosed);
            this.LocationChanged += new System.EventHandler(this.FormForPlaySecondGame_LocationChanged);
            this.VisibleChanged += new System.EventHandler(this.FormForPlaySecondGame_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label lWordToGuess;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button bRestart;
    }
}