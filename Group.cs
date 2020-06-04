using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бд
{
    [Serializable]
    public class Group
    {
        public string Name { get; set; }
        public Otdelenie otdelenie { get; set; }
        public List<Student> student { get; set; }
        public List<Subiect> subiect { get; set; }

    }
}
