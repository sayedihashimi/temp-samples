using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary01
{
    public class FromClassLib
    {
        public string Name { get; set; }
        public static DateTime GetDateNow() {
            return DateTime.Now;
        }
    }
}
