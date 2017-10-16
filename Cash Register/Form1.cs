//Tyler Tucker
//October 16, 2017
//This code is a cash register system that takes inputs of amouts of products, and outputs prices, change, and recipts



using System;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register
{

    public partial class bapeForm : Form
    {
        int numberRifles;                //making global variables
        int numberPistols;
        int numberRpg;
        const int COST_RIFLES = 210;
        const int COST_PISTOLS = 120;
        const int COST_RPG = 525;
        const double TAX = 0.13;
        double tendered;
        double subtotal;
        double taxOfSold;
        double total;
        double change;

        SolidBrush drawBrush = new SolidBrush(Color.Peru);       //makes brushes, fonts, ex
        SolidBrush drawBrushWrite = new SolidBrush(Color.Black);
        Font drawFontTitle = new Font("Impact", 12, FontStyle.Regular);
        Font drawFontAddress = new Font("Impact", 7, FontStyle.Regular);
        Font drawFontProducts = new Font("Impact", 8, FontStyle.Regular);
        SoundPlayer Printer = new SoundPlayer(Properties.Resources.Printer);
        SoundPlayer Error = new SoundPlayer(Properties.Resources.Error);
        SoundPlayer CashDing = new SoundPlayer(Properties.Resources.Cash_Ding);
        SoundPlayer Stopit = new SoundPlayer(Properties.Resources.Stopit);

        public bapeForm()
        {
            InitializeComponent();
            reciptButton.Visible = false;
            riflesInput.Text = Convert.ToString (0);     //sets everthing to 0
            pistolsInput.Text = Convert.ToString(0);
            rpgInput.Text = Convert.ToString(0);
            tenderedInput.Text = Convert.ToString(0);
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                numberRifles = Convert.ToInt16(riflesInput.Text);       //declares varibles needed in this button push, plus sounds
                numberPistols = Convert.ToInt16(pistolsInput.Text);
                numberRpg = Convert.ToInt16(rpgInput.Text);
                subtotal = (numberRifles * COST_RIFLES) + (numberPistols * COST_PISTOLS) + (numberRpg * COST_RPG);
                taxOfSold = subtotal * TAX;
                total = subtotal + taxOfSold;

                subtotalOutput.Text = subtotal.ToString("C");      //shows, subtotal, tax, and total
                Refresh();
                CashDing.PlaySync();
                taxOutput.Text = taxOfSold.ToString("C");
                Refresh();
                CashDing.PlaySync();
                totalOutput.Text = total.ToString("C");
                Refresh();
                CashDing.PlaySync();
            }
            catch
            {
                Error.Play();
                errorMessage.Text = "Error: must enter valid number! ";   //if valid number is not inputedor inputed wrong, message shows
                Refresh();
                Thread.Sleep(2000);
                errorMessage.Text = "";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);         //declares extra variables needed in this button push, plus sounds
                change = tendered - total;

                if (change > -0.01)
                {                                                      //shows change if change is more than -.01
                    changeOutput.Text = change.ToString("C");
                    CashDing.Play();
                }
                else
                {
                    Error.Play();
                    errorMessage.Text = "Not Enough Cash";     //if not shows theres not enough cash
                    Refresh();
                    Thread.Sleep(2000);
                    errorMessage.Text = "";
                }
            }
            catch
            {
                Error.Play();
                errorMessage.Text = "Must enter tendered";     //if tendered value is not valid, shows this message
                Thread.Sleep(2000);
                errorMessage.Text = "";
                return;
            }
            reciptButton.Visible = true;

        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics(); //makes graphics

            Printer.Play();
            fg.FillRectangle(drawBrush, 327, 43, 250, 375);                                //plays sound, makes recpit
            fg.DrawString("Bape Guns", drawFontTitle, drawBrushWrite, 415, 65);
            Thread.Sleep(500);
            fg.DrawString("123 Whocares St", drawFontAddress, drawBrushWrite, 418, 85);
            Thread.Sleep(500);

            if (numberRifles > 0)
                fg.DrawString(numberRifles + "x  Rifles" + "                        @" + COST_RIFLES.ToString("C"), drawFontProducts, drawBrushWrite, 375, 150);
            Thread.Sleep(500);

            if (numberPistols > 0)
                fg.DrawString(numberPistols + "x  Pistols" + "                      @" + COST_PISTOLS.ToString("C"), drawFontProducts, drawBrushWrite, 375, 170);
            Thread.Sleep(500);

            if (numberRpg > 0)
                fg.DrawString(numberRpg + "x  RPGs" + "                          @" + COST_RPG.ToString("C"), drawFontProducts, drawBrushWrite, 375, 190);
            Thread.Sleep(500);

            fg.DrawString("-------------------------------------------------------------", drawFontProducts, drawBrushWrite, 355, 210);
            Thread.Sleep(500);
            fg.DrawString("Subtotal:   " + subtotal.ToString("C"), drawFontProducts, drawBrushWrite, 355, 230);
            Thread.Sleep(500);
            fg.DrawString("Tax:  " + taxOfSold.ToString("C"), drawFontProducts, drawBrushWrite, 355, 250);
            Thread.Sleep(500);
            fg.DrawString("Total:  " + total.ToString("C"), drawFontProducts, drawBrushWrite, 355, 270);
            Thread.Sleep(500);
            fg.DrawString("Tendered:  " + tendered.ToString("C"), drawFontProducts, drawBrushWrite, 355, 290);
            Thread.Sleep(500);
            fg.DrawString("Change:  " + change.ToString("C"), drawFontProducts, drawBrushWrite, 355, 310);
            Thread.Sleep(500);
            fg.DrawString("Thanks for your money", drawFontProducts, drawBrushWrite, 393, 340);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics(); //makes graphics
            reciptButton.Visible = false;
            riflesInput.Text = Convert.ToString(0);
            pistolsInput.Text = Convert.ToString(0);
            rpgInput.Text = Convert.ToString(0);
            tenderedInput.Text = Convert.ToString(0);     //clears outputs
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";
            Refresh();
        }

        private void bapeForm_Deactivate(object sender, EventArgs e)
        {
            Stopit.PlaySync(); //plays sound
        }
        
    }
}
