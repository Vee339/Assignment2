using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    ///<summary>
    /// This method determines the number of the day on which the infected number of people would be higher than a specified number.
    /// </summary>
    /// <param specifiedNum="P">The number specified by which the infected people should not exceed.</param>
    /// <param infectedPeople="N">The number of people who are infected on Day 0.</param>
    /// <param infecting="R">The number of people which are infected by each infected person on the next day</param>
    /// <return>The method return the number of the day on which the number of the infected people would be higher than the specified number.</return>
    /// <example>
    /// Get: api/J22020/Epidemiology?P=10&N=2&R=1 -> 5
    /// Get: api/J22020/Epidemiology?P=250&N=7&R=8 -> 2
    /// </example>
    public class J22020 : ControllerBase
    {
        [HttpGet(template:"Epidemiology")]

        public int Epidemiology(int P, int N, int R)
        {
            int day = 0;
            int totalInfected = N;

            while (totalInfected <= P)
            {
                N = N * R;
                totalInfected = totalInfected + N;
                day++;
            }
            return day;
        }
    }
}
