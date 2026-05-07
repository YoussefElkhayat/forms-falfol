namespace WinFormsApp8
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button22 = new Button();
            listBox1 = new ListBox();
            btnpizza = new Button();
            btncreb = new Button();
            panelmenu = new FlowLayoutPanel();
            btnBurger = new Button();
            btndelete = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbldatatime = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 60);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(0, 46);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(352, 283);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(214, 62);
            label2.TabIndex = 3;
            label2.Text = "الإجمالي: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 11);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(155, 38);
            label3.TabIndex = 26;
            label3.Text = "الطلب رقم: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 11);
            label4.Name = "label4";
            label4.Size = new Size(33, 38);
            label4.TabIndex = 27;
            label4.Text = "1";
            label4.Click += label4_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.Orange;
            button22.Location = new Point(42, 74);
            button22.Name = "button22";
            button22.Size = new Size(226, 83);
            button22.TabIndex = 31;
            button22.Text = "تسليم الطلب";
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightGray;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(771, 60);
            listBox1.Margin = new Padding(6);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.Yes;
            listBox1.Size = new Size(1008, 337);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnpizza
            // 
            btnpizza.Location = new Point(1636, 442);
            btnpizza.Name = "btnpizza";
            btnpizza.Size = new Size(143, 81);
            btnpizza.TabIndex = 33;
            btnpizza.Text = "Pizza";
            btnpizza.UseVisualStyleBackColor = true;
            btnpizza.Click += btnpizza_Click;
            // 
            // btncreb
            // 
            btncreb.Location = new Point(1636, 559);
            btncreb.Name = "btncreb";
            btncreb.Size = new Size(143, 81);
            btncreb.TabIndex = 34;
            btncreb.Text = "crepe";
            btncreb.UseVisualStyleBackColor = true;
            btncreb.Click += btncreb_Click;
            // 
            // panelmenu
            // 
            panelmenu.AutoScroll = true;
            panelmenu.BackColor = Color.White;
            panelmenu.Cursor = Cursors.Hand;
            panelmenu.Location = new Point(98, 442);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(1455, 452);
            panelmenu.TabIndex = 35;
            // 
            // btnBurger
            // 
            btnBurger.Location = new Point(1636, 676);
            btnBurger.Name = "btnBurger";
            btnBurger.Size = new Size(143, 81);
            btnBurger.TabIndex = 38;
            btnBurger.Text = "Burger";
            btnBurger.UseVisualStyleBackColor = true;
            btnBurger.Click += button2_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(192, 0, 0);
            btndelete.Cursor = Cursors.Hand;
            btndelete.ForeColor = SystemColors.ButtonHighlight;
            btndelete.Location = new Point(42, 244);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(226, 67);
            btndelete.TabIndex = 39;
            btndelete.Text = "حذف";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lbldatatime
            // 
            lbldatatime.AutoSize = true;
            lbldatatime.Location = new Point(1429, 11);
            lbldatatime.Name = "lbldatatime";
            lbldatatime.Size = new Size(96, 38);
            lbldatatime.TabIndex = 40;
            lbldatatime.Text = "label5";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 228, 201);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1814, 1054);
            Controls.Add(lbldatatime);
            Controls.Add(btndelete);
            Controls.Add(label1);
            Controls.Add(btnBurger);
            Controls.Add(panelmenu);
            Controls.Add(btncreb);
            Controls.Add(btnpizza);
            Controls.Add(button22);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مطعم فلفول";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button22;
        private ListBox listBox1;
        private Button btnpizza;
        private Button btncreb;
        private FlowLayoutPanel panelmenu;
        private Button btnBurger;
        private Button btndelete;
        private System.Windows.Forms.Timer timer1;
        private Label lbldatatime;
    }
}