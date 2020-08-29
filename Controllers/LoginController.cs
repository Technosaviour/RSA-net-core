using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RSA_Angular_.NET_CORE.Model;
using RSA_Angular_.NET_CORE.RSA;

namespace RSA_Angular_.NET_CORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // GET: api/Login
        private readonly IRsaHelper _rsaHelper;
        public LoginController(IRsaHelper rsaHelper)
        {
            _rsaHelper = rsaHelper;
        }

        [HttpPost]
        public bool Post([FromBody] UserLoginModel user)
        {
            try
            {
                var clearTextPassword = _rsaHelper.Decrypt(user.Password);
                return user.UserName.Equals("TechnoSaviour") && clearTextPassword.Equals("TestPass");
            }
            catch (Exception)
            {
                // Log ex 
                return false;
            }
        }
    }


}
