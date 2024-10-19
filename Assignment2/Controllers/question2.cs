using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    ///<summary>This method checks if a dog is happy or sad with his/her treats.</summary>
    ///<param small="S">The number of small treats.</param>
    ///<param medium="M">The number of medium treats.</param>
    ///<param large="L">The number of large treats.</param>
    ///<return>It returns a string of "happy" or "sad"</return>
    ///<example>
    ///GET: api/J12020/DogTreats?S=5M=3L=1 -> "Happy"
    /// </example>
    public class J12020 : ControllerBase
    {
        [HttpGet(template:"DogTreats")]

        public string DogTreats(int S, int M, int L)
        {
            int output = 1 * S + 2 * M + 3 * L;
            if (output >=10)
            {
                return "Happy";
            }
            else
            {
                return "Sad";
            }
        }
    }
}
