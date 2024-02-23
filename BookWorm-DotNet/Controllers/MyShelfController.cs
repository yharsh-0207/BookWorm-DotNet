using BookWorm_DotNet.DAL;
using BookWorm_DotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWorm_DotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyShelfController : Controller
    {
        private readonly IMyShelfRepository myShelfRepository;
        private readonly IRoyaltyCalculationRepository royaltyCalculationRepository;
        public MyShelfController(IMyShelfRepository myShelfRepository, IRoyaltyCalculationRepository royaltyCalculationRepository)
        {
            this.myShelfRepository = myShelfRepository;
            this.royaltyCalculationRepository = royaltyCalculationRepository;
        }


        [HttpGet("{customerId}")]
        public IActionResult GetMyShelfByCustomerId(long customerId)
        {
            var myShelves = myShelfRepository.GetMyShelvesByCustomerId(customerId);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(myShelves);
        }


        [HttpPost]
        public IActionResult AddToShelf([FromBody] MyShelf myShelf)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdMyShelf = myShelfRepository.AddToShelf(myShelf);

            return CreatedAtAction(nameof(GetMyShelfByCustomerId), new { customerId = createdMyShelf.CustomerId }, createdMyShelf);
        }

        [HttpDelete("{shelfId}")]
        public IActionResult DeleteShelf(long shelfId)
        {
            var shelf = myShelfRepository.DeleteShelf(shelfId);
            if (shelf == null)
            {
                return NotFound();
            }
            return Ok(shelf);
        }

/*        [HttpGet()]
        public IActionResult GetMyShelf()
        {
            var myShelves = myShelfRepository.GetMyShelves();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(myShelves);
        }*/


    }
}
