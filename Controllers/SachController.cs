using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _1811061037_PhamDangMinhTriet_Lab07.Models;

namespace _1811061037_PhamDangMinhTriet_Lab07.Controllers
{
    //asd
    public class SachController : ApiController
    {
        Sach[] saches = new Sach[]
        {
            new Sach{Id = 1,
                    Title ="Tôi thấy hoa vàng trên cỏ xanh",
                    AuthorName ="Nguyễn Nhật Anh", Price = 1,
                    Content = "Truyện kể về tuổi thơ..."},

             new Sach{Id = 2,
                    Title ="Pro ASP.NET MVC5",
                    AuthorName ="Adam Freeman", Price = 3.75M,
                    Content = "The ASP.NET MVC 5 Framework is the lastes evolution of Mircrosoft's ASP.NET web platform"}
        };

        public IEnumerable<Sach> GetAll()
        {
            return saches;
        }

        public IHttpActionResult GetSach(int Id)
        {
            var sach = saches.FirstOrDefault((p) => p.Id == Id);
            if(sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
