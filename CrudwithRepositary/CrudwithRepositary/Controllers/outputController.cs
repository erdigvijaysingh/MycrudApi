using CrudwithRepositary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudwithRepositary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class outputController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public outputController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<output>>> Getoutput()
        //{
        //    return await _context.output.ToListAsync();
        //}
        // POST: api/outputs
        [HttpPost]
        [Route("Getoutput")]
        public async Task<ActionResult<IEnumerable<output>>> Getoutput(Input input)
        {
            try
            {
                string StoredProc = "exec CreateAppointment " +
                        "@ClinicID = " + input.ClinicId + "," +
                        "@AppointmentDate = '" + input.AppointmentDate + "'," +
                        "@FirstName= '" + input.FirstName + "'," +
                        "@LastName= '" + input.LastName + "'," +
                        "@PatientID= " + input.PatientId + "," +
                        "@AppointmentStartTime= '" + input.AppointmentStartTime + "'," +
                        "@AppointmentEndTime= '" + input.AppointmentEndTime + "'";

                //return await _context.output.ToListAsync();
                return await _context.outputs.FromSqlRaw(StoredProc).ToListAsync();
            }

            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
