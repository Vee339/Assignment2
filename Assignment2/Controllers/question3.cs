using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /// <summary>
    /// This method takes a string containing different types of peppers and return the total SSH value of the chili.
    /// </summary>
    /// <param ingredients="items">A string of the peppers separated by comma.</param>
    /// <return>
    /// The method returns the integer which denotes the total SSH value of the chili.
    /// </return>
    /// <example>
    /// GET: api/J2/ChiliPeppers?items=Thai,Poblano,Mirasol -> 82500
    /// </example>
    public class J2 : ControllerBase
    {
        [HttpGet(template:"ChiliPeppers&Ingredients={items}")]

        public int ChiliPeppers(string items)
        {
            int T = 0;
            string[] peppers = items.Split(',');
            foreach (var pepper in peppers)
            {
                string pepperr = pepper.Trim();
                switch (pepperr)
                {
                    case ("Poblano"):
                    T += 1500;
                    break;

                    case ("Mirasol"):
                    T += 6000;
                    break;

                    case ("Serrano"):
                    T += 15500;
                    break;
                        
                    case ("Cayenne"):
                    T += 40000;
                    break;

                    case ("Thai"):
                    T += 75000;
                    break;

                    case ("Habanero"):
                    T += 125000;
                    break;
                }
            }
            return T;
        }    
    }
}