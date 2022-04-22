using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProfileManagement.Models;

namespace ProfileManagement.Controllers
{
    public class UserController : ApiController
    {
      public IEnumerable<UserCreation> Get()
        {
           using(ProfileManagementEntities profileManagement=new ProfileManagementEntities())
            {
                return profileManagement.UserCreations.ToList();
            }
        } 
    }
}
