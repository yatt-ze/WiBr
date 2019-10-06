namespace WiBf
{
	partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AccessPointsListBox = new System.Windows.Forms.ListBox();
            this.CrackButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.LinkLabel();
            this.WordlistButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectionCheckDelayTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionCheckDelayLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RescanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccessPointsListBox
            // 
            this.AccessPointsListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.AccessPointsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessPointsListBox.FormattingEnabled = true;
            this.AccessPointsListBox.ItemHeight = 15;
            this.AccessPointsListBox.Location = new System.Drawing.Point(12, 69);
            this.AccessPointsListBox.Name = "AccessPointsListBox";
            this.AccessPointsListBox.Size = new System.Drawing.Size(173, 379);
            this.AccessPointsListBox.TabIndex = 0;
            // 
            // CrackButton
            // 
            this.CrackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrackButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrackButton.Location = new System.Drawing.Point(214, 436);
            this.CrackButton.Name = "CrackButton";
            this.CrackButton.Size = new System.Drawing.Size(177, 45);
            this.CrackButton.TabIndex = 1;
            this.CrackButton.Text = "Crack";
            this.CrackButton.UseVisualStyleBackColor = true;
            this.CrackButton.Click += new System.EventHandler(this.CrackButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(13, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(142, 25);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "WiFi Bruteforce";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(211, 145);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(180, 181);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Location = new System.Drawing.Point(18, 42);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(113, 13);
            this.GitHubLabel.TabIndex = 4;
            this.GitHubLabel.TabStop = true;
            this.GitHubLabel.Text = "Developed By Yattaze";
            this.GitHubLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLabel_LinkClicked);
            // 
            // WordlistButton
            // 
            this.WordlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordlistButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordlistButton.Location = new System.Drawing.Point(214, 400);
            this.WordlistButton.Name = "WordlistButton";
            this.WordlistButton.Size = new System.Drawing.Size(177, 30);
            this.WordlistButton.TabIndex = 5;
            this.WordlistButton.Text = "Wordlist Select";
            this.WordlistButton.UseVisualStyleBackColor = true;
            this.WordlistButton.Click += new System.EventHandler(this.WordlistButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // ConnectionCheckDelayTextBox
            // 
            this.ConnectionCheckDelayTextBox.Location = new System.Drawing.Point(397, 12);
            this.ConnectionCheckDelayTextBox.Name = "ConnectionCheckDelayTextBox";
            this.ConnectionCheckDelayTextBox.Size = new System.Drawing.Size(29, 20);
            this.ConnectionCheckDelayTextBox.TabIndex = 7;
            this.ConnectionCheckDelayTextBox.Text = "5";
            // 
            // ConnectionCheckDelayLabel
            // 
            this.ConnectionCheckDelayLabel.AutoSize = true;
            this.ConnectionCheckDelayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionCheckDelayLabel.Location = new System.Drawing.Point(237, 14);
            this.ConnectionCheckDelayLabel.Name = "ConnectionCheckDelayLabel";
            this.ConnectionCheckDelayLabel.Size = new System.Drawing.Size(154, 15);
            this.ConnectionCheckDelayLabel.TabIndex = 8;
            this.ConnectionCheckDelayLabel.Text = "Connection Check Delay (S)";
            // 
            // RescanButton
            // 
            this.RescanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RescanButton.Location = new System.Drawing.Point(12, 458);
            this.RescanButton.Name = "RescanButton";
            this.RescanButton.Size = new System.Drawing.Size(172, 23);
            this.RescanButton.TabIndex = 9;
            this.RescanButton.Text = "Rescan";
            this.RescanButton.UseVisualStyleBackColor = true;
            this.RescanButton.Click += new System.EventHandler(this.RescanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(439, 511);
            this.Controls.Add(this.RescanButton);
            this.Controls.Add(this.ConnectionCheckDelayLabel);
            this.Controls.Add(this.ConnectionCheckDelayTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WordlistButton);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CrackButton);
            this.Controls.Add(this.AccessPointsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WiBr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox AccessPointsListBox;
		private System.Windows.Forms.Button CrackButton;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label DescriptionLabel;
		private System.Windows.Forms.LinkLabel GitHubLabel;
		private System.Windows.Forms.Button WordlistButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ConnectionCheckDelayTextBox;
		private System.Windows.Forms.Label ConnectionCheckDelayLabel;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button RescanButton;
	}
}

