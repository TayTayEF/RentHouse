﻿using System.Web;
using System.Web.Mvc;

namespace ThueTro_DACS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}