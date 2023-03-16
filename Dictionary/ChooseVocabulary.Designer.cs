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
            this.bSearchDictionary = new System.Windows.Forms.Button();
            this.tbSearchDictionary = new System.Windows.Forms.TextBox();
            this.tbSearchWord = new System.Windows.Forms.TextBox();
            this.bSearchWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbVocabulary.ItemHeight = 25;
            this.lbVocabulary.Items.AddRange(new object[] {
            ""});
            this.lbVocabulary.Location = new System.Drawing.Point(3, 43);
            this.lbVocabulary.Name = "lbVocabulary";
            this.lbVocabulary.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbVocabulary.Size = new System.Drawing.Size(796, 404);
            this.lbVocabulary.TabIndex = 15;
            this.lbVocabulary.TabStop = false;
            this.lbVocabulary.SelectedIndexChanged += new System.EventHandler(this.lbDictionary_SelectedIndexChanged);
            this.lbVocabulary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbDictionary_KeyDown);
            this.lbVocabulary.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbDictionary_MouseDoubleClick);
            this.lbVocabulary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDictionary_MouseDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.playAGameToolStripMenuItem,
            this.addAVocabularyToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(167, 92);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DelateToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Enabled = false;
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
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
            this.playAGameToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.playAGameToolStripMenuItem.Text = "Play games";
            // 
            // connectingWordsToolStripMenuItem
            // 
            this.connectingWordsToolStripMenuItem.Name = "connectingWordsToolStripMenuItem";
            this.connectingWordsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.connectingWordsToolStripMenuItem.Text = "Connecting words";
            this.connectingWordsToolStripMenuItem.Click += new System.EventHandler(this.connectingWordsToolStripMenuItem_Click);
            // 
            // guessingWordsToolStripMenuItem
            // 
            this.guessingWordsToolStripMenuItem.Name = "guessingWordsToolStripMenuItem";
            this.guessingWordsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.guessingWordsToolStripMenuItem.Text = "Guessing words";
            this.guessingWordsToolStripMenuItem.Click += new System.EventHandler(this.guessingWordsToolStripMenuItem_Click);
            // 
            // addAVocabularyToolStripMenuItem
            // 
            this.addAVocabularyToolStripMenuItem.Name = "addAVocabularyToolStripMenuItem";
            this.addAVocabularyToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addAVocabularyToolStripMenuItem.Text = "Add a vocabulary";
            this.addAVocabularyToolStripMenuItem.Click += new System.EventHandler(this.addAVocabularyToolStripMenuItem_Click);
            // 
            // bSearchDictionary
            // 
            this.bSearchDictionary.Location = new System.Drawing.Point(314, 10);
            this.bSearchDictionary.Name = "bSearchDictionary";
            this.bSearchDictionary.Size = new System.Drawing.Size(75, 23);
            this.bSearchDictionary.TabIndex = 21;
            this.bSearchDictionary.TabStop = false;
            this.bSearchDictionary.Text = "Search";
            this.bSearchDictionary.UseVisualStyleBackColor = true;
            this.bSearchDictionary.Click += new System.EventHandler(this.bSearchDictionary_Click);
            // 
            // tbSearchDictionary
            // 
            this.tbSearchDictionary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbSearchDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchDictionary.Location = new System.Drawing.Point(140, 8);
            this.tbSearchDictionary.Name = "tbSearchDictionary";
            this.tbSearchDictionary.Size = new System.Drawing.Size(168, 26);
            this.tbSearchDictionary.TabIndex = 36;
            this.tbSearchDictionary.Click += new System.EventHandler(this.tbSearchDictionary_Click);
            this.tbSearchDictionary.TextChanged += new System.EventHandler(this.tbSearchDictionary_TextChanged);
            this.tbSearchDictionary.Enter += new System.EventHandler(this.tbSearchDictionary_Enter);
            // 
            // tbSearchWord
            // 
            this.tbSearchWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbSearchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchWord.Location = new System.Drawing.Point(544, 8);
            this.tbSearchWord.Name = "tbSearchWord";
            this.tbSearchWord.Size = new System.Drawing.Size(168, 26);
            this.tbSearchWord.TabIndex = 38;
            this.tbSearchWord.Click += new System.EventHandler(this.tbSearchDictionary_Click);
            this.tbSearchWord.Enter += new System.EventHandler(this.tbSearchDictionary_Enter);
            // 
            // bSearchWord
            // 
            this.bSearchWord.Location = new System.Drawing.Point(718, 10);
            this.bSearchWord.Name = "bSearchWord";
            this.bSearchWord.Size = new System.Drawing.Size(75, 23);
            this.bSearchWord.TabIndex = 37;
            this.bSearchWord.TabStop = false;
            this.bSearchWord.Text = "Search";
            this.bSearchWord.UseVisualStyleBackColor = true;
            this.bSearchWord.Click += new System.EventHandler(this.bSearchWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Search dictionary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(446, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Search word:";
            // 
            // ChooseDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchWord);
            this.Controls.Add(this.bSearchWord);
            this.Controls.Add(this.tbSearchDictionary);
            this.Controls.Add(this.bSearchDictionary);
            this.Controls.Add(this.lbVocabulary);
            this.KeyPreview = true;
            this.Name = "ChooseDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vocabularies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormForChoosingDictionary_FormClosed);
            this.EnabledChanged += new System.EventHandler(this.FormForChoosingDictionary_EnabledChanged);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.VisibleChanged += new System.EventHandler(this.FormForChoosingDictionary_VisibleChanged);
            this.Click += new System.EventHandler(this.tbSearchDictionary_Click);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbVocabulary;
        private System.Windows.Forms.Button bSearchDictionary;
        private System.Windows.Forms.TextBox tbSearchDictionary;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAVocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playAGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectingWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guessingWordsToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearchWord;
        private System.Windows.Forms.Button bSearchWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

