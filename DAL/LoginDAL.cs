using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        public int Login(Login lg)
        {
            using(QLRPContext context = new QLRPContext())
            {
                try
                {
                    Login res = context.Logins.Single(p => p.UserName == lg.UserName && p.Password == lg.Password);
                    return int.Parse(res.role.ToString());
                }
                catch (Exception e) { return -1; }
                
            }
        }
    }
}
