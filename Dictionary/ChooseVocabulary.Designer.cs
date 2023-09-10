namespace Vocabulary
{
    partial class ChooseVocabulary
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.lbVocabulary = new System.Windows.Forms.ListBox();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playAGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectingWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guessingWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addAVocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tbSearchWord = new System.Windows.Forms.TextBox();
			this.bSearchWord = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbVocabulary
			// 
			this.lbVocabulary.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.lbVocabulary.ContextMenuStrip = this.contextMenuStrip;
			this.lbVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbVocabulary.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lbVocabulary.FormattingEnabled = true;
			this.lbVocabulary.HorizontalScrollbar = true;
			this.lbVocabulary.ItemHeight = 30;
			this.lbVocabulary.Items.AddRange(new object[] {
            ""});
			this.lbVocabulary.Location = new System.Drawing.Point(1, 67);
			this.lbVocabulary.Margin = new System.Windows.Forms.Padding(4);
			this.lbVocabulary.Name = "lbVocabulary";
			this.lbVocabulary.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbVocabulary.Size = new System.Drawing.Size(1065, 484);
			this.lbVocabulary.TabIndex = 15;
			this.lbVocabulary.TabStop = false;
			this.lbVocabulary.SelectedIndexChanged += new System.EventHandler(this.lbDictionary_SelectedIndexChanged);
			this.lbVocabulary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbDictionary_KeyDown);
			this.lbVocabulary.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbDictionary_MouseDoubleClick);
			this.lbVocabulary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDictionary_MouseDown);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.playAGameToolStripMenuItem,
            this.addAVocabularyToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(195, 100);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Enabled = false;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DelateToolStripMenuItem_Click);
			// 
			// changeToolStripMenuItem
			// 
			this.changeToolStripMenuItem.Enabled = false;
			this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
			this.changeToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
			this.changeToolStripMenuItem.Text = "Rename";
			this.changeToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
			// 
			// playAGameToolStripMenuItem
			// 
			this.playAGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectingWordsToolStripMenuItem,
            this.guessingWordsToolStripMenuItem});
			this.playAGameToolStripMenuItem.Enabled = false;
			this.playAGameToolStripMenuItem.Name = "playAGameToolStripMenuItem";
			this.playAGameToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
			this.playAGameToolStripMenuItem.Text = "Play games";
			// 
			// connectingWordsToolStripMenuItem
			// 
			this.connectingWordsToolStripMenuItem.Name = "connectingWordsToolStripMenuItem";
			this.connectingWordsToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
			this.connectingWordsToolStripMenuItem.Text = "Connecting words";
			this.connectingWordsToolStripMenuItem.Click += new System.EventHandler(this.connectingWordsToolStripMenuItem_Click);
			// 
			// guessingWordsToolStripMenuItem
			// 
			this.guessingWordsToolStripMenuItem.Name = "guessingWordsToolStripMenuItem";
			this.guessingWordsToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
			this.guessingWordsToolStripMenuItem.Text = "Guessing words";
			this.guessingWordsToolStripMenuItem.Click += new System.EventHandler(this.guessingWordsToolStripMenuItem_Click);
			// 
			// addAVocabularyToolStripMenuItem
			// 
			this.addAVocabularyToolStripMenuItem.Name = "addAVocabularyToolStripMenuItem";
			this.addAVocabularyToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
			this.addAVocabularyToolStripMenuItem.Text = "Add a vocabulary";
			this.addAVocabularyToolStripMenuItem.Click += new System.EventHandler(this.addAVocabularyToolStripMenuItem_Click);
			// 
			// tbSearchWord
			// 
			this.tbSearchWord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tbSearchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbSearchWord.Location = new System.Drawing.Point(139, 13);
			this.tbSearchWord.Margin = new System.Windows.Forms.Padding(4);
			this.tbSearchWord.Name = "tbSearchWord";
			this.tbSearchWord.Size = new System.Drawing.Size(223, 30);
			this.tbSearchWord.TabIndex = 38;
			// 
			// bSearchWord
			// 
			this.bSearchWord.Location = new System.Drawing.Point(371, 15);
			this.bSearchWord.Margin = new System.Windows.Forms.Padding(4);
			this.bSearchWord.Name = "bSearchWord";
			this.bSearchWord.Size = new System.Drawing.Size(100, 28);
			this.bSearchWord.TabIndex = 37;
			this.bSearchWord.TabStop = false;
			this.bSearchWord.Text = "Search";
			this.bSearchWord.UseVisualStyleBackColor = true;
			this.bSearchWord.Click += new System.EventHandler(this.bSearchWord_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(9, 18);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 24);
			this.label2.TabIndex = 40;
			this.label2.Text = "Search word:";
			// 
			// ChooseVocabulary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1071, 554);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbSearchWord);
			this.Controls.Add(this.bSearchWord);
			this.Controls.Add(this.lbVocabulary);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ChooseVocabulary";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Vocabularies";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForChoosingDictionary_FormClosed);
			this.EnabledChanged += new System.EventHandler(this.FormForChoosingDictionary_EnabledChanged);
			this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
			this.VisibleChanged += new System.EventHandler(this.FormForChoosingDictionary_VisibleChanged);
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbVocabulary;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAVocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playAGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectingWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guessingWordsToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearchWord;
        private System.Windows.Forms.Button bSearchWord;
        private System.Windows.Forms.Label label2;
    }
}

