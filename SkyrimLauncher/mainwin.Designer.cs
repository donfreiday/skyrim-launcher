namespace SkyrimLauncher
{
    partial class mainwin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwin));
            this.playButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.fileLocationTextbox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.coreListBox = new System.Windows.Forms.CheckedListBox();
            this.addFavoriteButton = new System.Windows.Forms.Button();
            this.favoritesListBox = new System.Windows.Forms.ListBox();
            this.deleteFavoriteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(319, 369);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(347, 71);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Launch EXE";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Black;
            this.statusLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Lime;
            this.statusLabel.Location = new System.Drawing.Point(188, 449);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(57, 22);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Ready.";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.BackColor = System.Drawing.Color.Black;
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.priorityComboBox.ForeColor = System.Drawing.Color.Lime;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "Normal Priority",
            "High Priority",
            "Realtime Priority"});
            this.priorityComboBox.Location = new System.Drawing.Point(18, 446);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(164, 30);
            this.priorityComboBox.TabIndex = 3;
            // 
            // fileLocationTextbox
            // 
            this.fileLocationTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.fileLocationTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.fileLocationTextbox.BackColor = System.Drawing.Color.Black;
            this.fileLocationTextbox.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLocationTextbox.ForeColor = System.Drawing.Color.Lime;
            this.fileLocationTextbox.Location = new System.Drawing.Point(120, 25);
            this.fileLocationTextbox.Name = "fileLocationTextbox";
            this.fileLocationTextbox.Size = new System.Drawing.Size(578, 28);
            this.fileLocationTextbox.TabIndex = 4;
            this.fileLocationTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileLocationTextbox.TextChanged += new System.EventHandler(this.fileLocationTextbox_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.browseButton.ForeColor = System.Drawing.Color.Black;
            this.browseButton.Location = new System.Drawing.Point(704, 25);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(84, 29);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // coreListBox
            // 
            this.coreListBox.BackColor = System.Drawing.Color.Black;
            this.coreListBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.coreListBox.ForeColor = System.Drawing.Color.Lime;
            this.coreListBox.FormattingEnabled = true;
            this.coreListBox.Location = new System.Drawing.Point(18, 340);
            this.coreListBox.MultiColumn = true;
            this.coreListBox.Name = "coreListBox";
            this.coreListBox.Size = new System.Drawing.Size(265, 100);
            this.coreListBox.TabIndex = 2;
            // 
            // addFavoriteButton
            // 
            this.addFavoriteButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.addFavoriteButton.ForeColor = System.Drawing.Color.Black;
            this.addFavoriteButton.Location = new System.Drawing.Point(16, 24);
            this.addFavoriteButton.Name = "addFavoriteButton";
            this.addFavoriteButton.Size = new System.Drawing.Size(48, 29);
            this.addFavoriteButton.TabIndex = 5;
            this.addFavoriteButton.Text = "Add";
            this.addFavoriteButton.UseVisualStyleBackColor = true;
            this.addFavoriteButton.Click += new System.EventHandler(this.addFavoriteButton_Click);
            // 
            // favoritesListBox
            // 
            this.favoritesListBox.BackColor = System.Drawing.Color.Black;
            this.favoritesListBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.favoritesListBox.ForeColor = System.Drawing.Color.Lime;
            this.favoritesListBox.FormattingEnabled = true;
            this.favoritesListBox.ItemHeight = 22;
            this.favoritesListBox.Location = new System.Drawing.Point(6, 61);
            this.favoritesListBox.Name = "favoritesListBox";
            this.favoritesListBox.Size = new System.Drawing.Size(782, 268);
            this.favoritesListBox.TabIndex = 0;
            this.favoritesListBox.SelectedIndexChanged += new System.EventHandler(this.favoritesListBox_SelectedIndexChanged);
            // 
            // deleteFavoriteButton
            // 
            this.deleteFavoriteButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.deleteFavoriteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteFavoriteButton.Location = new System.Drawing.Point(70, 24);
            this.deleteFavoriteButton.Name = "deleteFavoriteButton";
            this.deleteFavoriteButton.Size = new System.Drawing.Size(43, 28);
            this.deleteFavoriteButton.TabIndex = 6;
            this.deleteFavoriteButton.Text = "Del";
            this.deleteFavoriteButton.UseVisualStyleBackColor = true;
            this.deleteFavoriteButton.Click += new System.EventHandler(this.deleteFavoriteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.deleteFavoriteButton);
            this.groupBox1.Controls.Add(this.favoritesListBox);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.addFavoriteButton);
            this.groupBox1.Controls.Add(this.fileLocationTextbox);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Favorites";
            // 
            // iconBox
            // 
            this.iconBox.Location = new System.Drawing.Point(687, 353);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(116, 101);
            this.iconBox.TabIndex = 11;
            this.iconBox.TabStop = false;
            // 
            // mainwin
            // 
            this.AcceptButton = this.playButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(815, 482);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.coreListBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.playButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainwin";
            this.Text = "EXE Launcher v0.9";
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainwin_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.TextBox fileLocationTextbox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.CheckedListBox coreListBox;
        private System.Windows.Forms.Button addFavoriteButton;
        private System.Windows.Forms.ListBox favoritesListBox;
        private System.Windows.Forms.Button deleteFavoriteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox iconBox;
    }
}

