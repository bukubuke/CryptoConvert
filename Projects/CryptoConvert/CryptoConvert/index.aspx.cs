using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CryptoConvert
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCurrency1.Text = "Bitcoin";
            lblCurrency2.Text = "USD";
            if (DarkMode.Visible == true)
            {
                LightMode.Visible = false;
            }
            else
            {
                LightMode.Visible = true;
            }
            lblvalidation.Text = "Please enter a proper value";
            if (bitcoinimage.Visible == true && DarkMode.Visible == true)
            {
                whitebitcoin.Visible = false;
                bitcoinimage.Visible = true;
            }
            else if (bitcoinimage.Visible == false && DarkMode.Visible == false)
            {
                whitebitcoin.Visible = true;
                bitcoinimage.Visible = false;
            }
            refresh();
        }

        protected void txtBoxCurrency1_TextChanged(object sender, EventArgs e)
        {
            refreshcurrency1();
        }
        

        protected void txtBoxCurrency2_TextChanged(object sender, EventArgs e)
        {
            refreshcurrency2();
            
        }
        protected void refreshcurrency2()
        {
            double answer, value2;
            char[] symbols = { '$', '€', '¥' };
            string input = txtBoxCurrency2.Text.TrimStart(symbols); //Removes the currency symbol from input
            if (double.TryParse(input, out value2) && !string.IsNullOrEmpty(txtBoxCurrency2.Text) && value2 >= 0) //Checks if input is a double and check if textbox is empty
            {
                lblvalidation.Visible = false;
                if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 0) //Self Explanatory
                {
                    answer = value2 * 0.000094;
                    string final = string.Format("{0:N8}", answer); //Formats the string to a number and how many decimal places.
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Bitcoin";
                    lblCurrency2.Text = "USD";
                    this.Title = value2.ToString() + " USD " + final + " Bitcoin"; //prints it out
                }
                else if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 1)
                {
                    answer = value2 * 0.0000716;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Bitcoin";
                    lblCurrency2.Text = "SGD";
                    this.Title = value2.ToString() + " SGD " + final + " Bitcoin";
                }
                else if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 2)
                {
                    answer = value2 * 0.0001179;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Bitcoin";
                    lblCurrency2.Text = "EURO";
                    this.Title = value2.ToString() + " EURO " + final + " Bitcoin";
                }
                else if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 3)
                {
                    answer = value2 * 0.00000089815;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Bitcoin";
                    lblCurrency2.Text = "YEN";
                    this.Title = value2.ToString() + " YEN " + final + " Bitcoin";
                }
                if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 0)
                {
                    answer = value2 * 0.001275;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Ethereum";
                    lblCurrency2.Text = "USD";
                    this.Title = value2.ToString() + " USD " + final + " Ethereum";
                }
                else if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 1)
                {
                    answer = value2 * 0.0009625;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Ethereum";
                    lblCurrency2.Text = "SGD";
                    this.Title = value2.ToString() + " SGD " + final + " Ethereum";
                }
                else if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 2)
                {
                    answer = value2 * 0.0009625;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Ethereum";
                    lblCurrency2.Text = "EURO";
                    this.Title = value2.ToString() + " EURO " + final + " Ethereum";
                }
                else if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 3)
                {
                    answer = value2 * 0.000011979;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Ethereum";
                    lblCurrency2.Text = "YEN";
                    this.Title = value2.ToString() + " YEN " + final + " Ethereum";
                }
                if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 0)
                {
                    answer = value2 * 0.00084829;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Bitcoin Cash";
                    lblCurrency2.Text = "USD";
                    this.Title = value2.ToString() + " USD " + final + " Bitcoin Cash";
                }
                else if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 1)
                {
                    answer = value2 * 0.00064554;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Bitcoin Cash";
                    lblCurrency2.Text = "SGD";
                    this.Title = value2.ToString() + " SGD " + final + " Bitcoin Cash";
                }
                else if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 2)
                {
                    answer = value2 * 0.00105338;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Bitcoin Cash";
                    lblCurrency2.Text = "EURO";
                    this.Title = value2.ToString() + " EURO " + final + " Bitcoin Cash";
                }
                else if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 3)
                {
                    answer = value2 * 0.000008014848;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Bitcoin Cash";
                    lblCurrency2.Text = "YEN";
                    this.Title = value2.ToString() + " YEN " + final + " Bitcoin Cash";
                }
                if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 0)
                {
                    answer = value2 * 219.2021043;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Dogecoin";
                    lblCurrency2.Text = "USD";
                    this.Title = value2.ToString() + " USD " + final + " Dogecoin";
                }
                else if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 1)
                {
                    answer = value2 * 166.805671;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Dogecoin";
                    lblCurrency2.Text = "SGD";
                    this.Title = value2.ToString() + " SGD " + final + " Dogecoin";
                }
                else if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 2)
                {
                    answer = value2 * 272.182907;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Dogecoin";
                    lblCurrency2.Text = "EURO";
                    this.Title = value2.ToString() + " EURO " + final + " Dogecoin";
                }
                else if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 3)
                {
                    answer = value2 * 2.0711223;
                    string final = string.Format("{0:N8}", answer);
                    txtBoxCurrency1.Text = final;
                    lblCurrency1.Text = "Dogecoin";
                    lblCurrency2.Text = "YEN";
                    this.Title = value2.ToString() + " YEN " + final + " Dogecoin";
                }
            }
            else if (txtBoxCurrency1.Text == "" || txtBoxCurrency2.Text == "")
            {
                lblvalidation.Visible = false;
                txtBoxCurrency1.Text = ""; txtBoxCurrency2.Text = "";
            }
            else
            {
                lblvalidation.Visible = true;
            }
        }
        protected void refreshcurrency1()
        {
            double answer, value1;
            if (double.TryParse(txtBoxCurrency1.Text, out value1) && !string.IsNullOrEmpty(txtBoxCurrency1.Text) && value1 >= 0)
            {
                lblvalidation.Visible = false;
                if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 0)
                {
                    answer = value1 * 10716.94;
                    string final = string.Format("${0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Bitcoin"; //Changes the text at the top
                    lblCurrency2.Text = "USD"; //Same as top^
                    this.Title = value1.ToString() + " Bitcoin " + final + " USD"; //This changes the title webpage.
                }
                else if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 1)
                {
                    answer = value1 * 14168.90;
                    string final = string.Format("${0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Bitcoin";
                    lblCurrency2.Text = "SGD";
                    this.Title = value1.ToString() + " Bitcoin " + final + " SGD";
                }
                else if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 2)
                {
                    answer = value1 * 8668.63;
                    string final = string.Format("€{0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Bitcoin";
                    lblCurrency2.Text = "EURO";
                    this.Title = value1.ToString() + " Bitcoin " + final + " EURO";
                }
                else if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 3)
                {
                    answer = value1 * 1137608.05;
                    string final = string.Format("¥{0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Bitcoin";
                    lblCurrency2.Text = "YEN";
                    this.Title = value1.ToString() + " Bitcoin " + final + " YEN";
                }

                if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 0)
                {
                    answer = value1 * 812.497;
                    string final = string.Format("${0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Ethereum";
                    lblCurrency2.Text = "USD";
                    this.Title = value1.ToString() + " Ethereum " + final + " USD";
                }
                else if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 1)
                {
                    answer = value1 * 1071.50;
                    string final = string.Format("${0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Ethereum";
                    lblCurrency2.Text = "SGD";
                    this.Title = value1.ToString() + " Ethereum " + final + " SGD";
                }
                else if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 2)
                {
                    answer = value1 * 655.28;
                    string final = string.Format("€{0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Ethereum";
                    lblCurrency2.Text = "EURO";
                    this.Title = value1.ToString() + " Ethereum " + final + " EURO";
                }
                else if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 3)
                {
                    answer = value1 * 85977.37;
                    string final = string.Format("¥{0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Ethereum";
                    lblCurrency2.Text = "YEN";
                    this.Title = value1.ToString() + " Ethereum " + final + " YEN";
                }
                if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 0)
                {
                    answer = value1 * 1202.05;
                    string final = string.Format("${0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Bitcoin Cash";
                    lblCurrency2.Text = "USD";
                    this.Title = value1.ToString() + " Bitcoin Cash " + final + " USD";
                }
                else if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 1)
                {
                    answer = value1 * 1581.01;
                    string final = string.Format("${0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Bitcoin Cash";
                    lblCurrency2.Text = "SGD";
                    this.Title = value1.ToString() + " Bitcoin Cash " + final + " SGD";
                }
                else if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 2)
                {
                    answer = value1 * 967.02;
                    string final = string.Format("€{0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Bitcoin Cash";
                    lblCurrency2.Text = "EURO";
                    this.Title = value1.ToString() + " Bitcoin Cash " + final + " EURO";
                }
                else if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 3)
                {
                    answer = value1 * 126944.93;
                    string final = string.Format("¥{0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Bitcoin Cash";
                    lblCurrency2.Text = "YEN";
                    this.Title = value1.ToString() + " Bitcoin Cash " + final + " YEN";
                }
                if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 0)
                {
                    answer = value1 * 0.004620;
                    string final = string.Format("${0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Dogecoin";
                    lblCurrency2.Text = "USD";
                    this.Title = value1.ToString() + " Dogecoin " + final + " USD";
                }
                else if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 1)
                {
                    answer = value1 * 0.006103;
                    string final = string.Format("${0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Dogecoin";
                    lblCurrency2.Text = "SGD";
                    this.Title = value1.ToString() + " Dogecoin " + final + " SGD";
                }
                else if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 2)
                {
                    answer = value1 * 0.003733;
                    string final = string.Format("€{0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Dogecoin";
                    lblCurrency2.Text = "EURO";
                    this.Title = value1.ToString() + " Dogecoin " + final + " EURO";
                }
                else if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 3)
                {
                    answer = value1 * 0.490058;
                    string final = string.Format("¥{0:N2}", answer);
                    txtBoxCurrency2.Text = final;
                    lblCurrency1.Text = "Dogecoin";
                    lblCurrency2.Text = "YEN";
                    this.Title = value1.ToString() + " Dogecoin " + final + " YEN";
                }
            }
            else if (txtBoxCurrency1.Text == "" || txtBoxCurrency1.Text == "")
            {
                lblvalidation.Visible = false;
                txtBoxCurrency1.Text = ""; txtBoxCurrency2.Text = "";
            }
            else
            {
                lblvalidation.Visible = true;
            }
        }

        protected void DarkMode_Click(object sender, EventArgs e)
        {
            this.main.Style.Add("background-color", "#333333");
            this.top.Style.Add("background-color", "#262626");
            this.top.Style.Add("color", "#F8F8F8");
            this.currency1.Style.Add("background-color", "#303030");
            this.currency1.Style.Add("color", "#F8F8F8");
            this.currency2.Style.Add("background-color", "#303030");
            this.currency2.Style.Add("color", "#F8F8F8");
            this.txtBoxCurrency1.Style.Add("background-color", "#303030");
            this.txtBoxCurrency1.Style.Add("color", "#F8F8F8");
            this.txtBoxCurrency2.Style.Add("background-color", "#303030");
            this.txtBoxCurrency2.Style.Add("color", "#F8F8F8");
            this.mid.Style.Add("color", "#F8F8F8");
            this.footer.Style.Add("color", "#F8F8F8");
            this.footer.Style.Add("background-color", "#303030");
            //this.description.Style.Add("color", "#F8F8F8");
            bitcoinimage.Visible = false;
            whitebitcoin.Visible = true;
            DarkMode.Visible = false;
            LightMode.Visible = true;
        }

        protected void LightMode_Click(object sender, EventArgs e)
        {
            this.main.Style.Remove("background-color");
            this.top.Style.Remove("background-color");
            this.top.Style.Remove("color");
            this.currency1.Style.Remove("background-color");
            this.currency1.Style.Remove("color");
            this.currency2.Style.Remove("background-color");
            this.currency2.Style.Remove("color");
            this.txtBoxCurrency1.Style.Remove("background-color");
            this.txtBoxCurrency1.Style.Remove("color");
            this.txtBoxCurrency2.Style.Remove("background-color");
            this.txtBoxCurrency2.Style.Remove("color");
            this.mid.Style.Remove("color");
            this.footer.Style.Remove("color");
            this.footer.Style.Remove("background-color");
            //this.description.Style.Remove("color");
            bitcoinimage.Visible = true;
            whitebitcoin.Visible = false;
            DarkMode.Visible = true;
            LightMode.Visible = false;
        }

        protected void currency1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
            refreshcurrency1();//This refreshes and gives the new value of the changed box.
        }

        protected void currency2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
            refreshcurrency1();//This refreshes and gives the new value of the changed box.
        }
        private void refresh()
        {
            if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 0)
            {
                lblCurrency1.Text = "Bitcoin";
                lblCurrency2.Text = "USD";
            }
            else if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 1)
            {
                lblCurrency1.Text = "Bitcoin";
                lblCurrency2.Text = "SGD";
            }
            else if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 2)
            {
                lblCurrency1.Text = "Bitcoin";
                lblCurrency2.Text = "EURO";
            }
            else if (currency1.SelectedIndex == 0 && currency2.SelectedIndex == 3)
            {
                lblCurrency1.Text = "Bitcoin";
                lblCurrency2.Text = "YEN";
            }
            else if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 0)
            {
                lblCurrency1.Text = "Ethereum";
                lblCurrency2.Text = "USD";
            }
            else if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 1)
            {
                lblCurrency1.Text = "Ethereum";
                lblCurrency2.Text = "SGD";
            }
            else if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 2)
            {
                lblCurrency1.Text = "Ethereum";
                lblCurrency2.Text = "EURO";
            }
            else if (currency1.SelectedIndex == 1 && currency2.SelectedIndex == 3)
            {
                lblCurrency1.Text = "Ethereum";
                lblCurrency2.Text = "YEN";
            }
            else if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 0)
            {
                lblCurrency1.Text = "Bitcoin Cash";
                lblCurrency2.Text = "USD";
            }
            else if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 1)
            {
                lblCurrency1.Text = "Bitcoin Cash";
                lblCurrency2.Text = "SGD";
            }
            else if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 2)
            {
                lblCurrency1.Text = "Bitcoin Cash";
                lblCurrency2.Text = "EURO";
            }
            else if (currency1.SelectedIndex == 2 && currency2.SelectedIndex == 3)
            {
                lblCurrency1.Text = "Bitcoin Cash";
                lblCurrency2.Text = "YEN";
            }
            else if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 0)
            {
                lblCurrency1.Text = "Dogecoin";
                lblCurrency2.Text = "USD";
            }
            else if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 1)
            {
                lblCurrency1.Text = "Dogecoin";
                lblCurrency2.Text = "SGD";
            }
            else if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 2)
            {
                lblCurrency1.Text = "Dogecoin";
                lblCurrency2.Text = "EURO";
            }
            else if (currency1.SelectedIndex == 3 && currency2.SelectedIndex == 3)
            {
                lblCurrency1.Text = "Dogecoin";
                lblCurrency2.Text = "YEN";
            }
        }
    }
}