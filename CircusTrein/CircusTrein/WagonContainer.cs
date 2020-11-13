using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class WagonContainer
    {
        public List<Wagon> wagonList = new List<Wagon>();

        public void AddWagon()
        {
            Wagon wagon = new Wagon();
            wagonList.Add(wagon);
        }
    }
}
