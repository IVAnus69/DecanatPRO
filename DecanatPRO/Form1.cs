using Business_Logic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Graph;

namespace DecanatPRO
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();
        public Form1(Logic Logic)
        {
            logic = Logic;
            InitializeComponent();
            /*foreach (var student in logic.students)
            {
                //listView1.Items.Add(student.Name);
                MessageBox.Show(logic.students[0].Name);
            }*/
            RefreshLi();

            FormClosed += new FormClosedEventHandler(global_FormClosed);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void RefreshLi()
        {
            listView1.Clear();
            listView1.View = View.Details;

            listView1.Columns.Add("ID", 30);
            listView1.Columns.Add("ФИО", 100);
            listView1.Columns.Add("Группа", 70);
            listView1.Columns.Add("Специальность", 100);
            //int i = 0;
            for (int i = 0; i<logic.GetAll().Count();i++)
            {
                //Convert.ToString(i)
                ListViewItem newitem = new ListViewItem(logic.GetAll().ElementAt(i));
                newitem.SubItems.Add(logic.GetAll().ElementAt(i).Split(" "));
                //newitem.SubItems.Add(Convert.ToString(logic.GetAll().ElementAt(i)));
                newitem.SubItems.Add(logic.GetAll().ElementAt(i));
                newitem.SubItems.Add(logic.GetAll().ElementAt(i));

                listView1.Items.Add(newitem);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(logic);
            form.Show();
            this.Hide();
            //Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("");
            //string selectedItem = listView1.Items[listView1.SelectedIndex].ToString();
            //string selectedCountry = listView1.SelectedItem.ToString();
            //MessageBox.Show(selectedCountry);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            int main_id = Convert.ToInt32(textBox1.Text);
            try
            {
                logic.DeleteStudent(main_id - 1);
            }
            catch
            {
                MessageBox.Show("Вы ввели несуществующее значение");
            }
            RefreshLi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> speciality = new List<string>();
            for (int i = 0; i < logic.students.Count;i++)
                speciality.Add(logic.students[i].Speciality);

            Graph.Form2 form1 = new Graph.Form2(speciality);
            form1.Show();
        }
    }
}