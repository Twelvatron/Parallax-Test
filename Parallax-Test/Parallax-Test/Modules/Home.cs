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
            Get["/"] = home;
            Get["/Name/{pname}"] = pname;
            Post["/Name"] = submitName;
        }

        public Response home(dynamic parameters)
        {
            return View["Home.cshtml"];
        }

        public Response submitName(dynamic parmeters)
        {
            string nameIn = Request.Form.NameIn;
            char[] name = nameIn.ToCharArray();
            return View["Name.cshtml", name];
        }

        public Response pname(dynamic parameters)
        {
            string nameIn = parameters.pname;
            char[] name = nameIn.ToCharArray();
            return View["Name.cshtml", name];
        }
    }
}
