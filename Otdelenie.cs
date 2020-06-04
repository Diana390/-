using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бд
{
    [Serializable]
    public class Otdelenie
    {
        public string Name { get; set; }
        public List<Group> group { get; set; }
    }
}
