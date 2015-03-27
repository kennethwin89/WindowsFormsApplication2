using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDatabaseApplication
{
    //Creates ID for all Customers

    class CustomerObject
    {
        public const string ID_KEY = @"Id";

        public const int ERROR = -1;
        public const int OK = 0;

        private int m_id;

        public int Id
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }
    }
}
