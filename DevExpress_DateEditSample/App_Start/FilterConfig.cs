﻿using System.Web;
using System.Web.Mvc;

namespace DevExpress_DateEditSample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
