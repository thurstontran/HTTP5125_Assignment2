using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace HTTP5125_Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        /// <summary>
        /// (The New CCC - Canadian Calorie Counting) Compute the total calories of a meal
        /// </summary>
        ///<param name="burger">The input {burger}</param>
        ///<param name="drink">The input {drink}</param>
        ///<param name="side">The input {side}</param>
        ///<param name="dessert">The input {dessert}</param>
        ///<returns>
        ///Returns a number total of 4 different inputs
        ///</returns>
        ///<example>
        ///GET: localhost:xx/api/J1/Menu/4/4/4/4 => 0
        ///GET: localhost:xx/api/J1/Menu/1/2/3/4 => 691
        ///</example>

        public String Menu(int burger, int drink, int side, int dessert)
        {
            int calories = 0;

            //Depending on the burger of choice, increment the corresponding amount of calories
            if (burger == 1) {
                calories += 461;
                }
            else if (burger == 2) {
                calories += 431;
                }
            else if (burger == 2) {
                calories += 420;
                }
            else if (burger == 4) {
                calories += 0;
                }

            //Depending on the drink of choice, incrmeent the coressponding amount of calories
            if (drink == 1) {
                calories += 130;
                }
            else if (drink == 2) {
                calories += 160;
                }
            else if (drink == 2) {
                calories += 118;
                }
            else if (drink == 4) {
                calories += 0;
                }

            //Depending on the side dish of choice, increment the corresponding amount of calories
            if (side == 1) {
                calories += 100;
                }
            else if (side == 2) {
                calories += 57;
                }
            else if (side == 2) {
                calories += 70;
                }
            else if (side == 4) {
                calories += 0;
                }

            //Depending on the dessert of choice, increment the corresponding amount of calories
            if (dessert == 1) {
                calories += 167;
                }
            else if (dessert == 2) {
                calories += 266;
                }
            else if (dessert == 2) {
                calories += 75;
                }
            else if (dessert == 4) {
                calories += 0;
                }
            //Return a message that calculates the total amount of calories 
            return "Your total calorie count is " + calories; 
        }
    }
}