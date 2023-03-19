using Microsoft.AspNetCore.Mvc;
using SweeftDigitalTask.Algorithm;

namespace SweeftDigitalTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolutionController : ControllerBase
    {

        [HttpGet("IsPalindrome")]
        public ActionResult<bool> IsPalindrome(string text)
        {
            return text.IsPalindrome();
        }
        [HttpGet("MinSplit")]
        public ActionResult<int> MinSplit(int amount)
        {
            return amount.MinSplit();
        }
        [HttpPost("NotContains")]
        public ActionResult<int> NotContains([FromBody] int[] array)
        {
            return array.NotContains();
        }
        [HttpGet("IsProperly")]
        public ActionResult<bool> IsProperly(string sequence)
        {
            return sequence.IsProperly();
        }
        [HttpGet("CountVariants")]
        public ActionResult<int> CountVariants(int stairCount)
        {
            return stairCount.CountVariants();
        }
    }
}
