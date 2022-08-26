using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Main
{
    class methods
    {
        public static void labelOnlyNums(KeyPressEventArgs e) //не даёт вводить всё кроме цифр от 0 до 9 . и backspace
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 46)
            {
                e.Handled = true;
            }
        }

        public static void pluse(TextBox textBox) //метод для кнопки плюса
        {
            int new_text = Int32.Parse(textBox.Text) + 1;
            textBox.Text = new_text.ToString();

        }

        public static void minus(TextBox textBox) //метод для кнопки плюса
        {
            int new_text = Int32.Parse(textBox.Text) - 1;
            if (new_text < 1)
            {
                textBox.Text = "1";
            }

            else
            {
                textBox.Text = new_text.ToString();
            }
        }

        public static void data_show(string cs , SQLiteDataReader dr, ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4) //данные из БД в ComboBox
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = $"SELECT model FROM video_cards";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb1.Items.Add(dr.GetString(0));
                cb2.Items.Add(dr.GetString(0));
                cb3.Items.Add(dr.GetString(0));
                cb4.Items.Add(dr.GetString(0));
            }

            string stm2 = $"SELECT model FROM processors";
            var cmd2 = new SQLiteCommand(stm2, con);
            dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                cb1.Items.Add(dr.GetString(0));
                cb2.Items.Add(dr.GetString(0));
                cb3.Items.Add(dr.GetString(0));
                cb4.Items.Add(dr.GetString(0));
            }

            string stm3 = $"SELECT model FROM hdds";
            var cmd3 = new SQLiteCommand(stm3, con);
            dr = cmd3.ExecuteReader();
            while (dr.Read())
            {
                cb1.Items.Add(dr.GetString(0));
                cb2.Items.Add(dr.GetString(0));
                cb3.Items.Add(dr.GetString(0));
                cb4.Items.Add(dr.GetString(0));
            }

            string stm4 = $"SELECT model FROM rams";
            var cmd4 = new SQLiteCommand(stm4, con);
            dr = cmd4.ExecuteReader();
            while (dr.Read())
            {
                cb1.Items.Add(dr.GetString(0));
                cb2.Items.Add(dr.GetString(0));
                cb3.Items.Add(dr.GetString(0));
                cb4.Items.Add(dr.GetString(0));
            }

            string stm5 = $"SELECT model FROM power_units";
            var cmd5 = new SQLiteCommand(stm5, con);
            dr = cmd5.ExecuteReader();
            while (dr.Read())
            {
                cb1.Items.Add(dr.GetString(0));
                cb2.Items.Add(dr.GetString(0));
                cb3.Items.Add(dr.GetString(0));
                cb4.Items.Add(dr.GetString(0));
            }
        }

        public static void Calculate(ComboBox mod, string cs, SQLiteDataReader dr, TextBox priceElec, TextBox capacityText, ComboBox currency, out double[] expensess, out double[] incomess)
        {
            double[] expenses;
            double[] incomes;
            expensess = new double[4] { 0, 0, 0, 0 };
            incomess = new double[4] { 0, 0, 0, 0 };
            string model = mod.Text;
            if (model == "")
            {
                MessageBox.Show("Выберите устройство!");
            }

            else
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                string stm = $@"SELECT consumption, income FROM video_cards WHERE model = '{model}'
	            UNION ALL SELECT consumption, income FROM processors WHERE model = '{model}'
	            UNION ALL SELECT consumption, income FROM hdds WHERE model = '{model}'
	            UNION ALL SELECT consumption, income FROM rams WHERE model = '{model}'
	            UNION ALL SELECT consumption, income FROM power_units WHERE model = '{model}'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    double consumption = dr.GetDouble(0);
                    double income = dr.GetDouble(1);
                    double price = double.Parse(priceElec.Text, System.Globalization.CultureInfo.InvariantCulture);
                    double capacity = double.Parse(capacityText.Text, System.Globalization.CultureInfo.InvariantCulture);
                    Solve(consumption, income, price, capacity, currency, out expenses, out incomes);
                    expensess = expenses;
                    incomess = incomes;
                }
            }
            
            

        }

        public static void Solve(double consumption, double income, double price, double capacity, ComboBox currency, out double[] expenses, out double[] incomes)
        {
            if (currency.Text == "KZT - ₸")
            {
                income = income * 509.18;
            }

            else if (currency.Text == "RUB - ₽")
            {
                income = income * 105.27;
            }
            double expenses1H = consumption * capacity * price;
            double expenses1D = expenses1H * 24;
            double expenses1M = expenses1D * 30;
            double expenses1Y = expenses1M * 12;
            expenses = new double[4] { expenses1H, expenses1D, expenses1M, expenses1Y};

            double income1D = income * 24;
            double income1M = income1D * 30;
            double income1Y = income1M * 12;
            incomes = new double[4] { income, income1D, income1M, income1Y};
        }

        public static void Clear(TextBox price, TextBox capacity_1, TextBox capacity_2, TextBox capacity_3, TextBox capacity_4, ComboBox devices_1, ComboBox devices_2, ComboBox devices_3, ComboBox devices_4, Panel d2, Panel d3, Panel d4, ComboBox currency)
        {
            price.Text = "0.1";
            capacity_1.Text = "1";
            capacity_2.Text = "1";
            capacity_3.Text = "1";
            capacity_4.Text = "1";
            devices_1.Text = "";
            devices_2.Text = "";
            devices_3.Text = "";
            devices_4.Text = "";
            currency.Text = "USD - $";
            d2.Hide();
            d3.Hide();
            d4.Hide();
        }


    }
}
