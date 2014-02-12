using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Train
{
    public  class processword
    {
        string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public static processword operator +(processword r1, processword r2)
        {
            Train.processword r = new Train.processword();
            r.Sex = r1.Sex + r2.Sex;
            return r;
        }
    }
}
