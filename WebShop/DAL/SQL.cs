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

        public const string LatestP = 
            @"  SELECT TOP 6 * from ad_master a, Images b 
                where 
	                a.adid=b.Id
	                and ImageType='ICON'
	                order by UploadDate DESC";
    }
}