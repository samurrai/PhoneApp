using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityPhonesApp
{
    public partial class Form1 : Form
    {
        private List<int> phoneCodes;
        public Form1()
        {
            InitializeComponent();

            using (var context = new CityContext())
            {
                int defaultIndex = 0;
                int index = 0;
                phoneCodes = new List<int>();
                foreach (var city in context.Cities)
                {
                    cityBox.Items.Add(city.Name);
                    phoneCodes.Add(city.Number);
                    if (city.Name == "Нур-Султан")
                    {
                        defaultIndex = index;
                    }
                    index++;
                }
                cityBox.SelectedIndex = defaultIndex;
                cityCodeTextBox.Text = phoneCodes[cityBox.SelectedIndex].ToString();
                cityCodeTextBox.ReadOnly = true;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            using (var context = new CityContext())
            {
                if (!string.IsNullOrWhiteSpace(phoneTextBox.Text))
                {
                    if (int.TryParse(phoneTextBox.Text, out int result) && result.ToString().Length == 6)
                    {
                        if (!string.IsNullOrWhiteSpace(infoTextBox.Text)) {
                            var userInfo = new UserInfo
                            {
                                Info = infoTextBox.Text,
                                PhoneNumber = cityCodeTextBox.Text + phoneTextBox.Text
                            };
                            foreach (var city in context.Cities)
                            {
                                if (city.Name == cityBox.Items[cityBox.SelectedIndex].ToString())
                                {
                                    userInfo.City = city;
                                    break;
                                }
                            }
                            context.UserInfo.Add(userInfo);
                            context.SaveChanges();
                            MessageBox.Show("Данные успешно сохранены");
                        }
                        else
                        {
                            MessageBox.Show("Введите данные");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Некорректные данные");
                    }
                }
                else
                {
                    MessageBox.Show("Введите номер телефона");
                }
            }
        }

        private void cityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityCodeTextBox.Text = phoneCodes[cityBox.SelectedIndex].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new CityContext())
            {
                string info = "";
                foreach (var user in context.UserInfo)
                {
                    info += "Город - " + user.City.Name + ", ";
                    info += "номер - " + user.PhoneNumber + ", ";
                    info += "сообщение - " + user.Info + "\n";
                }
                MessageBox.Show(info);
            }
        }
    }
}
