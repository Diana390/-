using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бд
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Fname { get; set; }
        public string Oname { get; set; }
        public Group group { get; set; }
        public List<assessment>  Assessment { get; set; }
             
    
}
}
