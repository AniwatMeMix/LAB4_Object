using System;

namespace LAB4_Object
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("Object");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = TBname.Text;
            string bYear = TBbithyear.Text;
            string gpa = TBgpa.Text;
            int ibYear = Int32.Parse(bYear);
            double iGpa = double.Parse(gpa);
            Student newStudent = new Student(name, ibYear, iGpa);

            this.classroom.addPersonToClass(newStudent);
            this.classroom.addGPAToClass();
            this.namelisto.Text = this.classroom.showAllPersoninClass();

            int currentAge = Int32.Parse(this.TBgpa.Text);
            int newTotal = currentAge + this.classroom.showTotalAgeinClass();
            this.oldtotal.Text = newTotal.ToString();

            double newMax = this.classroom.showGPXMax();
            this.gpaMax.Text = newMax.ToString();

            double newMin = this.classroom.showGPXMin();
            this.gpaMin.Text = newMin.ToString();

            double newAvg = this.classroom.showGPXAvg();
            this.gpaAvg.Text = newAvg.ToString();

            this.nameMax.Text = this.classroom.showNameMax();
            this.nameMin.Text = this.classroom.showNameMin();

            this.TBname.Text = "";
            this.TBbithyear.Text = "";
            this.TBgpa.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}