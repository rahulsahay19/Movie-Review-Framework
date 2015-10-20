using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Review_Framework.Domain
{
    public class LogAction
    {
        public LogAction(ApplicationUser applicationUser,string action, string controller, string description)
        {
            ApplicationUser = applicationUser;
            Action = action;
            Controller = controller;
            Description = description;
        }
        public int LogActionID { get; set; }

        public DateTime PerformedAt { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public string Description { get; set; }
    }
}