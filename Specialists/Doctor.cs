using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specialists
{
    class Doctor : Person
    {
        public int ArticlesWrote { get; set; }
        public string[] Specialty { get; set; }
        public string[] Articles { get; set; }


    }
}
