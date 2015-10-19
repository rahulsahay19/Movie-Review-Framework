using Microsoft.AspNet.Identity.EntityFramework;
using Movie_Review_Framework.Domain;

namespace Movie_Review_Framework.Data
{
    public class MovieReviewDbContext :IdentityDbContext<ApplicationUser>
    {
        public MovieReviewDbContext()
            : base("DefaultConnection")
        {
            
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}