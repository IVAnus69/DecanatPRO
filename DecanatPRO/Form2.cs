using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic;

namespace DecanatPRO
{
    public partial class Form2 : Form
    {
        Logic logic = new Logic();
        public Form2(Logic Logic)
        {
            logic = Logic;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string speciality = textBox2.Text;
            string group = textBox3.Text;
            logic.AddStudent(name, speciality, group);
            Form1 form = new Form1(logic);
            form.Show();
            this.Close();
            //new Model.Student(name, speciality, group)
        }
    }
}
