using DoctorPatientProject.Data;
using DoctorPatientProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoctorPatientProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PatientController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public PatientController(ApplicationDbContext  context)
        {

            _context = context;

        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatient()
        {
            return await _context.patients.ToListAsync();

        }


        [HttpPost]
        public async Task<ActionResult<Patient>> Create(Patient patient)
        {
            _context.patients.Add(patient);
            await _context.SaveChangesAsync();
            return Ok();
        }


        [HttpPut]
        public async Task<IActionResult> Update(int id, Patient patient)
        {

            if(id != patient.Id) 
            {
                return BadRequest();

            }
            _context.Update(patient);
            await _context.SaveChangesAsync();
            return Ok();
        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var patient = await _context.patients.FindAsync(id);
            if(patient == null) 
            
            {

                return NotFound();
            }

            _context.patients.Remove(patient);
            await _context.SaveChangesAsync();

            return Ok();
        }




    }
}
