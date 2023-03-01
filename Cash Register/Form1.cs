using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{

    public partial class Form1 : Form
    {
        double TunaPrices = 250, SalmonPrices = 200, ShrimpPrices = 190;
        double TaxRate = .10;
        double subtotal, tax, total;
        double tendred, change;
        int Tuna, Salmon, Shrimp;

        


        private void neworderButton_Click(object sender, EventArgs e)
        {
            //clear
            numOfTunaInput.Text = $"";
            numOfSalmonInput.Text = $"";
            numOfShrimpInput.Text = $"";
            subTotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalOutput.Text = $"";
            tendredInput.Text = $"";
            changeOutput.Text = $"";
            receiptNumOutput.Text = $"";
            receiptTitle.Text = $"";
            receiptWordOutput.Text = $"";
            errorLabel1.Hide();
            errorLabel2.Hide();
            errorLabel3.Hide();
            subtotal = 0;
            tax = 0;
            total = 0;
            tendred= 0;
            change = 0;
            Tuna = 0;
            Salmon = 0;
            Shrimp= 0;

            changeButton.Enabled = false;
            printButton.Enabled = false;   

        }

         

        private void printButton_Click(object sender, EventArgs e)
        {
            //sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptsound);

            player.Play();

            //random system
            Random rnd = new Random();
            int value = rnd.Next(1000, 5000);
            Console.Write(value);

            //output
            this.Refresh();
            Thread.Sleep(700);
            receiptTitle.Text = $"寿司屋";
            this.Refresh();
            Thread.Sleep(510);
            receiptWordOutput.Text = $"Order Number {value}";
            this.Refresh();
            Thread.Sleep(510);
            receiptWordOutput.Text += $"\n {DateTime.Now}";

            this.Refresh();
            Thread.Sleep(510);
            receiptWordOutput.Text += $"\n\nTuna     x{Tuna}";
            receiptNumOutput.Text = $"{TunaPrices * Tuna}￥";

            this.Refresh();
            Thread.Sleep(610);
            receiptWordOutput.Text += $"\nSalmon  x{Salmon}";
            receiptNumOutput.Text += $"\n{SalmonPrices * Salmon}￥";

            this.Refresh();
            Thread.Sleep(510);
            receiptWordOutput.Text += $"\nShrimp   x{Shrimp}";
            receiptNumOutput.Text += $"\n{ShrimpPrices * Shrimp}￥";

            this.Refresh();
            Thread.Sleep(610);
            receiptWordOutput.Text += $"\n\nSubtotal";
            receiptNumOutput.Text += $"\n\n{subtotal}￥";

            this.Refresh();
            Thread.Sleep(510);
            receiptWordOutput.Text += $"\nTax";
            receiptNumOutput.Text += $"\n{tax}￥";

            this.Refresh();
            Thread.Sleep(500);
            receiptWordOutput.Text += $"\nTotal";
            receiptNumOutput.Text += $"\n{total}￥";

            this.Refresh();
            Thread.Sleep(610);
            receiptWordOutput.Text += $"\n\nTendred";
            receiptNumOutput.Text += $"\n\n{tendred}￥";

            this.Refresh();
            Thread.Sleep(510);
            receiptWordOutput.Text += $"\nChange";
            receiptNumOutput.Text += $"\n{change}￥";

            this.Refresh();
            Thread.Sleep(610);
            receiptWordOutput.Text += $"\n\n\n🍣Have a Nice Day!!";



        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            errorLabel2.Hide();
            try
            {

                //do calculation
                tendred = Convert.ToInt32(tendredInput.Text);
                change = tendred - total;

                //output
                changeOutput.Text = $"{change}￥";

                //error message
                if (change < 0)
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.errorsound);
                    player.Play();
                }
                if (change < 0) { errorLabel2.Show(); }
                if (change < 0) { tendredInput.Text = $""; }
                if (change < 0) { changeOutput.Text = $""; }
                errorLabel2.Text = $"ERROR";
                errorLabel2.Text += $"\nPlease enter the number";
                errorLabel2.Text += $"\nbigger than total";

                //unlock button
                if (change > 0) { printButton.Enabled = true; }
            }

            catch
            {
                //error message
                SoundPlayer player = new SoundPlayer(Properties.Resources.errorsound);
                player.Play();
                tendredInput.Text = $"";
                changeOutput.Text = $"";
                errorLabel2.Show();
                errorLabel2.Text = $"ERROR";
                errorLabel2.Text += $"\nPlease enter the";
                errorLabel2.Text += $"\nnumber";

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            errorLabel1.Hide();
            
            try
            {


                //get input
                Tuna = Convert.ToInt16(numOfTunaInput.Text);
                Salmon = Convert.ToInt16(numOfSalmonInput.Text);
                Shrimp = Convert.ToInt16(numOfShrimpInput.Text);

                //do calculation
                subtotal = TunaPrices * Tuna + SalmonPrices * Salmon + ShrimpPrices * Shrimp;
                tax = subtotal * TaxRate;
                total = subtotal + tax;

                //output
                subTotalOutput.Text = $"{subtotal} ￥";
                taxOutput.Text = $"{tax} ￥";
                totalOutput.Text = $"{total} ￥";



                // error message
                if (Tuna + Salmon + Shrimp > 100)
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.errorsound);
                    player.Play();
                }
                if (Tuna + Salmon + Shrimp > 100) { subTotalOutput.Text = $""; }
                if (Tuna + Salmon + Shrimp > 100) { taxOutput.Text = $""; }
                if (Tuna + Salmon + Shrimp > 100) { totalOutput.Text = $""; }
                if (Tuna + Salmon + Shrimp > 100) { numOfTunaInput.Text = $""; }
                if (Tuna + Salmon + Shrimp > 100) { numOfSalmonInput.Text = $""; }
                if (Tuna + Salmon + Shrimp > 100) { numOfShrimpInput.Text = $""; }
                if (Tuna + Salmon + Shrimp > 100) { errorLabel1.Show(); }
                if (Tuna + Salmon + Shrimp > 100) { errorLabel1.Text = $"ERROR"; }
                if (Tuna + Salmon + Shrimp > 100) { errorLabel1.Text += $"\nPlease order as much as\nyou can eat!!!!!"; }

                //unlock button
                changeButton.Enabled = true;
                if (Tuna + Salmon + Shrimp > 100) { changeButton.Enabled = false; }
            }

            catch
            {
                //error message
                SoundPlayer player = new SoundPlayer(Properties.Resources.errorsound);
                player.Play();
                numOfTunaInput.Text = $"";
                numOfSalmonInput.Text = $"";
                numOfShrimpInput.Text = $"";
                errorLabel1.Show();
                errorLabel1.Text = $"ERROR";
                errorLabel1.Text += $"\nPlease enter the";
                errorLabel1.Text += $"\nnumber";


            }
        }
    }
}
