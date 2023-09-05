
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Calculator_Main
{
    public partial class Main : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "project.db";
        SQLiteDataReader dr;
        double[] expenses1, expenses2, expenses3, expenses4;
        double[] incomes1, incomes2, incomes3, incomes4;
        public Main()
        {
            InitializeComponent();
            currency.Text = "USD - $";
            methods.data_show(cs, dr, devices_1, devices_2, devices_3, devices_4);
            Logger.Log("App_Load", "load");
        }

        private void addDevice_Click(object sender, EventArgs e) //добавление нового устройства
        {
            Logger.Log("addDevice_Click", "action");
            if (d2.Visible == false)
            {
                d2.Show();
            }

            else if (d3.Visible == false)
            {
                d3.Show();
            }

            else if (d4.Visible == false)
            {
                d4.Show();
            }
        }

        private void currency_TextChanged(object sender, EventArgs e) //если меняется валюта - меняется текст в цене эликтричества
        {
            Logger.Log("currency_TextChanged", "action");
            if (currency.Text == "USD - $")
            {
                Kwh_label.Text = "USD/Kwh";
            }

            else if (currency.Text == "KZT - ₸")
            {
                Kwh_label.Text = "KZT/Kwh";
            }

            else if (currency.Text == "RUB - ₽")
            {
                Kwh_label.Text = "RUB/Kwh";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Logger.Log("currency_TextChanged", "action");
            methods.Clear(price, capacity_1, capacity_2, capacity_3, capacity_4, devices_1, devices_2, devices_3, devices_4, d2, d3, d4, currency);
        }

        private void pluse_1_Click(object sender, EventArgs e)
        {
            Logger.Log("pluse_1_Click", "action");
            methods.pluse(capacity_1);
        }

        private void minus_1_Click(object sender, EventArgs e)
        {
            Logger.Log("minus_1_Click", "action");
            methods.minus(capacity_1);
        }

        private void pluse_2_Click(object sender, EventArgs e)
        {
            Logger.Log("pluse_2_Click", "action");
            methods.pluse(capacity_2);
        }

        private void minus_2_Click(object sender, EventArgs e)
        {
            Logger.Log("pluse_2_Click", "action");
            methods.minus(capacity_2);
        }

        private void pluse_3_Click(object sender, EventArgs e)
        {
            Logger.Log("pluse_3_Click", "action");
            methods.pluse(capacity_3);
        }

        private void minus_3_Click(object sender, EventArgs e)
        {
            Logger.Log("minus_3_Click", "action");
            methods.minus(capacity_3);
        }

        private void pluse_4_Click(object sender, EventArgs e)
        {
            Logger.Log("pluse_4_Click", "action");
            methods.pluse(capacity_4);
        }

        private void minus_4_Click(object sender, EventArgs e)
        {
            Logger.Log("minus_4_Click", "action");
            methods.minus(capacity_4);
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logger.Log("price_KeyPress", "action");
            methods.labelOnlyNums(e);
        }

        private void capacity_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logger.Log("capacity_1_KeyPress", "action");
            methods.labelOnlyNums(e);
        }

        private void capacity_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logger.Log("capacity_2_KeyPress", "action");
            methods.labelOnlyNums(e);
        }

        private void capacity_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logger.Log("capacity_3_KeyPress", "action");
            methods.labelOnlyNums(e);
        }

        private void capacity_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logger.Log("capacity_4_KeyPress", "action");
            methods.labelOnlyNums(e);
        }

        private void delete_1_Click(object sender, EventArgs e)
        {
            Logger.Log("delete_1_Click", "action");
            d2.Hide();
        }

        private void delete_3_Click(object sender, EventArgs e)
        {
            Logger.Log("delete_3_Click", "action");
            d3.Hide();
        }

        private void delete_4_Click(object sender, EventArgs e)
        {
            Logger.Log("delete_4_Click", "action");
            d4.Hide();
        }

        private void calculateResult_Click(object sender, EventArgs e)
        {
            if (float.Parse(price.Text) <= 0.1)
            {
                MessageBox.Show("Цена за электричество не может быть 0, минимально 0.1");
                price.Text = "0.1";
            }

            else if (capacity_1.Text == "0" || capacity_2.Text == "0" || capacity_3.Text == "0" || capacity_4.Text == "0")
            {
                MessageBox.Show("Количество устройств не может быть < 1");
            }

            else
            {
                Logger.Log("calculateResult_Click", "action");
                if (d2.Visible == true)
                {
                    methods.Calculate(devices_2, cs, dr, price, capacity_1, currency, out expenses2, out incomes2);
                }

                else if (d2.Visible == false)
                {
                    expenses2 = new double[4] { 0, 0, 0, 0 };
                    incomes2 = new double[4] { 0, 0, 0, 0 };
                }

                if (d3.Visible == true)
                {
                    methods.Calculate(devices_3, cs, dr, price, capacity_1, currency, out expenses3, out incomes3);
                }

                else if (d3.Visible == false)
                {
                    expenses3 = new double[4] { 0, 0, 0, 0 };
                    incomes3 = new double[4] { 0, 0, 0, 0 };
                }

                if (d4.Visible == true)
                {
                    methods.Calculate(devices_4, cs, dr, price, capacity_1, currency, out expenses4, out incomes4);
                }

                else if (d4.Visible == false)
                {
                    expenses4 = new double[4] { 0, 0, 0, 0 };
                    incomes4 = new double[4] { 0, 0, 0, 0 };
                }
                methods.Calculate(devices_1, cs, dr, price, capacity_1, currency, out expenses1, out incomes1);

                double expenses1H = expenses1[0] + expenses2[0] + expenses3[0] + expenses4[0];
                double expenses1D = expenses1[1] + expenses2[1] + expenses3[1] + expenses4[1];
                double expenses1M = expenses1[2] + expenses2[2] + expenses3[2] + expenses4[2];
                double expenses1Y = expenses1[3] + expenses2[3] + expenses3[3] + expenses4[3];

                double income = incomes1[0] + incomes2[0] + incomes3[0] + incomes4[0];
                double income1D = incomes1[1] + incomes2[1] + incomes3[1] + incomes4[1];
                double income1M = incomes1[2] + incomes2[2] + incomes3[2] + incomes4[2];
                double income1Y = incomes1[3] + incomes2[3] + incomes3[3] + incomes4[3];
                MessageBox.Show($"Ваш доход исходя из конфигурации\nЗа час - {income} {currency.Text}\nЗа 1 день - {income1D} {currency.Text}\nЗа 1 месяц - {income1M} {currency.Text}\nЗа 1 год - {income1Y} {currency.Text}");
                MessageBox.Show($"Ваш расдоход исходя из конфигурации\nЗа час - {expenses1H}{currency.Text}\nЗа 1 день - {expenses1D} {currency.Text}\nЗа 1 месяц - {expenses1M} {currency.Text}\nЗа 1 год - {expenses1Y} {currency.Text}");
                MessageBox.Show($"Ваша прибыль исходя из конфигурации\nЗа час - {income - expenses1H} {currency.Text}\nЗа 1 день - {income1D - expenses1D} {currency.Text}\nЗа 1 месяц - {income1M - expenses1M} {currency.Text}\nЗа 1 год - {income1Y - expenses1Y} {currency.Text}");
                Logger.Log("result_calculated", "action");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void capacity_1_TextChanged(object sender, EventArgs e)
        {
        }

        private void capacity_2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
