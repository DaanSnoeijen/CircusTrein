using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class WagonContainer : IWagonContainer
    {
        public List<Wagon> wagonList = new List<Wagon>();

        public void AddWagon()
        {
            Wagon wagon = new Wagon();
            wagonList.Add(wagon);
        }

        public List<Wagon> WagonList()
        {
            return wagonList;
        }
    }
}
