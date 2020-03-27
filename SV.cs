using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DemoCS
{
    public class SVie
    {
        public string MSSV {get; set;}

        public string Name {get; set;}

        public int Age {get; set;}

       /* public string getMSSV()
        {
            return this.MSSV;
        }

        public void setMSSV(string MSSV)
        {
            this.MSSV = MSSV;
        }

        public string P_Name
        {
            get {return this.Name;}
            set {this.Name = value;}
        }
        public SV()
        {
            this.MSSV = "0";
            this.Name = "";
            this.Age = 0;
        }
        public SV(string MSSV, string Name, int Age)
        {
            this.MSSV = MSSV;
            this.Name = Name;
            this.Age = Age;
        }
        public SV(SV sv)
        {
            this.MSSV = sv.MSSV;
            this.Name = sv.Name;
            this.Age = sv.Age;
        }*/
       /* public string Show()
        {
            return (this.MSSV + this.Name + this.Age);
        }*/
        public override string ToString()
        {
            return (this.MSSV + this.Name + this.Age);
        }
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            if (this.Age > ((SV)obj).Age)
            return true;
            else return false;
        }
    }
}   