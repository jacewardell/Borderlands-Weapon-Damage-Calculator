namespace WindowsFormsApplication1
{
	partial class View
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
			this.calculate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.elementLab = new System.Windows.Forms.Label();
			this.elemChoice1 = new System.Windows.Forms.ComboBox();
			this.elemMultLab = new System.Windows.Forms.Label();
			this.weapDam1 = new System.Windows.Forms.TextBox();
			this.elemMult1 = new System.Windows.Forms.TextBox();
			this.weapTypeLab = new System.Windows.Forms.Label();
			this.weapType1 = new System.Windows.Forms.ComboBox();
			this.totalLab = new System.Windows.Forms.Label();
			this.total1 = new System.Windows.Forms.TextBox();
			this.procChanceLab = new System.Windows.Forms.Label();
			this.procChanceBox1 = new System.Windows.Forms.TextBox();
			this.averageLab = new System.Windows.Forms.Label();
			this.averageDam1 = new System.Windows.Forms.TextBox();
			this.weapon1 = new System.Windows.Forms.Label();
			this.elemChoice2 = new System.Windows.Forms.ComboBox();
			this.weapType2 = new System.Windows.Forms.ComboBox();
			this.weapDam2 = new System.Windows.Forms.TextBox();
			this.total2 = new System.Windows.Forms.TextBox();
			this.averageDam2 = new System.Windows.Forms.TextBox();
			this.procChanceBox2 = new System.Windows.Forms.TextBox();
			this.elemMult2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(345, 369);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(103, 39);
			this.calculate.TabIndex = 8;
			this.calculate.Text = "Calculate";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Weapon Damage";
			// 
			// elementLab
			// 
			this.elementLab.AutoSize = true;
			this.elementLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elementLab.Location = new System.Drawing.Point(15, 140);
			this.elementLab.Name = "elementLab";
			this.elementLab.Size = new System.Drawing.Size(59, 17);
			this.elementLab.TabIndex = 3;
			this.elementLab.Text = "Element";
			// 
			// elemChoice1
			// 
			this.elemChoice1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.elemChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elemChoice1.FormattingEnabled = true;
			this.elemChoice1.Items.AddRange(new object[] {
            "None",
            "Incendiary",
            "Shock",
            "Explosive",
            "Corrosive"});
			this.elemChoice1.Location = new System.Drawing.Point(216, 137);
			this.elemChoice1.Name = "elemChoice1";
			this.elemChoice1.Size = new System.Drawing.Size(146, 24);
			this.elemChoice1.TabIndex = 4;
			this.elemChoice1.SelectedIndexChanged += new System.EventHandler(this.elemChoice1_SelectedIndexChanged);
			// 
			// elemMultLab
			// 
			this.elemMultLab.AutoSize = true;
			this.elemMultLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elemMultLab.Location = new System.Drawing.Point(15, 179);
			this.elemMultLab.Name = "elemMultLab";
			this.elemMultLab.Size = new System.Drawing.Size(115, 17);
			this.elemMultLab.TabIndex = 3;
			this.elemMultLab.Text = "Element Muliplier";
			// 
			// weapDam1
			// 
			this.weapDam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weapDam1.Location = new System.Drawing.Point(216, 99);
			this.weapDam1.Name = "weapDam1";
			this.weapDam1.Size = new System.Drawing.Size(146, 23);
			this.weapDam1.TabIndex = 2;
			// 
			// elemMult1
			// 
			this.elemMult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elemMult1.Location = new System.Drawing.Point(216, 176);
			this.elemMult1.Name = "elemMult1";
			this.elemMult1.Size = new System.Drawing.Size(146, 23);
			this.elemMult1.TabIndex = 6;
			this.elemMult1.Leave += new System.EventHandler(this.elemMult1_Leave);
			// 
			// weapTypeLab
			// 
			this.weapTypeLab.AutoSize = true;
			this.weapTypeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weapTypeLab.Location = new System.Drawing.Point(12, 63);
			this.weapTypeLab.Name = "weapTypeLab";
			this.weapTypeLab.Size = new System.Drawing.Size(97, 17);
			this.weapTypeLab.TabIndex = 2;
			this.weapTypeLab.Text = "Weapon Type";
			// 
			// weapType1
			// 
			this.weapType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.weapType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weapType1.FormattingEnabled = true;
			this.weapType1.Items.AddRange(new object[] {
            "Assault Rifle",
            "Repeater",
            "Revolver",
            "Rocket Launcher",
            "Shotgun",
            "SMG",
            "Sniper Rifle"});
			this.weapType1.Location = new System.Drawing.Point(216, 60);
			this.weapType1.Name = "weapType1";
			this.weapType1.Size = new System.Drawing.Size(146, 24);
			this.weapType1.TabIndex = 0;
			// 
			// totalLab
			// 
			this.totalLab.AutoSize = true;
			this.totalLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalLab.Location = new System.Drawing.Point(15, 217);
			this.totalLab.Name = "totalLab";
			this.totalLab.Size = new System.Drawing.Size(97, 17);
			this.totalLab.TabIndex = 2;
			this.totalLab.Text = "Total Damage";
			// 
			// total1
			// 
			this.total1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total1.Location = new System.Drawing.Point(216, 214);
			this.total1.Name = "total1";
			this.total1.ReadOnly = true;
			this.total1.Size = new System.Drawing.Size(146, 23);
			this.total1.TabIndex = 5;
			// 
			// procChanceLab
			// 
			this.procChanceLab.AutoSize = true;
			this.procChanceLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.procChanceLab.Location = new System.Drawing.Point(15, 255);
			this.procChanceLab.Name = "procChanceLab";
			this.procChanceLab.Size = new System.Drawing.Size(89, 17);
			this.procChanceLab.TabIndex = 6;
			this.procChanceLab.Text = "Proc Chance";
			// 
			// procChanceBox1
			// 
			this.procChanceBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.procChanceBox1.Location = new System.Drawing.Point(216, 252);
			this.procChanceBox1.Name = "procChanceBox1";
			this.procChanceBox1.ReadOnly = true;
			this.procChanceBox1.Size = new System.Drawing.Size(146, 23);
			this.procChanceBox1.TabIndex = 5;
			// 
			// averageLab
			// 
			this.averageLab.AutoSize = true;
			this.averageLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.averageLab.Location = new System.Drawing.Point(15, 322);
			this.averageLab.Name = "averageLab";
			this.averageLab.Size = new System.Drawing.Size(118, 17);
			this.averageLab.TabIndex = 2;
			this.averageLab.Text = "Average Damage";
			// 
			// averageDam1
			// 
			this.averageDam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.averageDam1.Location = new System.Drawing.Point(216, 319);
			this.averageDam1.Name = "averageDam1";
			this.averageDam1.ReadOnly = true;
			this.averageDam1.Size = new System.Drawing.Size(146, 23);
			this.averageDam1.TabIndex = 5;
			// 
			// weapon1
			// 
			this.weapon1.AutoSize = true;
			this.weapon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weapon1.Location = new System.Drawing.Point(246, 29);
			this.weapon1.Name = "weapon1";
			this.weapon1.Size = new System.Drawing.Size(84, 18);
			this.weapon1.TabIndex = 7;
			this.weapon1.Text = "Weapon #1";
			// 
			// elemChoice2
			// 
			this.elemChoice2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.elemChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elemChoice2.FormattingEnabled = true;
			this.elemChoice2.Items.AddRange(new object[] {
            "None",
            "Incendiary",
            "Shock",
            "Explosive",
            "Corrosive"});
			this.elemChoice2.Location = new System.Drawing.Point(420, 137);
			this.elemChoice2.Name = "elemChoice2";
			this.elemChoice2.Size = new System.Drawing.Size(146, 24);
			this.elemChoice2.TabIndex = 5;
			this.elemChoice2.SelectedIndexChanged += new System.EventHandler(this.elemChoice2_SelectedIndexChanged);
			// 
			// weapType2
			// 
			this.weapType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.weapType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weapType2.FormattingEnabled = true;
			this.weapType2.Items.AddRange(new object[] {
            "Assault Rifle",
            "Repeater",
            "Revolver",
            "Rocket Launcher",
            "Shotgun",
            "SMG",
            "Sniper Rifle"});
			this.weapType2.Location = new System.Drawing.Point(420, 60);
			this.weapType2.Name = "weapType2";
			this.weapType2.Size = new System.Drawing.Size(146, 24);
			this.weapType2.TabIndex = 1;
			// 
			// weapDam2
			// 
			this.weapDam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weapDam2.Location = new System.Drawing.Point(420, 99);
			this.weapDam2.Name = "weapDam2";
			this.weapDam2.Size = new System.Drawing.Size(146, 23);
			this.weapDam2.TabIndex = 3;
			// 
			// total2
			// 
			this.total2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total2.Location = new System.Drawing.Point(420, 214);
			this.total2.Name = "total2";
			this.total2.ReadOnly = true;
			this.total2.Size = new System.Drawing.Size(146, 23);
			this.total2.TabIndex = 5;
			// 
			// averageDam2
			// 
			this.averageDam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.averageDam2.Location = new System.Drawing.Point(420, 319);
			this.averageDam2.Name = "averageDam2";
			this.averageDam2.ReadOnly = true;
			this.averageDam2.Size = new System.Drawing.Size(146, 23);
			this.averageDam2.TabIndex = 5;
			// 
			// procChanceBox2
			// 
			this.procChanceBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.procChanceBox2.Location = new System.Drawing.Point(420, 252);
			this.procChanceBox2.Name = "procChanceBox2";
			this.procChanceBox2.ReadOnly = true;
			this.procChanceBox2.Size = new System.Drawing.Size(146, 23);
			this.procChanceBox2.TabIndex = 5;
			// 
			// elemMult2
			// 
			this.elemMult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elemMult2.Location = new System.Drawing.Point(420, 176);
			this.elemMult2.Name = "elemMult2";
			this.elemMult2.Size = new System.Drawing.Size(146, 23);
			this.elemMult2.TabIndex = 7;
			this.elemMult2.Leave += new System.EventHandler(this.elemMult2_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(453, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Weapon #2";
			// 
			// View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 420);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.weapon1);
			this.Controls.Add(this.procChanceLab);
			this.Controls.Add(this.elemMult2);
			this.Controls.Add(this.elemMult1);
			this.Controls.Add(this.procChanceBox2);
			this.Controls.Add(this.procChanceBox1);
			this.Controls.Add(this.averageDam2);
			this.Controls.Add(this.averageDam1);
			this.Controls.Add(this.total2);
			this.Controls.Add(this.total1);
			this.Controls.Add(this.weapDam2);
			this.Controls.Add(this.weapDam1);
			this.Controls.Add(this.weapType2);
			this.Controls.Add(this.elemChoice2);
			this.Controls.Add(this.weapType1);
			this.Controls.Add(this.elemChoice1);
			this.Controls.Add(this.elemMultLab);
			this.Controls.Add(this.elementLab);
			this.Controls.Add(this.averageLab);
			this.Controls.Add(this.weapTypeLab);
			this.Controls.Add(this.totalLab);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.calculate);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "View";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Damage Calculator";
			this.Load += new System.EventHandler(this.View_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label elementLab;
		private System.Windows.Forms.ComboBox elemChoice1;
		private System.Windows.Forms.Label elemMultLab;
		private System.Windows.Forms.TextBox weapDam1;
		private System.Windows.Forms.TextBox elemMult1;
		private System.Windows.Forms.Label weapTypeLab;
		private System.Windows.Forms.ComboBox weapType1;
		private System.Windows.Forms.Label totalLab;
		private System.Windows.Forms.TextBox total1;
		private System.Windows.Forms.Label procChanceLab;
		private System.Windows.Forms.TextBox procChanceBox1;
		private System.Windows.Forms.Label averageLab;
		private System.Windows.Forms.TextBox averageDam1;
		private System.Windows.Forms.Label weapon1;
		private System.Windows.Forms.ComboBox elemChoice2;
		private System.Windows.Forms.ComboBox weapType2;
		private System.Windows.Forms.TextBox weapDam2;
		private System.Windows.Forms.TextBox total2;
		private System.Windows.Forms.TextBox averageDam2;
		private System.Windows.Forms.TextBox procChanceBox2;
		private System.Windows.Forms.TextBox elemMult2;
		private System.Windows.Forms.Label label2;
	}
}

