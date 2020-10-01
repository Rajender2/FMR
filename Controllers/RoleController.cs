using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMRRoles.Data;
using FMRRoles.Models;
using Microsoft.AspNetCore.Mvc;

namespace FMRRoles.Controllers
{
    [Route("api/[Controller]")]
    public class RoleController : Controller
    {
        private Context _context;
        public RoleController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Role> Get()
        {
            return _context.Role.ToList();
        }
       
    }
}
