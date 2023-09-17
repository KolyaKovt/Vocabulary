namespace Vocabulary
{
    partial class MoveWords
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
			this.lbDictionary = new System.Windows.Forms.ListBox();
			this.bBack = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbDictionary
			// 
			this.lbDictionary.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.lbDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbDictionary.ForeColor = System.Drawing.SystemColors.Window;
			this.lbDictionary.FormattingEnabled = true;
			this.lbDictionary.HorizontalScrollbar = true;
			this.lbDictionary.ItemHeight = 30;
			this.lbDictionary.Items.AddRange(new object[] {
            ""});
			this.lbDictionary.Location = new System.Drawing.Point(4, 69);
			this.lbDictionary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lbDictionary.Name = "lbDictionary";
			this.lbDictionary.Size = new System.Drawing.Size(1060, 484);
			this.lbDictionary.TabIndex = 25;
			this.lbDictionary.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbDictionary_MouseDoubleClick);
			this.lbDictionary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDictionary_MouseDown);
			// 
			// bBack
			// 
			this.bBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bBack.Location = new System.Drawing.Point(16, 15);
			this.bBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(100, 28);
			this.bBack.TabIndex = 31;
			this.bBack.TabStop = false;
			this.bBack.Text = "Back";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(648, 18);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 20);
			this.label2.TabIndex = 32;
			this.label2.Text = "*double click to choose";
			// 
			// MoveWords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.CancelButton = this.bBack;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.lbDictionary);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MoveWords";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Where to move?";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWhereToMoveWords_FormClosed);
			this.LocationChanged += new System.EventHandler(this.FormWhereToMoveWords_LocationChanged);
			this.VisibleChanged += new System.EventHandler(this.FormWhereToMoveWords_VisibleChanged);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormWhereToMoveWords_MouseDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbDictionary;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label label2;
    }
}