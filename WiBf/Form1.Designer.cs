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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button2 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(12, 69);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(173, 379);
			this.listBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(214, 436);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(177, 45);
			this.button1.TabIndex = 1;
			this.button1.Text = "Crack";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Wifi Bruteforce";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(211, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 181);
			this.label2.TabIndex = 3;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(18, 42);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(107, 13);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Devolped By Yattaze";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(214, 400);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(177, 30);
			this.button2.TabIndex = 5;
			this.button2.Text = "Wordlist Select";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(397, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(29, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(237, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Connection Check Delay (S)";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(12, 458);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(172, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "Rescan";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(439, 511);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
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

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button3;
	}
}

