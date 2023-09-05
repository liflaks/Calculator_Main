
namespace Calculator_Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Light = new System.Windows.Forms.PictureBox();
            Kwh_label = new System.Windows.Forms.Label();
            price = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            currency = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            d2 = new System.Windows.Forms.Panel();
            delete_1 = new System.Windows.Forms.PictureBox();
            pluse_2 = new System.Windows.Forms.PictureBox();
            capacity_2 = new System.Windows.Forms.TextBox();
            minus_2 = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            devices_2 = new System.Windows.Forms.ComboBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label5 = new System.Windows.Forms.Label();
            d3 = new System.Windows.Forms.Panel();
            delete_3 = new System.Windows.Forms.PictureBox();
            pluse_3 = new System.Windows.Forms.PictureBox();
            capacity_3 = new System.Windows.Forms.TextBox();
            minus_3 = new System.Windows.Forms.PictureBox();
            label7 = new System.Windows.Forms.Label();
            devices_3 = new System.Windows.Forms.ComboBox();
            pictureBox8 = new System.Windows.Forms.PictureBox();
            label8 = new System.Windows.Forms.Label();
            d4 = new System.Windows.Forms.Panel();
            delete_4 = new System.Windows.Forms.PictureBox();
            pluse_4 = new System.Windows.Forms.PictureBox();
            capacity_4 = new System.Windows.Forms.TextBox();
            minus_4 = new System.Windows.Forms.PictureBox();
            label9 = new System.Windows.Forms.Label();
            devices_4 = new System.Windows.Forms.ComboBox();
            pictureBox12 = new System.Windows.Forms.PictureBox();
            label10 = new System.Windows.Forms.Label();
            devices_1 = new System.Windows.Forms.ComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            minus_1 = new System.Windows.Forms.PictureBox();
            pluse_1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            capacity_1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            d1 = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)Light).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            d2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delete_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pluse_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minus_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            d3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delete_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pluse_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minus_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            d4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delete_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pluse_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minus_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minus_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pluse_1).BeginInit();
            d1.SuspendLayout();
            SuspendLayout();
            // 
            // Light
            // 
            Light.BackColor = System.Drawing.Color.White;
            Light.Image = (System.Drawing.Image)resources.GetObject("Light.Image");
            Light.Location = new System.Drawing.Point(382, 3);
            Light.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Light.Name = "Light";
            Light.Size = new System.Drawing.Size(27, 19);
            Light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Light.TabIndex = 6;
            Light.TabStop = false;
            // 
            // Kwh_label
            // 
            Kwh_label.AutoSize = true;
            Kwh_label.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            Kwh_label.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Kwh_label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            Kwh_label.Location = new System.Drawing.Point(365, 28);
            Kwh_label.Name = "Kwh_label";
            Kwh_label.Size = new System.Drawing.Size(50, 15);
            Kwh_label.TabIndex = 5;
            Kwh_label.Text = "USD/Kwh";
            // 
            // price
            // 
            price.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            price.ForeColor = System.Drawing.Color.Black;
            price.Location = new System.Drawing.Point(237, 25);
            price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            price.Name = "price";
            price.Size = new System.Drawing.Size(180, 23);
            price.TabIndex = 4;
            price.Text = "0.1";
            price.KeyPress += price_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(238, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(147, 19);
            label2.TabIndex = 3;
            label2.Text = "Цена за электричество";
            // 
            // currency
            // 
            currency.BackColor = System.Drawing.Color.White;
            currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            currency.ForeColor = System.Drawing.Color.Black;
            currency.FormattingEnabled = true;
            currency.Items.AddRange(new object[] { "USD - $", "KZT - ₸", "RUB - ₽" });
            currency.Location = new System.Drawing.Point(53, 24);
            currency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            currency.Name = "currency";
            currency.Size = new System.Drawing.Size(133, 23);
            currency.TabIndex = 2;
            currency.TextChanged += currency_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(54, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 19);
            label1.TabIndex = 1;
            label1.Text = "Валюта";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(114, 3);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(21, 19);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // d2
            // 
            d2.BackColor = System.Drawing.Color.White;
            d2.Controls.Add(delete_1);
            d2.Controls.Add(pluse_2);
            d2.Controls.Add(capacity_2);
            d2.Controls.Add(minus_2);
            d2.Controls.Add(label6);
            d2.Controls.Add(devices_2);
            d2.Controls.Add(pictureBox3);
            d2.Controls.Add(label5);
            d2.Location = new System.Drawing.Point(53, 120);
            d2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            d2.Name = "d2";
            d2.Size = new System.Drawing.Size(444, 66);
            d2.TabIndex = 17;
            d2.Visible = false;
            // 
            // delete_1
            // 
            delete_1.BackColor = System.Drawing.SystemColors.Window;
            delete_1.Image = (System.Drawing.Image)resources.GetObject("delete_1.Image");
            delete_1.Location = new System.Drawing.Point(384, 34);
            delete_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            delete_1.Name = "delete_1";
            delete_1.Size = new System.Drawing.Size(26, 22);
            delete_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            delete_1.TabIndex = 19;
            delete_1.TabStop = false;
            delete_1.Click += delete_1_Click;
            // 
            // pluse_2
            // 
            pluse_2.BackColor = System.Drawing.SystemColors.Window;
            pluse_2.ErrorImage = (System.Drawing.Image)resources.GetObject("pluse_2.ErrorImage");
            pluse_2.Image = (System.Drawing.Image)resources.GetObject("pluse_2.Image");
            pluse_2.Location = new System.Drawing.Point(341, 34);
            pluse_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pluse_2.Name = "pluse_2";
            pluse_2.Size = new System.Drawing.Size(26, 22);
            pluse_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pluse_2.TabIndex = 18;
            pluse_2.TabStop = false;
            pluse_2.Click += pluse_2_Click;
            // 
            // capacity_2
            // 
            capacity_2.BackColor = System.Drawing.SystemColors.Window;
            capacity_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            capacity_2.ForeColor = System.Drawing.Color.Black;
            capacity_2.Location = new System.Drawing.Point(321, 38);
            capacity_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            capacity_2.Name = "capacity_2";
            capacity_2.Size = new System.Drawing.Size(20, 16);
            capacity_2.TabIndex = 18;
            capacity_2.Text = "1";
            capacity_2.TextChanged += capacity_2_TextChanged;
            capacity_2.KeyPress += capacity_2_KeyPress;
            // 
            // minus_2
            // 
            minus_2.BackColor = System.Drawing.SystemColors.Window;
            minus_2.Image = (System.Drawing.Image)resources.GetObject("minus_2.Image");
            minus_2.Location = new System.Drawing.Point(281, 34);
            minus_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            minus_2.Name = "minus_2";
            minus_2.Size = new System.Drawing.Size(26, 22);
            minus_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            minus_2.TabIndex = 18;
            minus_2.TabStop = false;
            minus_2.Click += minus_2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.SystemColors.Window;
            label6.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label6.Location = new System.Drawing.Point(273, 11);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(119, 14);
            label6.TabIndex = 18;
            label6.Text = "Кол - во устройств";
            // 
            // devices_2
            // 
            devices_2.BackColor = System.Drawing.Color.White;
            devices_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            devices_2.ForeColor = System.Drawing.Color.Black;
            devices_2.FormattingEnabled = true;
            devices_2.Location = new System.Drawing.Point(9, 34);
            devices_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            devices_2.Name = "devices_2";
            devices_2.Size = new System.Drawing.Size(241, 23);
            devices_2.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(82, 12);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(39, 22);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.Window;
            label5.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(9, 20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 14);
            label5.TabIndex = 18;
            label5.Text = "Устройство";
            // 
            // d3
            // 
            d3.BackColor = System.Drawing.Color.White;
            d3.Controls.Add(delete_3);
            d3.Controls.Add(pluse_3);
            d3.Controls.Add(capacity_3);
            d3.Controls.Add(minus_3);
            d3.Controls.Add(label7);
            d3.Controls.Add(devices_3);
            d3.Controls.Add(pictureBox8);
            d3.Controls.Add(label8);
            d3.Location = new System.Drawing.Point(53, 190);
            d3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            d3.Name = "d3";
            d3.Size = new System.Drawing.Size(444, 66);
            d3.TabIndex = 19;
            d3.Visible = false;
            // 
            // delete_3
            // 
            delete_3.BackColor = System.Drawing.SystemColors.Window;
            delete_3.Image = (System.Drawing.Image)resources.GetObject("delete_3.Image");
            delete_3.Location = new System.Drawing.Point(384, 35);
            delete_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            delete_3.Name = "delete_3";
            delete_3.Size = new System.Drawing.Size(26, 22);
            delete_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            delete_3.TabIndex = 19;
            delete_3.TabStop = false;
            delete_3.Click += delete_3_Click;
            // 
            // pluse_3
            // 
            pluse_3.BackColor = System.Drawing.SystemColors.Window;
            pluse_3.ErrorImage = (System.Drawing.Image)resources.GetObject("pluse_3.ErrorImage");
            pluse_3.Image = (System.Drawing.Image)resources.GetObject("pluse_3.Image");
            pluse_3.Location = new System.Drawing.Point(341, 35);
            pluse_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pluse_3.Name = "pluse_3";
            pluse_3.Size = new System.Drawing.Size(26, 22);
            pluse_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pluse_3.TabIndex = 18;
            pluse_3.TabStop = false;
            pluse_3.Click += pluse_3_Click;
            // 
            // capacity_3
            // 
            capacity_3.BackColor = System.Drawing.SystemColors.Window;
            capacity_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            capacity_3.ForeColor = System.Drawing.Color.Black;
            capacity_3.Location = new System.Drawing.Point(321, 39);
            capacity_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            capacity_3.Name = "capacity_3";
            capacity_3.Size = new System.Drawing.Size(20, 16);
            capacity_3.TabIndex = 18;
            capacity_3.Text = "1";
            capacity_3.KeyPress += capacity_3_KeyPress;
            // 
            // minus_3
            // 
            minus_3.BackColor = System.Drawing.SystemColors.Window;
            minus_3.Image = (System.Drawing.Image)resources.GetObject("minus_3.Image");
            minus_3.Location = new System.Drawing.Point(281, 35);
            minus_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            minus_3.Name = "minus_3";
            minus_3.Size = new System.Drawing.Size(26, 22);
            minus_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            minus_3.TabIndex = 18;
            minus_3.TabStop = false;
            minus_3.Click += minus_3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.SystemColors.Window;
            label7.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label7.Location = new System.Drawing.Point(273, 12);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(119, 14);
            label7.TabIndex = 18;
            label7.Text = "Кол - во устройств";
            // 
            // devices_3
            // 
            devices_3.BackColor = System.Drawing.Color.White;
            devices_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            devices_3.ForeColor = System.Drawing.Color.Black;
            devices_3.FormattingEnabled = true;
            devices_3.Location = new System.Drawing.Point(9, 34);
            devices_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            devices_3.Name = "devices_3";
            devices_3.Size = new System.Drawing.Size(241, 23);
            devices_3.TabIndex = 19;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            pictureBox8.Image = (System.Drawing.Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new System.Drawing.Point(82, 11);
            pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new System.Drawing.Size(39, 22);
            pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.SystemColors.Window;
            label8.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(9, 20);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 14);
            label8.TabIndex = 18;
            label8.Text = "Устройство";
            // 
            // d4
            // 
            d4.BackColor = System.Drawing.Color.White;
            d4.Controls.Add(delete_4);
            d4.Controls.Add(pluse_4);
            d4.Controls.Add(capacity_4);
            d4.Controls.Add(minus_4);
            d4.Controls.Add(label9);
            d4.Controls.Add(devices_4);
            d4.Controls.Add(pictureBox12);
            d4.Controls.Add(label10);
            d4.Location = new System.Drawing.Point(53, 261);
            d4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            d4.Name = "d4";
            d4.Size = new System.Drawing.Size(444, 66);
            d4.TabIndex = 20;
            d4.Visible = false;
            // 
            // delete_4
            // 
            delete_4.BackColor = System.Drawing.SystemColors.Window;
            delete_4.Image = (System.Drawing.Image)resources.GetObject("delete_4.Image");
            delete_4.Location = new System.Drawing.Point(384, 35);
            delete_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            delete_4.Name = "delete_4";
            delete_4.Size = new System.Drawing.Size(26, 22);
            delete_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            delete_4.TabIndex = 19;
            delete_4.TabStop = false;
            delete_4.Click += delete_4_Click;
            // 
            // pluse_4
            // 
            pluse_4.BackColor = System.Drawing.SystemColors.Window;
            pluse_4.Image = (System.Drawing.Image)resources.GetObject("pluse_4.Image");
            pluse_4.Location = new System.Drawing.Point(341, 35);
            pluse_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pluse_4.Name = "pluse_4";
            pluse_4.Size = new System.Drawing.Size(26, 22);
            pluse_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pluse_4.TabIndex = 18;
            pluse_4.TabStop = false;
            pluse_4.Click += pluse_4_Click;
            // 
            // capacity_4
            // 
            capacity_4.BackColor = System.Drawing.SystemColors.Window;
            capacity_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            capacity_4.ForeColor = System.Drawing.Color.Black;
            capacity_4.Location = new System.Drawing.Point(321, 39);
            capacity_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            capacity_4.Name = "capacity_4";
            capacity_4.Size = new System.Drawing.Size(20, 16);
            capacity_4.TabIndex = 18;
            capacity_4.Text = "1";
            capacity_4.KeyPress += capacity_4_KeyPress;
            // 
            // minus_4
            // 
            minus_4.BackColor = System.Drawing.SystemColors.Window;
            minus_4.Image = (System.Drawing.Image)resources.GetObject("minus_4.Image");
            minus_4.Location = new System.Drawing.Point(281, 35);
            minus_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            minus_4.Name = "minus_4";
            minus_4.Size = new System.Drawing.Size(26, 22);
            minus_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            minus_4.TabIndex = 18;
            minus_4.TabStop = false;
            minus_4.Click += minus_4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.SystemColors.Window;
            label9.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label9.Location = new System.Drawing.Point(273, 12);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(119, 14);
            label9.TabIndex = 18;
            label9.Text = "Кол - во устройств";
            // 
            // devices_4
            // 
            devices_4.BackColor = System.Drawing.Color.White;
            devices_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            devices_4.ForeColor = System.Drawing.Color.Black;
            devices_4.FormattingEnabled = true;
            devices_4.Location = new System.Drawing.Point(9, 34);
            devices_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            devices_4.Name = "devices_4";
            devices_4.Size = new System.Drawing.Size(241, 23);
            devices_4.TabIndex = 19;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            pictureBox12.Image = (System.Drawing.Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new System.Drawing.Point(82, 12);
            pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new System.Drawing.Size(39, 22);
            pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 18;
            pictureBox12.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.SystemColors.Window;
            label10.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(9, 20);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(67, 14);
            label10.TabIndex = 18;
            label10.Text = "Устройство";
            // 
            // devices_1
            // 
            devices_1.BackColor = System.Drawing.Color.White;
            devices_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            devices_1.ForeColor = System.Drawing.Color.Black;
            devices_1.FormattingEnabled = true;
            devices_1.Location = new System.Drawing.Point(9, 35);
            devices_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            devices_1.Name = "devices_1";
            devices_1.Size = new System.Drawing.Size(241, 23);
            devices_1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(82, 9);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(39, 22);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // minus_1
            // 
            minus_1.BackColor = System.Drawing.SystemColors.Window;
            minus_1.Image = (System.Drawing.Image)resources.GetObject("minus_1.Image");
            minus_1.Location = new System.Drawing.Point(281, 35);
            minus_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            minus_1.Name = "minus_1";
            minus_1.Size = new System.Drawing.Size(26, 22);
            minus_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            minus_1.TabIndex = 13;
            minus_1.TabStop = false;
            minus_1.Click += minus_1_Click;
            // 
            // pluse_1
            // 
            pluse_1.BackColor = System.Drawing.SystemColors.Window;
            pluse_1.ErrorImage = (System.Drawing.Image)resources.GetObject("pluse_1.ErrorImage");
            pluse_1.Image = (System.Drawing.Image)resources.GetObject("pluse_1.Image");
            pluse_1.Location = new System.Drawing.Point(341, 35);
            pluse_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pluse_1.Name = "pluse_1";
            pluse_1.Size = new System.Drawing.Size(26, 22);
            pluse_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pluse_1.TabIndex = 12;
            pluse_1.TabStop = false;
            pluse_1.Click += pluse_1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.Window;
            label4.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label4.Location = new System.Drawing.Point(273, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 14);
            label4.TabIndex = 15;
            label4.Text = "Кол - во устройств";
            label4.Click += label4_Click;
            // 
            // capacity_1
            // 
            capacity_1.BackColor = System.Drawing.SystemColors.Window;
            capacity_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            capacity_1.ForeColor = System.Drawing.Color.Black;
            capacity_1.Location = new System.Drawing.Point(321, 39);
            capacity_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            capacity_1.Name = "capacity_1";
            capacity_1.Size = new System.Drawing.Size(20, 16);
            capacity_1.TabIndex = 14;
            capacity_1.Text = "1";
            capacity_1.TextChanged += capacity_1_TextChanged;
            capacity_1.KeyPress += capacity_1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.Window;
            label3.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(9, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 14);
            label3.TabIndex = 10;
            label3.Text = "Устройство";
            // 
            // d1
            // 
            d1.BackColor = System.Drawing.Color.White;
            d1.Controls.Add(label3);
            d1.Controls.Add(capacity_1);
            d1.Controls.Add(label4);
            d1.Controls.Add(pluse_1);
            d1.Controls.Add(minus_1);
            d1.Controls.Add(pictureBox1);
            d1.Controls.Add(devices_1);
            d1.Location = new System.Drawing.Point(53, 50);
            d1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            d1.Name = "d1";
            d1.Size = new System.Drawing.Size(444, 66);
            d1.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(206, 332);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(139, 33);
            button2.TabIndex = 24;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Clear_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(351, 332);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(147, 33);
            button3.TabIndex = 25;
            button3.Text = "Посчитать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += calculateResult_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(53, 332);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(147, 33);
            button1.TabIndex = 26;
            button1.Text = "Добавить Устройство";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addDevice_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(556, 377);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(d4);
            Controls.Add(d3);
            Controls.Add(d2);
            Controls.Add(label1);
            Controls.Add(currency);
            Controls.Add(Kwh_label);
            Controls.Add(Light);
            Controls.Add(price);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(d1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mining Calculator";
            ((System.ComponentModel.ISupportInitialize)Light).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            d2.ResumeLayout(false);
            d2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)delete_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pluse_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)minus_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            d3.ResumeLayout(false);
            d3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)delete_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pluse_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)minus_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            d4.ResumeLayout(false);
            d4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)delete_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pluse_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)minus_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)minus_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pluse_1).EndInit();
            d1.ResumeLayout(false);
            d1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label Kwh_label;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox currency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Light;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel d2;
        private System.Windows.Forms.ComboBox devices_2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pluse_2;
        private System.Windows.Forms.TextBox capacity_2;
        private System.Windows.Forms.PictureBox minus_2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox delete_1;
        private System.Windows.Forms.Panel d3;
        private System.Windows.Forms.PictureBox delete_3;
        private System.Windows.Forms.PictureBox pluse_3;
        private System.Windows.Forms.TextBox capacity_3;
        private System.Windows.Forms.PictureBox minus_3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox devices_3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel d4;
        private System.Windows.Forms.PictureBox delete_4;
        private System.Windows.Forms.PictureBox pluse_4;
        private System.Windows.Forms.TextBox capacity_4;
        private System.Windows.Forms.PictureBox minus_4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox devices_4;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox devices_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox minus_1;
        private System.Windows.Forms.PictureBox pluse_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox capacity_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel d1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

