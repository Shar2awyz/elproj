using elproj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elproj
{
    internal abstract  class People
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


    internal abstract class employee : People {
        protected string Salary="10000";
        private string Bonus;

        internal virtual void setBonus(string B) {
        int z=int.Parse(B)+int.Parse(Salary);

            salarywithbonus=Convert.ToString(z);
            

        
        }
        internal virtual string getBonus() {
        return salarywithbonus;
        } 
    
    
    
    
    };



    
internal class AssisDr : employee
{
    internal override void setBonus(string b)
    {

        Salary = "11000";
        int z = int.Parse(b) + int.Parse(Salary);

        salarywithbonus = Convert.ToString(z);


    }
        internal override string getBonus()
        {
            return salarywithbonus;

        }    }
};
internal class Receptionist : employee
{
    internal override void setBonus(string b)
    {

        Salary = "7000";
        int z = int.Parse(b) + int.Parse(Salary);

        salarywithbonus = Convert.ToString(z);


    }
    internal override string getBonus()
    {
        return salarywithbonus;

    }

};
internal class Patient : People
{

    internal string Condition;








};


