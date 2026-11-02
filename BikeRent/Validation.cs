using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BikeRent
{
    internal class Validation
    {
        public bool isString(string st)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (!((st[i] <= 'z' && st[i] >= 'a') || (st[i] >= 'A' && st[i] <= 'Z')))
                {
                    return false;
                }
            }
            return true;
        }
        public bool isInt(string st)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (!(st[i] <= '9' && st[i] >= '0'))
                {
                    return false;
                }
            }
            return true;
        }
        public bool isContact(string st)
        {
            if(st.Length != 11)
            {
                return false;
            }
            else if (st[0] != '0' || st[1] != '1' || st[2] == '0' || st[2] == '1' || st[2] == '2')
            {
                return false;
            }
            else
            {
                for(int i = 0;i < st.Length; i++)
                {
                    if (!(st[i] <= '9' && st[i] >= '0'))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool isEqual(string st1, string st2)
        {
            if(st1.Length != st2.Length)
            {
                return false;
            }
            for(int i = 0;i < st1.Length; i++)
            {
                if (st1[i]  != st2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
