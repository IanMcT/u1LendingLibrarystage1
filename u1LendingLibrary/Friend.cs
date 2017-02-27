using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1LendingLibrary
{
    /// <summary>
    /// Friend class - details for each friend
    /// </summary>
    class Friend
    {
        public int id;
        public string name;
        public string email;

        /// <summary>
        /// Friend - set initial values
        /// </summary>
        /// <param name="i">id number</param>
        /// <param name="n">name</param>
        /// <param name="e">email address</param>
        public Friend(int i, string n, string e) 
        {
            id = i;
            name = n;
            email = e;
        }
    }
}
