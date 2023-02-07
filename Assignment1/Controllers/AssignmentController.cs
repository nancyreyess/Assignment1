using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;
using System.Xml.Schema;

namespace Assignment1.Controllers
{
    public class AssignmentController : ApiController
    {
        //Question 1
        /// <summary>
        /// returns 10 more than the integer input
        /// </summary>
        /// <param name="id"> the input number </param>
        /// <returns> the input number plus 10 </returns>
        /// <example>
        /// GET localhost/AddTen/21 => 31
        /// GET localhost/AddTen/0  => 10
        /// GET localhost/AddTen/-9 => 1
        /// </example>
        [Route("api/Assignment/AddTen/{id}")]
        [HttpGet]

        public int AddTen(int id)
        {
            return id + 10;
        }

        //Question 2
        /// <summary>
        /// return the square root of the integer input
        /// </summary>
        /// <param name="id2"> the input number </param>
        /// <returns> the square root of the input number</returns>
        /// <example>
        /// GET localhost/Square/2 => 4
        /// GET localhost/Square/-2 => 4
        /// GET localhost/Square/10 => 100
        /// </example>
        [Route("api/Assignment/Square/{id2}")]
        [HttpGet]

        public int Square(int id2)
        {
            return id2 * id2;
        }

        //Question 3
        /// <returns> returns "Hello world!"</returns>
        [Route("api/Assignment/Greeting")]
        [HttpPost]

        public string Greeting()
        {
            return "Hello World!";
        }

        //Question 4
        /// <summary>
        /// Integer value placed within string of message
        /// </summary>
        /// <param name="id3"> integer value</param>
        /// <returns> return "Greetings to {id3} people!"</returns>
        /// <example>
        /// GET localhost/Greeting/3 => Greetings to 3 people!
        /// GET localhost/Greeting/6 => Greetings to 6 people!
        /// GET localhost/Greeting/0 => Greetings to 0 people!
        /// </example>
        [Route("api/Assignment/Greeting/{id3}")]
        [HttpGet]

        public string Greeting(int id3)
        {
            return "Greetings to " + id3 + " people!";
        }

        //Question 5
        /// <summary>
        /// takes the integer and multiplies by 2, divides by 5, and adds one
        /// </summary>
        /// <param name="id4"> integer input</param>
        /// <returns> returns the completed mathematical equation</returns>
        /// <example>
        /// GET localhost/NumberMachine/10 => 5
        /// GET localhost/NumberMachine/-5 => -1
        /// GET localhost/NumberMachine/30 => 13
        /// </example>
        [Route("api/Assignment/NumberMachine/{id4}")]
        [HttpGet]

        public int NumberMachine(int id4)
        {
            return id4 * 2 / 5 + 1;
        }

        //Question 6
        /// <summary>
        /// my approach was to look at each response individually and break it down from there
        /// I knew I had to figure out an int for the number of FNs because the input message refers to that
        /// At first I thought FN = 14, but that didn't work becaus it would multiply by 14.
        /// I settled on FN = (id5/ 14) > to find the amount of FN's that the id5 input is
        /// I realized that if the number fell under 14, ^ would equal 0 and noe provide a charge if i multiplied that by the rate
        /// so I added 1 to account for that
        /// I could not figure out how to make 5 > 5.50 because of the decimal
        /// Due to that, I stopped at finding the charge if the rate was $5 because i could not move forward without calculating the tax without knowing how to incorporate decimals
        /// The next step for me would be something like adding this:
        /// HST = rate * 0.13;
        /// return "HST 13% =" + HST + " CAD" 
        /// total = charge + HST;
        /// return "Total =" + total + " CAD"
        /// </summary>
        /// <returns></returns>
   
        [Route("api/Assignment/HostingCost/{id5}")]
        [HttpGet]

        public string HostingCost(int id5)
        {
            int rate = 5; //couldn't figure out the way to get decimals so to test if it worked, just used 5
            int FN = (id5 / 14) + 1;
            int charge = FN * rate;

            return FN + " fortnights at " + rate + "/FN =" + charge;

        }
    }
}
