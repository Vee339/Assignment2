using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    /// <summary>The method takes the single input instruction which does not specify anything and converts it into meaningful instructions.</summary>
    /// <param instruction="string">The parameter is a single string which is the only input.</param>
    /// <return>The method returns an output string which contains various instructions.</return>
    /// <example>
    /// GET: api/J32022/instruction="AFD+3HS-4" -> "AFD tighten 3, HS loosen 4"
    /// </example>
    public class J32022 : ControllerBase
    {
        [HttpGet(template:"HarpTuning")]
        public string HarpTuning(string instruction)
        {
            string output = "";
            // Dividing the instruction into individual instructions
            string[] instructions = Regex.Split(instruction, @"(?<=\d)(?=\D)");

            // Looping through each instruction to apply the logic
            foreach (var instruc in instructions)
            {
               
                string operation;
                string[] parts;
                //Console.WriteLine(instruc);
                if (instruc.Contains("+"))
                {
                    parts = instruc.Split("+");
                    operation = "+";
                    if (output != "")
                    {
                        output += ", ";
                    }
                    output += $"{parts[0]} tighten {parts[1]}";
                }
                else
                {
                    parts = instruc.Split("-");
                    operation = "-";
                    if (output != "")
                    {
                        output += ", ";
                    }
                    output += $"{parts[0]} loosen {parts[1]}";
                }
            }
            return output;
        }
    }
}
