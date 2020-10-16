using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebGrease.Css.Ast.Selectors;

namespace WebApplication2.Controllers
{
    
    public class J1Controller : ApiController
    ///<summary>user choosse a burgur, a drink, a side and a dessert from menu by their number, and
    ///program calculate their calories.</summary>
    ///<param  name="burger">it is a number beetween 1 to 4 that will be index of burgercalori list</param>
    ///<param name="drink">it is a number beetween 1 to 4 that will be index of drinkcalori list</param>
    ///<param name="side">it is a number beetween 1 to 4 that will be index of sidecalori list</param>
    ///<param name="side">it is a number beetween 1 to 4 that will be index of dessertcalori list</param>
    ///<example>for example input is burger=4,drink=4, side=4, dessert=4-->countColori=0</example>
    ///<example>for example input is burger=1,drink=2, side=3, dessert=4-->countColori=691</example>
    {
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]

        public string Menu(int burger, int drink, int side, int dessert)
        {
            List<int> burgercalorie = new List<int>() { 461, 431, 420, 0 }; // list for burgers' calorie
            List<int> drinkcalorie = new List<int>() { 130, 160, 118, 0 };//list  for drinks'calorie
            List<int> sidecalorie = new List<int>() { 100, 57, 70, 0 };//list  for sides'calorie
            List<int> dessertcalorie = new List<int>() { 167, 266, 75, 0 };//list  for desserts'calorie
            string errormessage = "please enter valid number between 1 to 4 ";
            int countcalories = 0;
            string message = "Your total calori count is ";
            //if input was a number that there isn't in lists it shows a messsage
            if ((burger <= 0) | (burger > 4) | (drink <= 0) | (drink > 4) | (side <= 0) | (side > 4) | (dessert<=0) | (dessert > 4))
            {
                return errormessage;
            }
            else
            {
                //since index of first item in a list is 0; therfore, when input parameter is 1 for access to first item
               // program should param-1
                burger -=1; 
                drink -=1;
                side -= 1;
                dessert -= 1;
                countcalories = burgercalorie[burger] + drinkcalorie[drink] + sidecalorie[side] + dessertcalorie[dessert];
                message = message + countcalories;
                return message;
            }

      }      

    }
}
