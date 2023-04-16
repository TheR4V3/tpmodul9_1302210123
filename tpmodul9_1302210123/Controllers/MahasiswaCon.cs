using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302210123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaCon : ControllerBase
    {
        public static List<Mahasiswa> mh = new List<Mahasiswa>
        {
            new Mahasiswa ("Rafa Eka", "1302210123"),
            new Mahasiswa ("Andry Nur Falah", "1302213005"),
            new Mahasiswa ("Reyhan Azani", "1302210110"),
            new Mahasiswa ("Satrio Agul", "1302210065"),
            new Mahasiswa ("Yosua William", "1302210126")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mh;
        }

        [HttpGet("{idx}")]
        public Mahasiswa Get(int idx)
        {
            return mh[idx];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa newMahasiswa)
        {
            mh.Add(newMahasiswa);
        }

        [HttpDelete("{idx}")]
        public void Delete(int idx)
        {
            mh.RemoveAt(idx);
        }
    }
}
