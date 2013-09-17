using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebUI.Membership
{
    public class CodeFirstContextInit : DropCreateDatabaseAlways<DocShareContext>
    {

        protected override void Seed(DocShareContext context)
        {

            CodeFirstSecurity.CreateAccount("Demo", "Demo", "demo@demo.com");

        }

    }
}