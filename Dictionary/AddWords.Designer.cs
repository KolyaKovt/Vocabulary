namespace Vocabulary
{
    partial class AddWords
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
            this.bBack = new System.Windows.Forms.Button();
            this.bAddOneWord = new System.Windows.Forms.Button();
            this.lRus = new System.Windows.Forms.Label();
            this.lEng = new System.Windows.Forms.Label();
            this.tbEnglishWord = new System.Windows.Forms.TextBox();
            this.tbRussianWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bBack.Location = new System.Drawing.Point(12, 12);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 0;
            this.bBack.TabStop = false;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bAddOneWord
            // 
            this.bAddOneWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddOneWord.Location = new System.Drawing.Point(306, 135);
            this.bAddOneWord.Name = "bAddOneWord";
            this.bAddOneWord.Size = new System.Drawing.Size(184, 70);
            this.bAddOneWord.TabIndex = 1;
            this.bAddOneWord.TabStop = false;
            this.bAddOneWord.Text = "Add the word";
            this.bAddOneWord.UseVisualStyleBackColor = true;
            this.bAddOneWord.Click += new System.EventHandler(this.bAddOneWord_Click);
            // 
            // lRus
            // 
            this.lRus.AutoSize = true;
            this.lRus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRus.Location = new System.Drawing.Point(8, 54);
            this.lRus.Name = "lRus";
            this.lRus.Size = new System.Drawing.Size(253, 24);
            this.lRus.TabIndex = 2;
            this.lRus.Text = "Enter a word in first language";
            // 
            // lEng
            // 
            this.lEng.AutoSize = true;
            this.lEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEng.Location = new System.Drawing.Point(418, 54);
            this.lEng.Name = "lEng";
            this.lEng.Size = new System.Drawing.Size(289, 24);
            this.lEng.TabIndex = 3;
            this.lEng.Text = "Enter a word in second language";
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEnglishWord.Location = new System.Drawing.Point(422, 81);
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(378, 29);
            this.tbEnglishWord.TabIndex = 14;
            // 
            // tbRussianWord
            // 
            this.tbRussianWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbRussianWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRussianWord.Location = new System.Drawing.Point(12, 81);
            this.tbRussianWord.Name = "tbRussianWord";
            this.tbRussianWord.Size = new System.Drawing.Size(382, 29);
            this.tbRussianWord.TabIndex = 13;
            // 
            // FormForAddingWords
            // 
            this.AcceptButton = this.bAddOneWord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.bBack;
            this.ClientSize = new System.Drawing.Size(812, 239);
            this.Controls.Add(this.tbEnglishWord);
            this.Controls.Add(this.tbRussianWord);
            this.Controls.Add(this.lEng);
            this.Controls.Add(this.lRus);
            this.Controls.Add(this.bAddOneWord);
            this.Controls.Add(this.bBack);
            this.KeyPreview = true;
            this.Name = "FormForAddingWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Adding words";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForAddingWords_FormClosed);
            this.LocationChanged += new System.EventHandler(this.FormForAddingWords_LocationChanged);
            this.VisibleChanged += new System.EventHandler(this.FormForAddingWords_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bAddOneWord;
        private System.Windows.Forms.Label lRus;
        private System.Windows.Forms.Label lEng;
        private System.Windows.Forms.TextBox tbEnglishWord;
        private System.Windows.Forms.TextBox tbRussianWord;
    }
}