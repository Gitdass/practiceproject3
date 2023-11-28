using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practice3.Db;
using practice3.Model;

namespace practice3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public SubjectsController(ApplicationDbContext db)
        {
                _db = db;
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] Subjects s1)
        {
            _db.Add(s1);
            _db.SaveChanges();
            return Ok(s1);

        }
        [HttpGet]
        [Route("Getall")]
        public IActionResult GetAll() 
        {
            List<Subjects>subject=new List<Subjects>();
            subject=_db.subjects.ToList();
            return Ok(subject); 
         }
        [HttpGet]
        [Route("GetbyID")]
        public IActionResult Get(int id) 
        {
            Subjects s1=_db.subjects.FirstOrDefault(x=>x.id==id);
            return Ok(s1);

        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody]Subjects s1)
        {
            _db.Update(s1);
            _db.SaveChanges();
            return Ok(s1);

        }
        [HttpDelete]
        [Route("Delete")]

        public IActionResult Delete(int id) 
        {
            Subjects s1 = _db.subjects.FirstOrDefault(x => x.id == id);
            _db.Remove(s1);
            _db.SaveChanges();
            return Ok(s1);

        }



    }
}
