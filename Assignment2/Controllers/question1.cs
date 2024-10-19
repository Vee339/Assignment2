using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    ///<summary>
    /// Receives an HTTP POST request with a multipart/form-data body containing two parameters. 
    /// </summary>
    /// <param name="P">The number of total packages delivered.</param>
    /// <param name="C">The number of total collisions with obstacles.</param>
    /// <return>An integer which is the total score.</return>
    /// <example>
    /// POST api/Route/Delivedroid
    /// HEADERS: Content-Type: multipart/form-data
    /// </example>
    public class J1 : ControllerBase
    {
        [HttpPost(template:"Delivedroid")]
        public int Delivedroid([FromForm] int P, [FromForm] int C)
        {
            int packPoints = P * 50;
            int collPoints = C * 10;
            int output = packPoints - collPoints;
            if (P > C )
            {
                output += 500;
            }
            return output;
        }
    }
}
