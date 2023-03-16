namespace Vocabulary
{
    partial class RenameVocabulary
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
            this.bChangeADictionary = new System.Windows.Forms.Button();
            this.tbChangeADictionary = new System.Windows.Forms.TextBox();
            this.bBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bChangeADictionary
            // 
            this.bChangeADictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bChangeADictionary.Location = new System.Drawing.Point(174, 102);
            this.bChangeADictionary.Name = "bChangeADictionary";
            this.bChangeADictionary.Size = new System.Drawing.Size(252, 64);
            this.bChangeADictionary.TabIndex = 7;
            this.bChangeADictionary.TabStop = false;
            this.bChangeADictionary.Text = "Change the name";
            this.bChangeADictionary.UseVisualStyleBackColor = true;
            this.bChangeADictionary.Click += new System.EventHandler(this.bChangeADictionary_Click);
            // 
            // tbChangeADictionary
            // 
            this.tbChangeADictionary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbChangeADictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChangeADictionary.Location = new System.Drawing.Point(91, 65);
            this.tbChangeADictionary.Name = "tbChangeADictionary";
            this.tbChangeADictionary.Size = new System.Drawing.Size(416, 31);
            this.tbChangeADictionary.TabIndex = 6;
            this.tbChangeADictionary.TabStop = false;
            // 
            // bBack
            // 
            this.bBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bBack.Location = new System.Drawing.Point(12, 12);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 5;
            this.bBack.TabStop = false;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(226, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the name";
            // 
            // FormForChangingTheNameOfDictionary
            // 
            this.AcceptButton = this.bChangeADictionary;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.bBack;
            this.ClientSize = new System.Drawing.Size(591, 195);
            this.Controls.Add(this.bChangeADictionary);
            this.Controls.Add(this.tbChangeADictionary);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FormForChangingTheNameOfDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Changing the name of the dictionary";
            this.Activated += new System.EventHandler(this.FormForChangingTheNameOfDictionary_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForChangingTheNameOfDictionary_FormClosed);
            this.LocationChanged += new System.EventHandler(this.FormForChangingTheNameOfDictionary_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bChangeADictionary;
        private System.Windows.Forms.TextBox tbChangeADictionary;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label label1;
    }
}