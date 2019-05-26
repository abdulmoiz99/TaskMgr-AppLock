using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    abstract class AppObject
    {
        public abstract int getCount();
        public abstract string getAppName(int id);
        public virtual void setRecord(String Name)
        { 
            // INSERT INTO TABLE
        }
        public virtual void setRecord(String Name,int time)
        {
            // INSERT INTO TABLE
        }
    }
}
