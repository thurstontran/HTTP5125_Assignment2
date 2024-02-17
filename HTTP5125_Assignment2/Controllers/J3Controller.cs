using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Web.Http;
using System.Web.Mvc.Html;

namespace HTTP5125_Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/J3/Cellphone/{s}")]

        ///<summary>
        ///(Cell-phone Messaging) Calculate the minimal time needed to type a mesage on a cellphone
        ///</summary>
        ///<param name="s">The input {s}</param>
        ///<returns>
        ///Returns a number representing the time according to the message sent
        ///If the message sent is 'halt' return a 0 to signify the program has stopped
        ///</returns>
        ///<example>
        ///GET: localhost:xx/api/J3/Cellphone/abba => 12
        ///GET: localhost:xx/api/J3/Cellphone/bob => 7
        ///GET: localhost:xx/api/J3/Cellphone/halt => 0
        ///GET: localhost:xx/api/J3/Cellphone/abcdefghijklmnopqrst => 0
        ///</example>
        ///<source>
        ///https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2006/stage1/juniorEn.pdf
        ///</source>
        public int Cellphone(String s) {
            int time = 0;
            //Set all HTTP GET Requests to only consist of lowercase letters
            s = s.ToLower();

            while (true) {
                //If the GET request equals 'halt' or the amount of characters equal 20 or more, set the time to 0.
                //This is an alternative to the imitate the program to stop reading input.
                if(s == "halt" || s.Length >= 20) {
                    return 0;
                    }
                //Check each letter thaat is input on the cellphone and add the number of seconds accordingly
                for (int i = 0; i < s.Length; i++) {
                    //For every first letter on each dial, add 1 second 
                    if ("adgjmptw".Contains(s[i])) {
                        time += 1;
                        }
                    //For every 2nd letter on each dial, add 2 seconds
                    else if ("behknquv".Contains(s[i])) {
                        time += 2;
                        }
                    //For every 3rd letter on each dial, add 3 seconds
                    else if ("cfilorvy".Contains(s[i])) {
                        time += 3;
                        }
                    //For 's' and 'z' being the 4th letter on two dials, add 4 seconds
                    else if ("sz".Contains(s[i])) {
                        time += 4;
                        }

                    //To imitiate a time out effect between each character input add 2 seconds
                    //For example, to write abba you press 2-pause-22-pause-22-pause-2
                    if (i > 0) {
                        if ("abc".Contains(s[i - 1]) && "abc".Contains(s[i]) ||
                            "def".Contains(s[i - 1]) && "def".Contains(s[i]) ||
                            "ghi".Contains(s[i - 1]) && "ghi".Contains(s[i]) ||
                            "jkl".Contains(s[i - 1]) && "jkl".Contains(s[i]) ||
                            "mno".Contains(s[i - 1]) && "mno".Contains(s[i]) ||
                            "pqrs".Contains(s[i - 1]) && "pqrs".Contains(s[i]) ||
                            "tuv".Contains(s[i - 1]) && "tuv".Contains(s[i]) ||
                            "wxyz".Contains(s[i - 1]) && "wxyz".Contains(s[i]))
                             {
                                time += 2;
                             }
                    }
                }
                //Return the time it took to input the letters on the cellphone, adding 2 seconds per input.
                return time;
            }
                
        }  
    }
}

