using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;
using System.Collections.Generic;

namespace WebApplication.Controllers
{
    public class PenerbanganController : ApiController
    {
        public IHttpActionResult GetAllPenerbangan()
        {
            IList<PenerbanganModel> penerbangans = null;

            using (var ctx = new ItikAirEntities())
            {
                penerbangans = ctx.penerbangans.Include("PenerbanganList")
                    .Select(s => new PenerbanganModel()
                    {
                        no_pesawat = s.no_pesawat,
                        bandara_asal = s.bandara_asal,
                        bandara_tujuan = s.bandara_tujuan,
                        tgl_berangkat = s.tgl_berangkat,
                        tgl_tiba = s.tgl_tiba,
                        jam_berangkat = s.jam_berangkat,
                        jam_tiba = s.jam_tiba
                    }).ToList<PenerbanganModel>();
            }

            if (penerbangans.Count == 0)
            {
                return NotFound();
            }
            return Ok(penerbangans);
        }

    }
}
