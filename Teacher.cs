using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бд
{
    [Serializable]
    public class Teacher
    {
        public string Name { get; set; }
        public string FName { get; set; }
        public string OName { get; set; }
        public List<Subiect> subiect { get; set; }

    }
}
