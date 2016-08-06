using FirstFullStackSocialMedia.DTOs;
using FirstFullStackSocialMedia.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace FirstFullStackSocialMedia.Controllers
{
    [Authorize]
    public class AttendencesController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public AttendencesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDTO dto)
        {
            var userId = User.Identity.GetUserId();

            var isAlreadyAttending = _dbContext.Attendences.Any(a => a.GigId == dto.GigId && a.AttendeeId == userId);

            if (isAlreadyAttending)
            {
                return BadRequest("You are attending the gig!");
            }

            var attendence = new Attendence()
            {
                GigId = dto.GigId,
                AttendeeId = userId
            };

            _dbContext.Attendences.Add(attendence);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
