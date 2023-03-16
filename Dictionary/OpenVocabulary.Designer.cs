namespace Vocabulary
{
    partial class OpenVocabulary
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
            this.components = new System.ComponentModel.Container();
            this.bBack = new System.Windows.Forms.Button();
            this.lbVocabulary = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveInAnotherVocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
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
            this.bBack.TabIndex = 1;
            this.bBack.TabStop = false;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lbDictionary
            // 
            this.lbVocabulary.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbVocabulary.ContextMenuStrip = this.contextMenuStrip;
            this.lbVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVocabulary.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbVocabulary.FormattingEnabled = true;
            this.lbVocabulary.HorizontalScrollbar = true;
            this.lbVocabulary.ItemHeight = 25;
            this.lbVocabulary.Items.AddRange(new object[] {
            ""});
            this.lbVocabulary.Location = new System.Drawing.Point(2, 46);
            this.lbVocabulary.Name = "lbDictionary";
            this.lbVocabulary.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbVocabulary.Size = new System.Drawing.Size(833, 429);
            this.lbVocabulary.TabIndex = 2;
            this.lbVocabulary.TabStop = false;
            this.lbVocabulary.SelectedIndexChanged += new System.EventHandler(this.lbDictionary_SelectedIndexChanged);
            this.lbVocabulary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbDictionary_KeyDown);
            this.lbVocabulary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDictionary_MouseDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.moveInAnotherVocabularyToolStripMenuItem,
            this.addAWordToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(223, 92);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.delateToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Enabled = false;
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // moveInAnotherVocabularyToolStripMenuItem
            // 
            this.moveInAnotherVocabularyToolStripMenuItem.Enabled = false;
            this.moveInAnotherVocabularyToolStripMenuItem.Name = "moveInAnotherVocabularyToolStripMenuItem";
            this.moveInAnotherVocabularyToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.moveInAnotherVocabularyToolStripMenuItem.Text = "Move in another vocabulary";
            this.moveInAnotherVocabularyToolStripMenuItem.Click += new System.EventHandler(this.moveInAnotherVocabularyToolStripMenuItem_Click);
            // 
            // addAWordToolStripMenuItem
            // 
            this.addAWordToolStripMenuItem.Name = "addAWordToolStripMenuItem";
            this.addAWordToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addAWordToolStripMenuItem.Text = "Add a word";
            this.addAWordToolStripMenuItem.Click += new System.EventHandler(this.addAWordToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(180, 10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(162, 26);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(348, 13);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 13;
            this.bSearch.TabStop = false;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // FormForSeeingWords
            // 
            this.AcceptButton = this.bSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.bBack;
            this.ClientSize = new System.Drawing.Size(836, 477);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbVocabulary);
            this.Controls.Add(this.bBack);
            this.KeyPreview = true;
            this.Name = "FormForSeeingWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForSeeingWords_FormClosed);
            this.LocationChanged += new System.EventHandler(this.FormForSeeingWords_LocationChanged);
            this.VisibleChanged += new System.EventHandler(this.FormForSeeingWords_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormForSeeingWords_MouseDown);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.ListBox lbVocabulary;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveInAnotherVocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAWordToolStripMenuItem;
    }
}