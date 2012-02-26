using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nancy;

namespace Parallax_Test.Modules
{
    public class Home : NancyModule
    {
        public Home()
        {
            Get["/"] = _ => "Parallax me";
            Get["/{pname}"] = pname;
        }

        public Response pname(dynamic parameters)
        {
            string nameIn = parameters.pname;
            char[] name = nameIn.ToCharArray();
            return View["Name.cshtml", name];
        }
    }
}
