using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.DAL
{
    public static class SQL
    {
        public const string Users = @" SELECT
                                            Id,
                                            Email,
                                            PasswordHash,
                                            SecurityStamp,
                                            PhoneNumber,
                                            UserName
                                       FROM AspNetUsers";
    }
}