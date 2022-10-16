using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public static class Helper
    {
        public static List<PInfo> SearchPerson(List<PInfo>  infos, string name)
        {
            //Это список найденных персонажей
            List<PInfo> foundPerson = new List<PInfo>();
            foreach (PInfo info in infos)
            {
                if (info.Name == name)
                {
                    foundPerson.Add(info);
                }
            }
            return foundPerson;
        }
    }
}
