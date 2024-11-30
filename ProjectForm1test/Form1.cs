using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForm1test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = true;

            Checkertextbox(textBox1, errorProvider1, "กรุณาเติมใส่ช่องนี้");
            if (string.IsNullOrWhiteSpace(textBox1.Text)) ok = false;

            Checkertextbox(textBox2, errorProvider1, "กรุณาเติมใส่ช่องนี้");
            if (string.IsNullOrWhiteSpace(textBox2.Text)) ok = false;

            Checkertextbox(textBox3, errorProvider1, "กรุณาเติมใส่ช่องนี้");
            if (string.IsNullOrWhiteSpace(textBox3.Text)) ok = false;

            Checkercombo(comboBox1, errorProvider1);
            if (string.IsNullOrWhiteSpace(comboBox1.Text)) ok = false;

            Checkercombo(comboBox2, errorProvider1);
            if (string.IsNullOrEmpty(comboBox2.Text)) ok = false;

            if (!ok)
            {
                return;
            }

            string[] Aform = {textBox1.Text , textBox2.Text ,textBox3.Text, sex, comboBox1.Text , comboBox2.Text };
            Form2 form2 = new Form2(Aform);
            form2.Show();
        }
        private void Checkertextbox(TextBox textBox, ErrorProvider errorProvider ,String texterror)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                // แสดง ErrorProvider 
                errorProvider1.SetError(textBox, texterror);
            }
            else
            {
                // ลบข้อความข้อผิดพลาดหากไม่มีข้อผิดพลาด
                errorProvider1.SetError(textBox, string.Empty);

            }
        }
        private void Checkercombo(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrEmpty(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "กรุณาเลือกตัวเลือกใน ComboBox");
            }
            else
            {
                errorProvider.SetError(comboBox, string.Empty); // ลบข้อความ Error
            }

        }

        string sex = "";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                sex = radioButton1.Text;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton2.Checked)
            {
                sex = radioButton2.Text;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectitem = comboBox1.SelectedItem.ToString();

            comboBox2.Items.Clear();
            if (selectitem == "วิทยาลัยการฝึกหัดครู")
            {
                comboBox2.Items.Add("การศึกษาปฐมวัย");
                comboBox2.Items.Add("การประถมศึกษา");
                comboBox2.Items.Add("ดนตรีศึกษา");
            }
            else if (selectitem == "วิทยาศาสตร์และเทคโนโลยี")
            {
                comboBox2.Items.Add("เทศโนโลยีสารสนเทศ");
                comboBox2.Items.Add("วิทยาการคอมพิวเตอร์");
                comboBox2.Items.Add("คหกรรมศาสตร์");
            }
            else if (selectitem == "มนุษย์ศาสตร์และสังคมศาสตร์")
            {
                comboBox2.Items.Add("นิติศาสตร์");
                comboBox2.Items.Add("รัฐศาสตร์");
                comboBox2.Items.Add("วิชาการออกแบบ");
            }


        }

  
    }
}
