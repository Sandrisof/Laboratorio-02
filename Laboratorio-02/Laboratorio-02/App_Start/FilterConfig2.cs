﻿using System.Web;
using System.Web.Mvc;

namespace Laboratorio_02
{
    public class FilterConfig2
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
