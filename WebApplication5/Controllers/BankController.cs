using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Model;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly BankContext _context;
        public BankController(BankContext context)
        {
            _context = context; 
        }
       
        public List<BankBranch> getAll()
        {
            return _context.BankBranches.ToList();
        }
        [HttpGet("{id}")]
        [HttpGet]
        public ActionResult<BankBranch> GetBankBranch(int id)
        {
            var bankBranch = _context.BankBranches.FirstOrDefault(b => b.Id == id);

            if (bankBranch == null)
            {
                return NotFound();
            }




            bankBranch.Employees = _context.Employees.Where(e => e.BankBranchId == id).ToList();

            return bankBranch;
        }

        [HttpPost]
        public IActionResult Add(AddBankRequest req)
        {
            _context.BankBranches.Add(new BankBranch()
            {
                LocationName = req.LocationName,
                LocationURL = req.LocationURL,
                BranchManager =""
            });
            _context.SaveChanges();
            return Created();
        }

    }
   
}
