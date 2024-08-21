using DataCanVirtualBank;
using VirtualBankWinForms.Properties;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace VirtualBankWinForms
{
    public partial class Form1 : Form
    {
        //Global variables:
        public int accountId = 421;
        public float amount = 5000;
        public string firstName = "Lina";
        public string lastName = "Silva";

        public Form1()
        {
            InitializeComponent();

        }

        //Function
        public string SetFullName(Customer customer) {
            customer.SetName(firstName);
            customer.SetLastName(lastName);
            return string.Concat("Welcome, " + customer.GetName() + " " + customer.GetLastName() + "!");
        }

        private void textBox1_Welcome(object sender, EventArgs e)
        {
            var customer = new Customer();
            var txt = SetFullName(customer);
            txt_welcome.Text = txt;
        }

        private void txt_balance_TextChanged(object sender, EventArgs e)
        {
            var customer = new Customer();
            //SetFullName(customer);
            customer.CheckingAccounts.Add(new CheckingAccount(accountId, amount));
            var balance = customer.CheckingAccounts[0].GetBalance();
            txt_balance.Text = amount.ToString(); //balance.ToString();
        }

        private void cbb_account_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = new Customer();
            //SetFullName(customer);
            customer.CheckingAccounts.Add(new CheckingAccount(accountId, amount));
            List<CheckingAccount> customerAccounts = new List<CheckingAccount>();
            //cbb_account.DataSource = customerAccounts;
            //cbb_account.ValueMember = "id";
            //cbb_account.DisplayMember = "balance";
            //var accountId = customer.CheckingAccounts[0].GetAccountId();
            //obtener lista de cuentas
            //cbb_account.Items = accountId.ToString();//List<accountId.ToString()>;
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            float amount = 0;
            try
            {
                amount = float.Parse(txt_amount.Text);
                // Possible improvement: Search regular expression to verify all entries 12,2,3, should'n be working
            }
            catch
            {
                MessageBox.Show("This field must be a number. Format: 1,234.50");
            }

        }

        private void cbb_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The currency choiced is: " + cbb_currency.SelectedItem.ToString());
            /*List<ExchangeRate> exchangeRateslst = new List<ExchangeRate>();
            exchangeRateslst.Add(new ExchangeRate() { _id = 1, _currency = "USD" });
            exchangeRateslst.Add(new ExchangeRate() { _id = 2, _currency = "MXN" });
            exchangeRateslst.Add(new ExchangeRate() { _id = 3, _currency = "EUR" });
            exchangeRateslst.Add(new ExchangeRate() { _id = 4, _currency = "CAD" });
            cbb_currency.DataSource = exchangeRateslst;
            cbb_currency.ValueMember = "_id";
            cbb_currency.DisplayMember = "_currency"; //"_rateValue"; */

        }

        private void cbb_currency_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbb_currency.SelectedItem.ToString();
            //MessageBox.Show(cbb_currency.SelectedItem.ToString());
            /*ExchangeRate obj = cbb_currency.SelectedItem as ExchangeRate;
            if (obj != null)
            {
                MessageBox.Show(string.Format("Currency = {0}", obj._id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information));
            }*/
        }


        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            var selectedCurrency = cbb_currency.SelectedItem.ToString();
            var customer = new Customer();
            customer.CheckingAccounts.Add(new CheckingAccount(accountId, amount));
            var transactionValue = customer.CheckingAccounts[0].Withdraw(float.Parse(txt_amount.Text), selectedCurrency);
            if (transactionValue > float.Parse(txt_amount.Text))
            {
                MessageBox.Show("Your current balance does not allow you to perform the transaction: " + txt_amount.Text);
                //throw new ArgumentException("Balance", "Your current balance does not allow you to perform the transaction");
            }else
            {
                //tst
                //update_balance(transactionValue);
                txt_balance.Text = (float.Parse(txt_balance.Text) - transactionValue).ToString();
                MessageBox.Show("Your new Balance is: " + transactionValue.ToString());
            }
            //txt_balance.Text = newBalance.ToString();

        }

        /* private void update_balance(float value) 
        {
            txt_balance.Text = (float.Parse(txt_balance.Text)+value).ToString();
        }*/

        private void btn_load_customer_Click(object sender, EventArgs e)
        {
            textBox1_Welcome(txt_welcome, e);
            txt_balance_TextChanged(txt_balance, e);
            cbb_account_SelectedIndexChanged(cbb_account, e);

        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            var selectedCurrency = cbb_currency.SelectedItem.ToString();
            var customer = new Customer();
            customer.CheckingAccounts.Add(new CheckingAccount(accountId, amount));
            var transactionValue = customer.CheckingAccounts[0].Deposit(float.Parse(txt_amount.Text), selectedCurrency);
            //
            //txt_balance.Text = (float.Parse(txt_balance.Text) - transactionValue).ToString();
            var amountCalculate = amount - transactionValue;
            txt_balance.Text = amountCalculate.ToString();// (amount - transactionValue).ToString();
            amount = amountCalculate;
            MessageBox.Show("Your new Balance is: " + transactionValue.ToString());
        }
    }
}
