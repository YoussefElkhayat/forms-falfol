using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp8
{
    public partial class Form2 : Form
    {
        List<Fooditem> orders = new List<Fooditem>();
        double total = 0;
        int count = 1;
        public Form2()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        }


        public void label(string Name, double price, int Calories)
        {
            label1.Text = $"المواصفات:\n تم اضافة {Name}\n السعر : {price} \n يحتوي على {Calories} سعرة حراري";
            listBox1.Items.Add($"{Name} - {price}ج");

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

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
            label2.Text = $"الإجمالي: {total} جنيه";
            count++;
            label4.Text = $"{count}";
            label1.Text = " ";

        }

        // menu ####
        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }
        void clearmenu()
        {
            panelmenu.Controls.Clear();
            y = 10;
        }
        int y = 10;
        void creatbtn(string name, double price, int calories)
        {
            Button btn = new Button();
            btn.Text = name;
            btn.Width = 200;
            btn.Height = 90;
            btn.Top = y;

            btn.Left = 100;
            y += 60;
            btn.Click += (s, e) =>
            {
                var existing = orders.FirstOrDefault(x => x.Name == name);
                label(name, price, calories);

                if (existing != null)
                {
                    existing.Quantity++;
                }
                else
                {
                    orders.Add(new Fooditem
                    {
                        Name = name,
                        price = price,
                        Calories = calories,
                        Quantity = 1


                    });
                }

                RefreshCart();

            };
            panelmenu.Controls.Add(btn);

        }


        void RefreshCart()
        {
            listBox1.Items.Clear();

            total = 0;

            foreach (var item in orders)
            {
                double itemTotal = item.price * item.Quantity;

                listBox1.Items.Add($"{item.Name}  = {itemTotal}ج    x{item.Quantity}       يحتوي على {item.Calories} سعرة للقطعة الواحدة");

                total += itemTotal;
            }

            label2.Text = $"الإجمالي: {total} جنيه";
        }
        void RemoveItem(string name)
        {
            var item = orders.FirstOrDefault(x => x.Name == name);

            if (item != null)
            {
                orders.Remove(item);
                RefreshCart();
            }
        }
        private void btnpizza_Click(object sender, EventArgs e)
        {
            clearmenu();
            creatbtn("بيتزا فراخ", 90, 800);
            creatbtn("بيتزا باربكيو فراخ", 100, 900);
            creatbtn("بيتزا سبايسي فراخ", 100, 830);
            creatbtn("بيتزا رانش فراخ", 105, 860);
            creatbtn("بيتزا بيبروني", 95, 850);
            creatbtn("بيتزا ميكس لحوم", 130, 1100);
            creatbtn("بيتزا سجق", 95, 870);
            creatbtn("بيتزا مارجريتا", 70, 650);
            creatbtn("بيتزا تشيز سوبريم", 85, 780);
            creatbtn("بيتزا فور تشيز", 110, 950);
            creatbtn("بيتزا رومي مدخن", 100, 880);
            creatbtn("بيتزا خضار", 75, 600);
            creatbtn("بيتزا مشروم", 80, 620);
            creatbtn("بيتزا سي فود", 140, 750);


            creatbtn("بيتزا هاواي", 95, 820);
        }
        private void btncreb_Click(object sender, EventArgs e)
        {
            clearmenu();
            creatbtn("كريب بانيه", 120, 500);
            creatbtn("كريب كرسبي", 125, 600);
            creatbtn("كريب شيش طاووق", 120, 520);
            creatbtn("كريب فاهيتا فراخ", 130, 550);
            creatbtn("كريب فراخ بالمشروم", 128, 560);

            creatbtn("كريب كفتة", 135, 520);
            creatbtn("كريب سجق", 130, 600);
            creatbtn("كريب برجر", 150, 650);
            creatbtn("كريب ميكس لحوم", 145, 750);

            creatbtn("كريب جبنة موتزاريلا", 127, 450);
            creatbtn("كريب جبنة رومي", 100, 470);
            creatbtn("كريب ميكس جبن", 100, 550);

            creatbtn("كريب نوتيلا", 130, 650);
            creatbtn("كريب نوتيلا موز", 135, 700);
            creatbtn("كريب شوكولاتة", 125, 600);
            creatbtn("كريب ميكس شوكولاتة", 150, 850);
            creatbtn("كريب تيتانك", 130, 560);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            clearmenu();


            creatbtn("برجر كلاسيك لحم", 85, 750);
            creatbtn("تشيز برجر", 95, 820);
            creatbtn("دبل تشيز برجر", 130, 1100);
            creatbtn("تريبل برجر لحم", 160, 1350);
            creatbtn("ستيك هاوس برجر", 120, 950);


            creatbtn("برجر فراخ", 80, 700);
            creatbtn("تشيز تشيكن برجر", 95, 800);
            creatbtn("سبايسي تشيكن برجر", 90, 760);
            creatbtn("رانش تشيكن برجر", 100, 820);
            creatbtn("كريسبي تشيكن برجر", 105, 850);
            creatbtn("باربكيو تشيكن برجر", 110, 880);


            creatbtn("مشروم سويس برجر", 115, 950);
            creatbtn("بلو تشيز برجر", 120, 980);
            creatbtn("باربكيو بيف برجر", 105, 880);
            creatbtn("هاني ماسترد برجر", 100, 830);

            creatbtn("برجر بيكون لحم", 120, 1000);
            creatbtn("برجر بيكون فراخ", 115, 950);
            creatbtn("برجر ميكس لحوم", 140, 1150);
            creatbtn("مونستر برجر (دبل لحم + فراخ)", 170, 1500);
            creatbtn("فيجي برجر", 85, 650);
            creatbtn("فلافل برجر", 70, 600);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("اختر عنصر للحذف");
                return;
            }

            string selected = listBox1.SelectedItem.ToString();

            var item = orders.FirstOrDefault(x => selected.Contains(x.Name));

            if (item != null)
            {
                orders.Remove(item);
                RefreshCart();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldatatime.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt");
        }


    }
}
