using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAssgn2.Models;

namespace WebApiAssgn2.Controllers
{
    public class EmployeeController : ApiController
    {
        zensarDbEntities zdb = new zensarDbEntities();
        public IHttpActionResult GetEmployeeSalById(int eid)
        {
            var details = zdb.getEmpsalary(eid).ToList();
            return Ok(details);
        }
    }
}
