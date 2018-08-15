using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure_4_2;

namespace Figure_4_2
{
    public class Account
    {
        private string name;

        public void SetName(string accountName)
        {
            name = accountName;
        }

        public string GetName()
        {
            return name;
        }
    }
}
