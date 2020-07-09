namespace StudentInformation
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
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			this.showbt = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.deletebt = new System.Windows.Forms.Button();
			this.applybt = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.searchbt = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// showbt
			// 
			this.showbt.Location = new System.Drawing.Point(236, 491);
			this.showbt.Name = "showbt";
			this.showbt.Size = new System.Drawing.Size(75, 23);
			this.showbt.TabIndex = 4;
			this.showbt.Text = "Show";
			this.showbt.UseVisualStyleBackColor = true;
			this.showbt.Click += new System.EventHandler(this.Show);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 17);
			this.label1.TabIndex = 12;
			this.label1.Text = "NAME";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(241, 75);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(151, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(64, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 13;
			this.label2.Text = "SECTION";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(241, 101);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(151, 20);
			this.textBox2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(64, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 14;
			this.label3.Text = "EP NUMBER";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(241, 129);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(151, 20);
			this.textBox3.TabIndex = 2;
			// 
			// deletebt
			// 
			this.deletebt.Location = new System.Drawing.Point(317, 491);
			this.deletebt.Name = "deletebt";
			this.deletebt.Size = new System.Drawing.Size(75, 23);
			this.deletebt.TabIndex = 6;
			this.deletebt.Text = "Delete";
			this.deletebt.UseVisualStyleBackColor = true;
			this.deletebt.Click += new System.EventHandler(this.DeleteSQLData);
			// 
			// applybt
			// 
			this.applybt.Location = new System.Drawing.Point(155, 491);
			this.applybt.Name = "applybt";
			this.applybt.Size = new System.Drawing.Size(75, 23);
			this.applybt.TabIndex = 3;
			this.applybt.Text = "Apply";
			this.applybt.UseVisualStyleBackColor = true;
			this.applybt.Click += new System.EventHandler(this.Apply);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(47, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(305, 18);
			this.label4.TabIndex = 10;
			this.label4.Text = "FIRST YEAR STUDENT INFORMATION";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(307, 47);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(84, 20);
			this.numericUpDown1.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(65, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(169, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "NUMBER OF STUDENTS";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"EP NUMBER",
			"NAME",
			"SECTION"});
			this.comboBox1.Location = new System.Drawing.Point(190, 421);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.Sorted = true;
			this.comboBox1.TabIndex = 8;
			this.comboBox1.Tag = "";
			// 
			// searchbt
			// 
			this.searchbt.Location = new System.Drawing.Point(317, 419);
			this.searchbt.Name = "searchbt";
			this.searchbt.Size = new System.Drawing.Size(75, 23);
			this.searchbt.TabIndex = 9;
			this.searchbt.Text = "Search";
			this.searchbt.UseVisualStyleBackColor = true;
			this.searchbt.Click += new System.EventHandler(this.Searching);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(63, 422);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(120, 20);
			this.textBox4.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 491);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "generate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.GenerateRandomData);
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.DarkGray;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader3,
			this.columnHeader4});
			listViewGroup3.Header = "ListViewGroup";
			listViewGroup3.Name = "listViewGroup1";
			listViewGroup3.Tag = "group";
			listViewGroup4.Header = "ListViewGroup";
			listViewGroup4.Name = "listViewGroup2";
			listViewGroup4.Tag = "group2";
			this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
			listViewGroup3,
			listViewGroup4});
			this.listView1.Location = new System.Drawing.Point(29, 174);
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.Size = new System.Drawing.Size(363, 230);
			this.listView1.TabIndex = 15;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Sorting);
			this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DeleteRow);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "NAME";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "SECTION";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "EP NUMBER";
			this.columnHeader4.Width = 108;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(423, 538);
			this.Controls.Add(this.deletebt);
			this.Controls.Add(this.showbt);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.applybt);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.searchbt);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "STUDENT DETAILS";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button showbt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button deletebt;
		private System.Windows.Forms.Button applybt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button searchbt;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
	}
}

