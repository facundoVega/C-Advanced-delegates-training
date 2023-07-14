using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Models;

namespace Training.Data
{
    public interface ILogin
    {
        User Login(string emailAddress, string Password);
    }
}
