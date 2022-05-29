namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.A_star = new System.Windows.Forms.RadioButton();
            this.bfs = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.file_name = new System.Windows.Forms.TextBox();
            this.hamming = new System.Windows.Forms.RadioButton();
            this.manhattan = new System.Windows.Forms.RadioButton();
            this.algorithm = new System.Windows.Forms.GroupBox();
            this.heurestic = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.TextBox();
            this.sec = new System.Windows.Forms.TextBox();
            this.millisec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.moves = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.solvable = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.blank = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.solve = new System.Windows.Forms.Button();
            this.algorithm.SuspendLayout();
            this.heurestic.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "show solution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // A_star
            // 
            this.A_star.AutoSize = true;
            this.A_star.Location = new System.Drawing.Point(59, 39);
            this.A_star.Name = "A_star";
            this.A_star.Size = new System.Drawing.Size(46, 24);
            this.A_star.TabIndex = 3;
            this.A_star.TabStop = true;
            this.A_star.Text = "A*";
            this.A_star.UseVisualStyleBackColor = true;
            // 
            // bfs
            // 
            this.bfs.AutoSize = true;
            this.bfs.Location = new System.Drawing.Point(59, 69);
            this.bfs.Name = "bfs";
            this.bfs.Size = new System.Drawing.Size(54, 24);
            this.bfs.TabIndex = 4;
            this.bfs.TabStop = true;
            this.bfs.Text = "BFS";
            this.bfs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "File Name";
            // 
            // file_name
            // 
            this.file_name.Location = new System.Drawing.Point(233, 67);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(221, 27);
            this.file_name.TabIndex = 8;
            // 
            // hamming
            // 
            this.hamming.AutoSize = true;
            this.hamming.Location = new System.Drawing.Point(53, 41);
            this.hamming.Name = "hamming";
            this.hamming.Size = new System.Drawing.Size(96, 24);
            this.hamming.TabIndex = 9;
            this.hamming.TabStop = true;
            this.hamming.Text = "Hamming";
            this.hamming.UseVisualStyleBackColor = true;
            // 
            // manhattan
            // 
            this.manhattan.AutoSize = true;
            this.manhattan.Location = new System.Drawing.Point(53, 80);
            this.manhattan.Name = "manhattan";
            this.manhattan.Size = new System.Drawing.Size(101, 24);
            this.manhattan.TabIndex = 10;
            this.manhattan.TabStop = true;
            this.manhattan.Text = "Manhattan";
            this.manhattan.UseVisualStyleBackColor = true;
            // 
            // algorithm
            // 
            this.algorithm.Controls.Add(this.A_star);
            this.algorithm.Controls.Add(this.bfs);
            this.algorithm.Location = new System.Drawing.Point(543, 67);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(182, 120);
            this.algorithm.TabIndex = 11;
            this.algorithm.TabStop = false;
            this.algorithm.Text = "Algorithm";
            // 
            // heurestic
            // 
            this.heurestic.Controls.Add(this.hamming);
            this.heurestic.Controls.Add(this.manhattan);
            this.heurestic.Location = new System.Drawing.Point(731, 67);
            this.heurestic.Name = "heurestic";
            this.heurestic.Size = new System.Drawing.Size(194, 118);
            this.heurestic.TabIndex = 5;
            this.heurestic.TabStop = false;
            this.heurestic.Text = "Heurestic Function";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Solvable/Not Solvable";
            // 
            // minute
            // 
            this.minute.Location = new System.Drawing.Point(731, 282);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(125, 27);
            this.minute.TabIndex = 14;
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(731, 339);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(125, 27);
            this.sec.TabIndex = 15;
            // 
            // millisec
            // 
            this.millisec.Location = new System.Drawing.Point(731, 404);
            this.millisec.Name = "millisec";
            this.millisec.Size = new System.Drawing.Size(125, 27);
            this.millisec.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Seconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Milliseconds";
            // 
            // moves
            // 
            this.moves.Location = new System.Drawing.Point(131, 640);
            this.moves.Name = "moves";
            this.moves.Size = new System.Drawing.Size(125, 27);
            this.moves.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 643);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Moves";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(614, 465);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(365, 148);
            this.path.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Path";
            // 
            // solvable
            // 
            this.solvable.Location = new System.Drawing.Point(233, 123);
            this.solvable.Name = "solvable";
            this.solvable.Size = new System.Drawing.Size(221, 27);
            this.solvable.TabIndex = 25;
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.one.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("one.BackgroundImage")));
            this.one.ForeColor = System.Drawing.SystemColors.Control;
            this.one.Location = new System.Drawing.Point(14, 14);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(85, 80);
            this.one.TabIndex = 26;
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("two.BackgroundImage")));
            this.two.Location = new System.Drawing.Point(116, 14);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(85, 80);
            this.two.TabIndex = 27;
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("three.BackgroundImage")));
            this.three.Location = new System.Drawing.Point(225, 14);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(85, 80);
            this.three.TabIndex = 28;
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("four.BackgroundImage")));
            this.four.Location = new System.Drawing.Point(14, 123);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(85, 80);
            this.four.TabIndex = 29;
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.five.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("five.BackgroundImage")));
            this.five.ForeColor = System.Drawing.SystemColors.Control;
            this.five.Location = new System.Drawing.Point(116, 215);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(85, 80);
            this.five.TabIndex = 30;
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("six.BackgroundImage")));
            this.six.Location = new System.Drawing.Point(225, 123);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(85, 80);
            this.six.TabIndex = 31;
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seven.BackgroundImage")));
            this.seven.Location = new System.Drawing.Point(14, 215);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(85, 80);
            this.seven.TabIndex = 32;
            this.seven.UseVisualStyleBackColor = true;
            // 
            // eight
            // 
            this.eight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eight.BackgroundImage")));
            this.eight.Location = new System.Drawing.Point(225, 215);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(85, 80);
            this.eight.TabIndex = 33;
            this.eight.UseVisualStyleBackColor = true;
            // 
            // blank
            // 
            this.blank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blank.BackgroundImage")));
            this.blank.Location = new System.Drawing.Point(116, 123);
            this.blank.Name = "blank";
            this.blank.Size = new System.Drawing.Size(85, 80);
            this.blank.TabIndex = 37;
            this.blank.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.one);
            this.panel1.Controls.Add(this.blank);
            this.panel1.Controls.Add(this.two);
            this.panel1.Controls.Add(this.eight);
            this.panel1.Controls.Add(this.three);
            this.panel1.Controls.Add(this.seven);
            this.panel1.Controls.Add(this.four);
            this.panel1.Controls.Add(this.six);
            this.panel1.Controls.Add(this.five);
            this.panel1.Location = new System.Drawing.Point(86, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 311);
            this.panel1.TabIndex = 38;
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(142, 585);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(175, 29);
            this.solve.TabIndex = 38;
            this.solve.Text = "solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 727);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.solvable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.moves);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.millisec);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heurestic);
            this.Controls.Add(this.algorithm);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.algorithm.ResumeLayout(false);
            this.algorithm.PerformLayout();
            this.heurestic.ResumeLayout(false);
            this.heurestic.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RadioButton A_star;
        private RadioButton bfs;
        private Label label1;
        private TextBox file_name;
        private RadioButton hamming;
        private RadioButton manhattan;
        private GroupBox algorithm;
        private GroupBox heurestic;
        private Label label2;
        private TextBox minute;
        private TextBox sec;
        private TextBox millisec;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox moves;
        private Label label7;
        private TextBox path;
        private Label label8;
        private TextBox solvable;
        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button eight;
        private Button blank;
        private Panel panel1;
        private Button solve;
    }
}