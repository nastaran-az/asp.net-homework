using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class J2Controller : ApiController
    {
        ///<summary>
        ///program recives 2 inputs that are sides of every dice,
        ///and then calculates how many times sume of numbers on two  dices can be 10         
        ///</summary>
        ///<param name="side1">side1 is number of  sides in dice1 </param>
        ///<param name="side2">side2 is number of  sides in dice2</param>
        ///<example>side1=6 and side2=8 --> count=5 method return "There are 5 total ways to get the sum 10."</example>
        ///<example>side1=12 and side2=4 --> count=4 method return "There are 4 total ways to get the sum 10."</example>
        [Route("api/J2/DiceGame/{side1}/{side2}")]
        [HttpGet]
        public string DiceGame(int side1, int side2)
        {
            int count = 0;// variable for numbers of times that sum is 10
            int i = 1;// for every side of the first dice it can be i=1,2,3,....,side1
            string message;// variable to return final message
            while (i <= side1)///for example i=1 then i sums j=1 to side2 if i+j==10 it will be added 1 to count                              
            {
                for (int j = 1; j <= side2; j++)//j is variable to labels of second dice j=1,2,3,...,side2
                {
                    if (i + j == 10)
                    {
                        count += 1;
                    }
                }
                i++;

            }
            message = "There are " + count + " Totale ways to get the Sum 10";
            return message;
        }

    }
}

