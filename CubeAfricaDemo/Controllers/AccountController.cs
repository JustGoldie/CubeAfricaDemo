using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

using CubeAfricaDemo.Models;

namespace CubeAfricaDemo.Controllers
{
    [Authorize]
    public class AccountController : ApiController
    {
        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage Login(LoginRequest loginDetails)
        {
            try
            {
                using (DataClassesDataContext dc = new DataClassesDataContext())
                {
                    tUser user = dc.tUsers.Where(u => u.sEmailAddress == loginDetails.email && u.sPassword == loginDetails.password).Single();

                    return Request.CreateResponse(HttpStatusCode.OK, user);
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }

            
        }

        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage RegisterUser(User userDetails)
        {
            try
            {
                using (DataClassesDataContext dc = new DataClassesDataContext())
                {
                    tUser existingUser = dc.tUsers.Where(u => u.sEmailAddress == userDetails.email).SingleOrDefault();

                    if (existingUser == null)
                    {
                        tUser newUser = new tUser
                        {
                            pkUserId = Guid.NewGuid().ToString(),
                            sFirstName = userDetails.firstName,
                            sLastName = userDetails.lastName,
                            sCompany = userDetails.company,
                            sEmailAddress = userDetails.email,
                            sPassword = userDetails.password,
                            sCellNo = userDetails.cellNo,
                            sWorkNo = userDetails.workNo
                        };

                        dc.tUsers.InsertOnSubmit(newUser);
                        dc.SubmitChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, "");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "User already exists.");
                    }
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}