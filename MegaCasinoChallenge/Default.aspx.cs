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

        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            //actions when leverButton is pulled

            //select random pictures for each reel
            //return the name for each reel with this method
            spinReels();


            //determine if it is a winning combinationn

            // update the money

        }

        private void spinReels()
        {
            string[] reelImages = new string[12] { "Bar.png", "Bell.png", "Cherry.png", "Clover.png",
                                                    "Diamond.png", "HorseShoe.png", "Lemon.png",
                                                    "Orange.png", "Plum.png", "Seven.png", "Strawberry.png",
                                                    "Watermellon.png" };

            Random randomNumber = new Random();
                        
            reelOneImage.ImageUrl = "Images/" + reelImages[randomNumber.Next(0,11)];
            reelTwoImage.ImageUrl = "Images/" + reelImages[randomNumber.Next(0, 11)];
            reelThreeImage.ImageUrl = "Images/" + reelImages[randomNumber.Next(0, 11)];
        }
    }
}