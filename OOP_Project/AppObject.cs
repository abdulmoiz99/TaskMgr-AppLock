using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_Project
{
    abstract class AppObject
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public abstract int getCount();
        //public abstract string getAppName(int id);
        public virtual string getAppName(int id)
        {
            return Name;
        }
        public virtual void setRecord(String Name)
        {
            // INSERT INTO TABLE
        }
        public virtual void setRecord(String Name, int time)
        {
            // INSERT INTO TABLE
        }
        public virtual bool CheckInList(String Name)
        {
            // check Whether the app or user is in record or not
            return false;
        }
        protected void KillApp(String Name)
        {
            foreach (Process proc in Process.GetProcessesByName(Name))
            {
                try
                {
                    proc.Kill();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}