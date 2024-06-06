using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProjectPSD.Repository
{
    public class UserRepository
    {
        ProjectDatabaseEntities3 db = Singleton.GetInstance();
    }
}