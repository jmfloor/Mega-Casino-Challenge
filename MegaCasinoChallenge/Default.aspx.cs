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
            //actions when leverButton is pulled

            //select random pictures for each reel
            
            spinReels();


            //determine if it is a winning combinationn

            if (int.TryParse(betTextBox.Text, out int betValue)) ;

                        
            int multiplier = returnMultiplier() * betValue;

            resultLabel.Text = "You won " + multiplier.ToString();

            int money = int.Parse(ViewState["Money"].ToString());
            money = money - betValue + multiplier;

            ViewState["Money"] = money;

            moneyLabel.Text = money.ToString();
            
            //Add viewstate to save money and recall money values

            // update the money

        }

        private int returnMultiplier()
        {
            string[] reelValues = new string[3];

            bool isJackPot = true;

            reelValues[0] = reelOneImage.ImageUrl;
            reelValues[1] = reelTwoImage.ImageUrl;
            reelValues[2] = reelThreeImage.ImageUrl;

            int multiplier = 1;
            

            for (int i = 0; i < 3; i++)
            {
                if (!reelValues[i].Contains("Bar"))
                {
                    if (reelValues[i].Contains("Cherry"))
                        multiplier++;

                    if (!reelValues[i].Contains("Seven"))
                        isJackPot = false;
                }
                else
                    {
                        isJackPot = false;
                        multiplier = 0;
                        break;
                    }
            }

            if (isJackPot)
                           multiplier = 100;
            
            return multiplier;
        }

        private void spinReels()
        {
            string[] sourceImages = new string[12] { "Bar.png", "Bell.png", "Cherry.png", "Clover.png",
                                                    "Diamond.png", "HorseShoe.png", "Lemon.png",
                                                    "Orange.png", "Plum.png", "Seven.png", "Strawberry.png",
                                                    "Watermellon.png" };
            Random randomNumber = new Random();

            
            reelOneImage.ImageUrl = "Images/" + sourceImages[randomNumber.Next(0,11)];
            reelTwoImage.ImageUrl = "Images/" + sourceImages[randomNumber.Next(0, 11)];
            reelThreeImage.ImageUrl = "Images/" + sourceImages[randomNumber.Next(0, 11)];

            
        }

        
    }
}