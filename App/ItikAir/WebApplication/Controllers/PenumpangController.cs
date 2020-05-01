using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class PenumpangController : ApiController
    {
        public IHttpActionResult GetAllPenumpang()
        {
            IList<PenumpangModel> penumpangs = null;

            using (var ctx = new ItikAirEntities())
            {
                penumpangs = ctx.penumpangs.Include("PenumpangList")
                    .Select(s => new PenumpangModel()
                    {
                        no_ktp = s.no_ktp,
                        nama_penumpang = s.nama_penumpang,
                        umur_penumpang = s.umur_penumpang,
                        jk_penumpang = s.jk_penumpang,
                        alamat_penumpang = s.alamat_penumpang
                    }).ToList<PenumpangModel>();
            }

            if (penumpangs.Count == 0)
            {
                return NotFound();
            }
            return Ok(penumpangs);
        }



    }
}
