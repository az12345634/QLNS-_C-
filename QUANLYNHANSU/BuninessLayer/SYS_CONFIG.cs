using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer
{
    public class SYS_CONFIG
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
       public tb_Config getItem (string name)
        {
            return db.tb_Config.FirstOrDefault(x => x.NAME == name);
         }
    }
}
