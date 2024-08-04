using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elproj
{
    internal  class People
    {
     internal string Name;
        internal  string Department;
        internal string ID;
        protected string salarywithbonus="0";
        internal void setName(string N) {
        Name= N;
        }
        internal string getName() {
            return Name;
        
        }
        internal void setDepartment(string d) {
        Department= d;

        
        }
        internal string GetDep() {
        return Department;
        }   
    };


    internal class employee : People {
        private string Salary="10000";
        private string Bonus;

        internal void setBonus(string B) {
        int z=int.Parse(B)+int.Parse(Salary);

            salarywithbonus=Convert.ToString(z);
            

        
        }
        internal string getBonus() {
        return salarywithbonus;
        } 
    
    
    
    
    };

    internal class Patient : People {

        internal string Condition;
    
    
    
    
    
    
    
    
    
    };
}
