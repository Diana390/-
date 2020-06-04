using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бд
{
    [Serializable]
    public class assessment
    {
        public int Assessment { get; set; }
        public Student student { get; set; }
        public Subiect subiect { get; set; }
    }
}
