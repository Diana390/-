using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Бд
{
    public class DB
    {
        public List<Teacher> teachers = new List<Teacher>();
        public List<Subiect> subiects = new List<Subiect>();
        public List<Otdelenie> otdelenies = new List<Otdelenie>();
        int autoincrementIdContact = 1;
        string filename = "db.BD teacer";
        public void Save()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                byte[] temp = BitConverter.GetBytes(autoincrementIdContact);
                fs.Write(temp, 0, 4);
                binaryFormatter.Serialize(fs, teachers);
                binaryFormatter.Serialize(fs, subiects);
            
                binaryFormatter.Serialize(fs, otdelenies);
           
            }
        }
        public DB()
        {
            if (!File.Exists(filename))
            {
                return;
            }
            else
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    byte[] temp = new byte[4];
                    fs.Read(temp, 0, 4);
                    autoincrementIdContact = BitConverter.ToInt32(temp, 0);
                    teachers = ((List<Teacher>)binaryFormatter.Deserialize(fs));
                    subiects = ((List<Subiect>)binaryFormatter.Deserialize(fs));
                    otdelenies = ((List<Otdelenie>)binaryFormatter.Deserialize(fs));
                
                }
            }
        }
    }
}
