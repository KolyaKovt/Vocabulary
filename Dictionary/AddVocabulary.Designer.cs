namespace Vocabulary
{
    partial class AddVocabulary
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
            this.tbAddADictionary = new System.Windows.Forms.TextBox();
            this.bAddADictionary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the name of the vocabulary";
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
            // tbAddADictionary
            // 
            this.tbAddADictionary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbAddADictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddADictionary.Location = new System.Drawing.Point(75, 64);
            this.tbAddADictionary.Name = "tbAddADictionary";
            this.tbAddADictionary.Size = new System.Drawing.Size(383, 31);
            this.tbAddADictionary.TabIndex = 2;
            this.tbAddADictionary.TabStop = false;
            // 
            // bAddADictionary
            // 
            this.bAddADictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddADictionary.Location = new System.Drawing.Point(134, 101);
            this.bAddADictionary.Name = "bAddADictionary";
            this.bAddADictionary.Size = new System.Drawing.Size(252, 64);
            this.bAddADictionary.TabIndex = 0;
            this.bAddADictionary.TabStop = false;
            this.bAddADictionary.Text = "Add the vocabulary";
            this.bAddADictionary.UseVisualStyleBackColor = true;
            this.bAddADictionary.Click += new System.EventHandler(this.bAddADictionary_Click);
            // 
            // FormForAddANewDictionary
            // 
            this.AcceptButton = this.bAddADictionary;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.bBack;
            this.ClientSize = new System.Drawing.Size(530, 189);
            this.Controls.Add(this.bAddADictionary);
            this.Controls.Add(this.tbAddADictionary);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FormForAddANewDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Adding vocabularies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForCreattingANewDictionary_FormClosed);
            this.LocationChanged += new System.EventHandler(this.FormForCreattingANewDictionary_LocationChanged);
            this.VisibleChanged += new System.EventHandler(this.FormForAddANewDictionary_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.TextBox tbAddADictionary;
        private System.Windows.Forms.Button bAddADictionary;
    }
}