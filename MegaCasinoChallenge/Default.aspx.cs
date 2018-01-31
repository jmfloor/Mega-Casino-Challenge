using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaCasinoChallenge
{
    public partial class Default : System.Web.UI.Page
    {

        Random randomNumber = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                int money = 100;
                ViewState.Add("Money", money);
                moneyLabel.Text = money.ToString();
            }
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {

            

            if (!int.TryParse(betTextBox.Text, out int betValue)) return;
        
            int multiplier = pullLever();
            int winnings = multiplier * betValue;

            resultLabel.Text = "You won " + winnings.ToString();

            int money = int.Parse(ViewState["Money"].ToString());
            money = money - betValue + winnings;

            ViewState["Money"] = money;

            resultLabel.Text = (multiplier > 0) ?
                String.Format("Congratulations, you bet {0:C} and won {1:C}", betValue.ToString(), winnings.ToString())
                : String.Format("Sorry, you lost {0:C}.", betValue.ToString());

            moneyLabel.Text = String.Format("Players Money: {0:C}", money.ToString());

        }

        private int pullLever()
        {
            string[] reels = new string[] { spinReels(), spinReels(), spinReels() };

            setReelImages(reels);

            return returnMultiplier(reels);

        }

        private void setReelImages(string[] reels)
        {
            reelOneImage.ImageUrl = reels[0];
            reelTwoImage.ImageUrl = reels[1];
            reelThreeImage.ImageUrl = reels[2];
        }

        private string spinReels()
        {
            string[] sourceImages = new string[12] { "Bar.png", "Bell.png", "Cherry.png", "Clover.png",
                                                    "Diamond.png", "HorseShoe.png", "Lemon.png",
                                                    "Orange.png", "Plum.png", "Seven.png", "Strawberry.png",
                                                    "Watermellon.png" };
            
           return "Images/" + sourceImages[randomNumber.Next(0, 11)];

            
        }
        private int returnMultiplier(string[] reels)
        {
            
            bool isJackPot = true;

            int multiplier = 1;
            
            for (int i = 0; i < 3; i++)
            {
                if (!reels[i].Contains("Bar"))
                {
                    if (reels[i].Contains("Cherry")) multiplier++;

                    if (!reels[i].Contains("Seven")) isJackPot = false;
                }
                else
                    {
                        isJackPot = false;
                        multiplier = 0;
                        break;
                    }
            }

            if (isJackPot) multiplier = 100;
            
            return multiplier;
        }
        
    }
}