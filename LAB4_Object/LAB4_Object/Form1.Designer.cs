namespace LAB4_Object
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
            TBname = new TextBox();
            TBbithyear = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            namelisto = new TextBox();
            label5 = new Label();
            label6 = new Label();
            gpaAvg = new TextBox();
            nameMin = new TextBox();
            gpaMax = new TextBox();
            nameMax = new TextBox();
            gpaMin = new TextBox();
            oldtotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TBgpa = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TBname
            // 
            TBname.Location = new Point(113, 48);
            TBname.Name = "TBname";
            TBname.Size = new Size(125, 27);
            TBname.TabIndex = 0;
            // 
            // TBbithyear
            // 
            TBbithyear.Location = new Point(113, 81);
            TBbithyear.Name = "TBbithyear";
            TBbithyear.Size = new Size(125, 27);
            TBbithyear.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(113, 147);
            button1.Name = "button1";
            button1.Size = new Size(125, 47);
            button1.TabIndex = 2;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(namelisto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(gpaAvg);
            groupBox1.Controls.Add(nameMin);
            groupBox1.Controls.Add(gpaMax);
            groupBox1.Controls.Add(nameMax);
            groupBox1.Controls.Add(gpaMin);
            groupBox1.Controls.Add(oldtotal);
            groupBox1.Location = new Point(266, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 286);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลรายวิชา";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(231, 69);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 14;
            label9.Text = "ชื่อเกรดน้อยสุด";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(231, 36);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 13;
            label10.Text = "ชื่อเกรดมากสุด";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 172);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 12;
            label7.Text = "รายชื่อ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 139);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 11;
            label8.Text = "อายุรวม";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 102);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 10;
            label4.Text = "GPA Avg";
            label4.Click += label4_Click;
            // 
            // namelisto
            // 
            namelisto.Location = new Point(74, 172);
            namelisto.Multiline = true;
            namelisto.Name = "namelisto";
            namelisto.Size = new Size(125, 87);
            namelisto.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 69);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 9;
            label5.Text = "GPA Min";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 36);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 8;
            label6.Text = "GPA Max";
            label6.Click += label6_Click;
            // 
            // gpaAvg
            // 
            gpaAvg.Location = new Point(74, 99);
            gpaAvg.Name = "gpaAvg";
            gpaAvg.Size = new Size(125, 27);
            gpaAvg.TabIndex = 6;
            // 
            // nameMin
            // 
            nameMin.Location = new Point(333, 69);
            nameMin.Name = "nameMin";
            nameMin.Size = new Size(125, 27);
            nameMin.TabIndex = 9;
            nameMin.TextChanged += textBox7_TextChanged;
            // 
            // gpaMax
            // 
            gpaMax.Location = new Point(74, 33);
            gpaMax.Name = "gpaMax";
            gpaMax.Size = new Size(125, 27);
            gpaMax.TabIndex = 4;
            // 
            // nameMax
            // 
            nameMax.Location = new Point(333, 36);
            nameMax.Name = "nameMax";
            nameMax.Size = new Size(125, 27);
            nameMax.TabIndex = 8;
            nameMax.TextChanged += textBox8_TextChanged;
            // 
            // gpaMin
            // 
            gpaMin.Location = new Point(74, 66);
            gpaMin.Name = "gpaMin";
            gpaMin.Size = new Size(125, 27);
            gpaMin.TabIndex = 5;
            // 
            // oldtotal
            // 
            oldtotal.Location = new Point(74, 132);
            oldtotal.Name = "oldtotal";
            oldtotal.Size = new Size(125, 27);
            oldtotal.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 51);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 4;
            label1.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 84);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 5;
            label2.Text = "ปีเกิด";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 117);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "GPA";
            // 
            // TBgpa
            // 
            TBgpa.Location = new Point(113, 114);
            TBgpa.Name = "TBgpa";
            TBgpa.Size = new Size(125, 27);
            TBgpa.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 416);
            Controls.Add(label3);
            Controls.Add(TBgpa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(TBbithyear);
            Controls.Add(TBname);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBname;
        private TextBox TBbithyear;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox gpaMin;
        private TextBox gpaMax;
        private TextBox oldtotal;
        private TextBox gpaAvg;
        private TextBox nameMin;
        private TextBox nameMax;
        private TextBox namelisto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TBgpa;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
    }
}