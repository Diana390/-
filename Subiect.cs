using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бд
{
    [Serializable]
    public class Subiect
    {
        public List<Teacher> teacher { get; set; }
        public string Name { get; set; }
        public Group group { get; set; }
    }
}
