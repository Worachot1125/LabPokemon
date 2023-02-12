namespace Pokemon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNidoran = new System.Windows.Forms.Button();
            this.btnOddish = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWartortle = new System.Windows.Forms.Button();
            this.btnCharmander = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMypkname = new System.Windows.Forms.TextBox();
            this.tbMypkHP = new System.Windows.Forms.TextBox();
            this.btnPlusHP50 = new System.Windows.Forms.Button();
            this.btnAtk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picArbok = new System.Windows.Forms.PictureBox();
            this.tbMonsHP = new System.Windows.Forms.TextBox();
            this.tbMonsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNidoran
            // 
            this.btnNidoran.Location = new System.Drawing.Point(74, 58);
            this.btnNidoran.Name = "btnNidoran";
            this.btnNidoran.Size = new System.Drawing.Size(113, 29);
            this.btnNidoran.TabIndex = 4;
            this.btnNidoran.Text = "Nidoran";
            this.btnNidoran.UseVisualStyleBackColor = true;
            this.btnNidoran.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOddish
            // 
            this.btnOddish.Location = new System.Drawing.Point(72, 163);
            this.btnOddish.Name = "btnOddish";
            this.btnOddish.Size = new System.Drawing.Size(113, 29);
            this.btnOddish.TabIndex = 7;
            this.btnOddish.Text = "Oddish";
            this.btnOddish.UseVisualStyleBackColor = true;
            this.btnOddish.Click += new System.EventHandler(this.btMyPok4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWartortle);
            this.groupBox1.Controls.Add(this.btnCharmander);
            this.groupBox1.Location = new System.Drawing.Point(63, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Pokemon";
            // 
            // btnWartortle
            // 
            this.btnWartortle.Location = new System.Drawing.Point(10, 103);
            this.btnWartortle.Name = "btnWartortle";
            this.btnWartortle.Size = new System.Drawing.Size(113, 29);
            this.btnWartortle.TabIndex = 27;
            this.btnWartortle.Text = "Wartortle";
            this.btnWartortle.UseVisualStyleBackColor = true;
            this.btnWartortle.Click += new System.EventHandler(this.btMyPok3_Click);
            // 
            // btnCharmander
            // 
            this.btnCharmander.Location = new System.Drawing.Point(11, 68);
            this.btnCharmander.Name = "btnCharmander";
            this.btnCharmander.Size = new System.Drawing.Size(113, 29);
            this.btnCharmander.TabIndex = 26;
            this.btnCharmander.Text = "Charmander";
            this.btnCharmander.UseVisualStyleBackColor = true;
            this.btnCharmander.Click += new System.EventHandler(this.btMyPok2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "HP";
            // 
            // tbMypkname
            // 
            this.tbMypkname.Location = new System.Drawing.Point(99, 224);
            this.tbMypkname.Name = "tbMypkname";
            this.tbMypkname.Size = new System.Drawing.Size(125, 27);
            this.tbMypkname.TabIndex = 11;
            // 
            // tbMypkHP
            // 
            this.tbMypkHP.Location = new System.Drawing.Point(99, 257);
            this.tbMypkHP.Name = "tbMypkHP";
            this.tbMypkHP.Size = new System.Drawing.Size(125, 27);
            this.tbMypkHP.TabIndex = 12;
            // 
            // btnPlusHP50
            // 
            this.btnPlusHP50.Location = new System.Drawing.Point(535, 381);
            this.btnPlusHP50.Name = "btnPlusHP50";
            this.btnPlusHP50.Size = new System.Drawing.Size(94, 29);
            this.btnPlusHP50.TabIndex = 14;
            this.btnPlusHP50.Text = "HP + 50";
            this.btnPlusHP50.UseVisualStyleBackColor = true;
            this.btnPlusHP50.Click += new System.EventHandler(this.btPlusHP_Click);
            // 
            // btnAtk
            // 
            this.btnAtk.Location = new System.Drawing.Point(535, 346);
            this.btnAtk.Name = "btnAtk";
            this.btnAtk.Size = new System.Drawing.Size(94, 29);
            this.btnAtk.TabIndex = 13;
            this.btnAtk.Text = "Attack";
            this.btnAtk.UseVisualStyleBackColor = true;
            this.btnAtk.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(511, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 101);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pokemon.Properties.Resources._771102;
            this.pictureBox1.Location = new System.Drawing.Point(17, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // picArbok
            // 
            this.picArbok.Image = global::Pokemon.Properties.Resources.Arbok;
            this.picArbok.Location = new System.Drawing.Point(511, 12);
            this.picArbok.Name = "picArbok";
            this.picArbok.Size = new System.Drawing.Size(174, 184);
            this.picArbok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArbok.TabIndex = 21;
            this.picArbok.TabStop = false;
            // 
            // tbMonsHP
            // 
            this.tbMonsHP.Location = new System.Drawing.Point(535, 252);
            this.tbMonsHP.Name = "tbMonsHP";
            this.tbMonsHP.Size = new System.Drawing.Size(125, 27);
            this.tbMonsHP.TabIndex = 25;
            // 
            // tbMonsName
            // 
            this.tbMonsName.Location = new System.Drawing.Point(535, 219);
            this.tbMonsName.Name = "tbMonsName";
            this.tbMonsName.Size = new System.Drawing.Size(125, 27);
            this.tbMonsName.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokemon.Properties.Resources._1033673;
            this.ClientSize = new System.Drawing.Size(713, 489);
            this.Controls.Add(this.tbMonsHP);
            this.Controls.Add(this.tbMonsName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picArbok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlusHP50);
            this.Controls.Add(this.btnAtk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbMypkHP);
            this.Controls.Add(this.tbMypkname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOddish);
            this.Controls.Add(this.btnNidoran);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnNidoran;
        private Button btnOddish;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox tbMypkname;
        private TextBox tbMypkHP;
        private Button btnPlusHP50;
        private Button btnAtk;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private PictureBox picArbok;
        private TextBox tbMonsHP;
        private TextBox tbMonsName;
        private Label label3;
        private Label label4;
        private Button btnWartortle;
        private Button btnCharmander;
    }
}