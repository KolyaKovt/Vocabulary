namespace Vocabulary
{
    partial class ChangeWords
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
            this.tbEnglishWord = new System.Windows.Forms.TextBox();
            this.tbRussianWord = new System.Windows.Forms.TextBox();
            this.lEng = new System.Windows.Forms.Label();
            this.lRus = new System.Windows.Forms.Label();
            this.bChangeAWord = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEnglishWord.Location = new System.Drawing.Point(422, 71);
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(387, 29);
            this.tbEnglishWord.TabIndex = 12;
            // 
            // tbRussianWord
            // 
            this.tbRussianWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbRussianWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRussianWord.Location = new System.Drawing.Point(14, 71);
            this.tbRussianWord.Name = "tbRussianWord";
            this.tbRussianWord.Size = new System.Drawing.Size(382, 29);
            this.tbRussianWord.TabIndex = 11;
            // 
            // lEng
            // 
            this.lEng.AutoSize = true;
            this.lEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEng.Location = new System.Drawing.Point(418, 44);
            this.lEng.Name = "lEng";
            this.lEng.Size = new System.Drawing.Size(289, 24);
            this.lEng.TabIndex = 10;
            this.lEng.Text = "Enter a word in second language";
            // 
            // lRus
            // 
            this.lRus.AutoSize = true;
            this.lRus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRus.Location = new System.Drawing.Point(14, 44);
            this.lRus.Name = "lRus";
            this.lRus.Size = new System.Drawing.Size(253, 24);
            this.lRus.TabIndex = 9;
            this.lRus.Text = "Enter a word in first language";
            // 
            // bChangeAWord
            // 
            this.bChangeAWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bChangeAWord.Location = new System.Drawing.Point(314, 106);
            this.bChangeAWord.Name = "bChangeAWord";
            this.bChangeAWord.Size = new System.Drawing.Size(184, 70);
            this.bChangeAWord.TabIndex = 8;
            this.bChangeAWord.TabStop = false;
            this.bChangeAWord.Text = "Change the word";
            this.bChangeAWord.UseVisualStyleBackColor = true;
            this.bChangeAWord.Click += new System.EventHandler(this.bChangeAWord_Click);
            // 
            // bBack
            // 
            this.bBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bBack.Location = new System.Drawing.Point(12, 12);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 13;
            this.bBack.TabStop = false;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // FormForChangingWord
            // 
            this.AcceptButton = this.bChangeAWord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.bBack;
            this.ClientSize = new System.Drawing.Size(817, 191);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.tbEnglishWord);
            this.Controls.Add(this.tbRussianWord);
            this.Controls.Add(this.lEng);
            this.Controls.Add(this.lRus);
            this.Controls.Add(this.bChangeAWord);
            this.KeyPreview = true;
            this.Name = "FormForChangingWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Changing the word";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForChangingWord_FormClosed);
            this.LocationChanged += new System.EventHandler(this.FormForChangingWord_LocationChanged);
            this.VisibleChanged += new System.EventHandler(this.FormForChangingWord_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEnglishWord;
        private System.Windows.Forms.TextBox tbRussianWord;
        private System.Windows.Forms.Label lEng;
        private System.Windows.Forms.Label lRus;
        private System.Windows.Forms.Button bChangeAWord;
        private System.Windows.Forms.Button bBack;
    }
}