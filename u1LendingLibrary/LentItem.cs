using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1LendingLibrary
{
    class LentItem
    {
        public int id;
        public int Friendid;
        public int Itemid;

        public LentItem(int i, int f, int ii) 
        {
            id = i;
            Friendid = f;
            Itemid = ii;
        }
    }
}
