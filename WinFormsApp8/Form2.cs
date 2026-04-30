using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form2 : Form
    {
        List<Fooditem> orders = new List<Fooditem>();
        double total = 0;
        int count = 1;
        int foul = 0;
        int foulziet = 0;
        int foul24ta = 0;
        int foulsog2 = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fooditem item = new Fooditem();
            item.Name = "فول";
            item.price = 8;
            item.Calories = 300;
            orders.Add(item);
            total += item.price;
            label1.Text = $"المواصفات:\n تم اضافة {item.Name}\n سعرة : {item.price} \n يحتوي على {item.Calories} سعرة حراري";
            listBox1.Items.Add($"{item.Name} - {item.price}ج");
            label2.Text = $"الأجمالي: {total} جنية";
            foul++;
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fooditem item = new Fooditem();
            item.Name = "طعمية";
            item.price = 8;
            item.Calories = 300;
            orders.Add(item);
            total += item.price;
            label1.Text = $"المواصفات:\n تم اضافة {item.Name}\n السعر: {item.price} \n يحتوي على {item.Calories} سعرة حراري";
            listBox1.Items.Add($"{item.Name} - {item.price}ج");
            label2.Text = $"الأجمالي: {total} جنية";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fooditem item = new Fooditem();
            item.Name = "بطاطس كاتشب";
            item.price = 15;
            item.Calories = 370;
            orders.Add(item);
            total += item.price;
            label1.Text = $"المواصفات:\n تم اضافة {item.Name}\n السعر: {item.price} \n يحتوي على {item.Calories} سعرة حراري";
            listBox1.Items.Add($"{item.Name} - {item.price}ج");
            label2.Text = $"الأجمالي: {total} جنية";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Fooditem item = new Fooditem();
            item.Name = "فول بالقشطة";
            item.price = 15;
            item.Calories = 350;
            orders.Add(item);
            total += item.price;
            label1.Text = $"المواصفات:\n تم اضافة {item.Name}\n السعر: {item.price} \n يحتوي على {item.Calories} سعرة حراري";
            listBox1.Items.Add($"{item.Name} - {item.price}ج");
            label2.Text = $"الأجمالي: {total} جنية";
            foul24ta++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Fooditem item = new Fooditem();
            item.Name = "فول بالسجق";
            item.price = 20;
            item.Calories = 430;
            orders.Add(item);
            total += item.price;
            label1.Text = $"المواصفات:\n تم اضافة {item.Name}\n السعر: {item.price} \n يحتوي على {item.Calories} سعرة حراري";
            listBox1.Items.Add($"{item.Name} - {item.price}ج");
            label2.Text = $"الأجمالي: {total} جنية";
            foulsog2++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fooditem item = new Fooditem();
            item.Name = "طعمية محشية";
            item.price = 15;
            item.Calories = 240;
            orders.Add(item);
            total += item.price;
            label1.Text = $"المواصفات:\n تم اضافة {item.Name}\n السعر: {item.price} \n يحتوي على {item.Calories} سعرة حراري";
            listBox1.Items.Add($"{item.Name} - {item.price}ج");
            label2.Text = $"الأجمالي: {total} جنية";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Fooditem item = new Fooditem();
            item.Name = " بطاطس عادي";
            item.price = 15;
            item.Calories = 370;
            orders.Add(item);
            total += item.price;
            label1.Text = $"المواصفات:\n تم اضافة {item.Name}\n السعر: {item.price} \n يحتوي على {item.Calories} سعرة حراري";
            listBox1.Items.Add($"{item.Name} - {item.price}ج");
            label2.Text = $"الأجمالي: {total} جنية";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Fooditem item = new Fooditem();
            item.Name = "ماكس";
            item.price = 15;
            item.Calories = 999;
            orders.Add(item);
            total += item.price;
            label1.Text = $"المواصفات:\n تم اضافة {item.Name}\n السعر: {item.price} \n يحتوي على {item.Calories} سعرة حراري";
            listBox1.Items.Add($"{item.Name} - {item.price}ج");
            label2.Text = $"الأجمالي: {total} جنية";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fooditem item = new Fooditem();
            item.Name = "فول بالزيت الحار";
            item.price = 15;
            item.Calories = 400;
            orders.Add(item);
            total += item.price;
            label1.Text = $"المواصفات:\n تم اضافة {item.Name}\n السعر: {item.price} \n يحتوي على {item.Calories} سعرة حراري";
            listBox1.Items.Add($"{item.Name} - {item.price}ج");
            label2.Text = $"الأجمالي: {total} جنية";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            orders.Clear();
            total = total * 0;
            label2.Text = $"الأجمالي: {total} جنية";
            count++;
            label4.Text = $"{count}";
            label1.Text = " ";
           int foul = 0;
            int foulziet = 0;
            int foul24ta = 0;
            int foulsog2 = 0;
        }
    }
}
