using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125_Assignment2.Controllers
{
    public class J2Controller : ApiController {
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        /// <summary>
        /// (Roll the Dice) Determine how many ways to roll the dice and result in a sum of 10
        /// </summary>
        ///<param name="m">The input {m}</param>
        ///<param name="n">The input {n}</param>

        ///<returns>
        ///Returns a string "There is/are 'combination' ways to get the sum 10"
        ///</returns>
        ///<example>
        ///GET: localhost:xx/api/J2/DiceGame/6/8 => There are 5 ways to get the sum 10"
        ///GET: localhost:xx/api/J2/DiceGame/12/4 => There are 4 ways to get the sum 10"
        ///GET: localhost:xx/api/J2/DiceGame/3/3 => There are 0 ways to get the sum 10"
        ///GET: localhost:xx/api/J2/DiceGame/5/5 => There is 1 way to get the sum 10"
        ///</example>

        public String DiceGame(int m, int n) {
            int combination = 0;

            //Iterate through all possible values from 1 to 'm' for the first number
            //For each value 'i', check the number (10 - i) needed to reach sum of 10
            //and it falls within the range of 1 to 'n'
            //if it is in range, incrmeent the combination
            for (int i = 1; i <=m; i++ ) {
                if((10 - i) <= n && (10 - i) > 0) {
                    combination++;
                    }
            }
            //If there is 1 combination, return a message to say there is 1 combination
            if(combination == 1) {
                return "There is " + combination + " way to get the sum 10.";
                }
            //If more than 1 combination, return a message to say there are multiple combinations.
            else {
                return "There are " + combination + " ways to get the sum 10.";
                }
        }
    }
}
