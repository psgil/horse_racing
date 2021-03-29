using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace horse_racing
{
    public partial class Form1 : Form
    {
        int Gurpreet = 100, Manpreet = 100, Harpreet = 100;
        int win = 0;
        //create the instance of the object 
        Gurpreet gurpreet = new Gurpreet(0,0,0);
        Manpreet manpreet = new Manpreet(0, 0, 0);
        Harpreet harpreet = new Harpreet(0, 0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        // when click on start btn timer function will run
        private void start_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // creating instance for timer
            Better bet = new Better();
            horse1.Top -= bet.genNumber();
            horse2.Top -= bet.genNumber();
            horse3.Top -= bet.genNumber();
            horse4.Top -= bet.genNumber();

            if (horse1.Top<180 ) {
                timer1.Stop();
                
                win = 1;
                if (gurpreet.bet > 0)
                {
                    Gurpreet = gurpreet.budgetRest(1);
                }
                if (harpreet.bet > 0)
                {
                    Harpreet = harpreet.budgetRest(1);
                }
                if (manpreet.bet > 0)
                {
                    Manpreet = manpreet.budgetRest(1);
                }
                

                select_Amount.Value = 0;
                player_select.Text = "";
                horse_select.Text = "";

                MessageBox.Show("Horse 1 won the race ");
                gurpreet_has.Text = "Gurpreet has " + Gurpreet;
                manpreet_has.Text = "Manpreet has " + Manpreet;
                harpreet_has.Text = "Harpreet has " + Harpreet;

                 gurpreet = new Gurpreet(0, 0, 0);
                 manpreet = new Manpreet(0, 0, 0);
                 harpreet = new Harpreet(0, 0, 0);

                horse1.Top = 546;
                horse2.Top = 546;
                horse3.Top = 546;
                horse4.Top = 546;
                start_btn.Visible = false;
            }

            if (horse2.Top < 180)
            {
                timer1.Stop();
                win = 2;
                if (gurpreet.bet > 0)
                {
                    Gurpreet = gurpreet.budgetRest(2);
                }
                if (harpreet.bet > 0)
                {
                    Harpreet = harpreet.budgetRest(2);
                }
                if (manpreet.bet > 0)
                {
                    Manpreet = manpreet.budgetRest(2);
                }

                select_Amount.Value = 0;
                player_select.Text = "";
                horse_select.Text = "";
                gurpreet = new Gurpreet(0, 0, 0);
                manpreet = new Manpreet(0, 0, 0);
                harpreet = new Harpreet(0, 0, 0);


                MessageBox.Show("Horse 2 won the race ");
                gurpreet_has.Text = "Gurpreet has " + Gurpreet;
                manpreet_has.Text = "Manpreet has " + Manpreet;
                harpreet_has.Text = "Harpreet has " + Harpreet;

                horse1.Top = 546;
                horse2.Top = 546;
                horse3.Top = 546;
                horse4.Top = 546;

                start_btn.Visible = false;
            }

            if (horse3.Top < 180)
            {
                timer1.Stop();
                win = 3;
                if (gurpreet.bet > 0)
                {
                    Gurpreet = gurpreet.budgetRest(3);
                }
                if (harpreet.bet > 0)
                {
                    Harpreet = harpreet.budgetRest(3);
                }
                if (manpreet.bet > 0)
                {
                    Manpreet = manpreet.budgetRest(3);
                }

                select_Amount.Value = 0;
                player_select.Text = "";
                horse_select.Text = "";


                MessageBox.Show("Horse 3 won the race ");
                gurpreet = new Gurpreet(0, 0, 0);
                manpreet = new Manpreet(0, 0, 0);
                harpreet = new Harpreet(0, 0, 0);

                gurpreet_has.Text = "Gurpreet has " + Gurpreet;
                manpreet_has.Text = "Manpreet has " + Manpreet;
                harpreet_has.Text = "Harpreet has " + Harpreet;

                horse1.Top = 546;
                horse2.Top = 546;
                horse3.Top = 546;
                horse4.Top = 546;

                start_btn.Visible = false;
            }

            if (horse4.Top < 180)
            {
                timer1.Stop();
                win = 4;
                if (gurpreet.bet>0) {
                    Gurpreet = gurpreet.budgetRest(4);
                }
                if (harpreet.bet>0) {
                    Harpreet = harpreet.budgetRest(4);
                }
                if (manpreet.bet > 0) {
                    Manpreet = manpreet.budgetRest(4);
                }

                select_Amount.Value = 0;
                player_select.Text = "";
                horse_select.Text = "";

                MessageBox.Show("Horse 4 won the race ");
                gurpreet = new Gurpreet(0, 0, 0);
                manpreet = new Manpreet(0, 0, 0);
                harpreet = new Harpreet(0, 0, 0);

                gurpreet_has.Text = "Gurpreet has " + Gurpreet;
                manpreet_has.Text = "Manpreet has " + Manpreet;
                harpreet_has.Text = "Harpreet has " + Harpreet;


                horse1.Top = 546;
                horse2.Top = 546;
                horse3.Top = 546;
                horse4.Top = 546;
                start_btn.Visible = false;

            }
       
        }

        private void gurpreet_has_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //now add the name of the player 
            player_select.Items.Add("Gurpreet");
            player_select.Items.Add("Manpreet");
            player_select.Items.Add("Harpreet");

            horse_select.Items.Add("1");
            horse_select.Items.Add("2");
            horse_select.Items.Add("3");
            horse_select.Items.Add("4");


            start_btn.Visible = false;


        }

        // betting button coding that is working acording to the if conditions 

        private void beting_btn_Click(object sender, EventArgs e)
        {
            if (player_select.Text.Equals("Gurpreet") && !horse_select.Text.ToString().Equals(""))
            {
                if (Gurpreet > 0 && Gurpreet >= Convert.ToInt32(select_Amount.Value))
                {
                    gurpreet_has.Text = "Gurpreet-" + horse_select.Text + "-" + select_Amount.Value;
                    gurpreet = new Gurpreet(Convert.ToInt32(select_Amount.Value), Convert.ToInt32(horse_select.Text.ToString()), Gurpreet);
                    start_btn.Visible = true;
                }
                else {
                    MessageBox.Show("Check your Budget ");
                }
            }
            else if (player_select.Text.Equals("Manpreet") && !horse_select.Text.ToString().Equals(""))
            {
                if (Manpreet > 0 && Manpreet >= Convert.ToInt32(select_Amount.Value))
                {
                    manpreet_has.Text = "Manpreet-" + horse_select.Text + "-" + select_Amount.Value;
                    manpreet = new Manpreet(Convert.ToInt32(select_Amount.Value), Convert.ToInt32(horse_select.Text.ToString()), Manpreet);
                    start_btn.Visible = true;
                }
                else
                {
                    MessageBox.Show("Check your Budget ");
                }
            }

            else if (player_select.Text.Equals("Harpreet") && !horse_select.Text.ToString().Equals(""))
            {
                if (Harpreet > 0 && Harpreet >= Convert.ToInt32(select_Amount.Value))
                {
                    harpreet_has.Text = "Harpreet-" + horse_select.Text + "-" + select_Amount.Value;
                    harpreet = new Harpreet(Convert.ToInt32(select_Amount.Value), Convert.ToInt32(horse_select.Text.ToString()), Harpreet);
                    start_btn.Visible = true;
                }
                else
                {
                    MessageBox.Show("Check your Budget ");
                }
            }
            else {
                MessageBox.Show("You need to select ALl details ");
            }
        }
    }
}
