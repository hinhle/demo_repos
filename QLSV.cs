using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DemoCS
{
    public class QLSV
    {
        public SV[] listSV {get; set;}
        public int length {get; set;}

        public QLSV()
        {
            this.listSV = null;
            this.length = 0;
        }
        public void CreateDB()
        {
            SV s1 = new SV {
                MSSV = "1",
                Name = "NVA",
                Age = 18
            };
             SV s2 = new SV {
                MSSV = "2",
                Name = "NVB",
                Age = 20
            };
             SV s3 = new SV {
                MSSV = "3",
                Name = "NVC",
                Age = 19
            };
             SV s4 = new SV {
                MSSV = "4",
                Name = "NVD",
                Age = 16
            };
            Add(s1);
            Add(s2);
            Add(s3);
            Add(s4);
        }

        public void Add(SV s)
        {
            SV[] temp = new SV [this.length + 1];
            if(this.length != 0)
            {
                for(int i = 0; i < this.length; i++)
                {
                    temp[i] = new SV {
                        MSSV = this.listSV[i].MSSV,
                        Name = this.listSV[i].Name,
                        Age = this.listSV[i].Age
                     };
                }
            }
            temp[this.length] = new SV {
                MSSV = s.MSSV,
                Name = s.Name,
                Age = s.Age
            };
            this.listSV = temp;
            this.length++;
        }

        public void Show()
        {
            foreach(SV s in this.listSV)
            Console.WriteLine(s.ToString());
        }

        public void Remove(SV s)
        {
            int index = -1;
            foreach(SV sv in this.listSV)
            {
                index++;
                if(sv.MSSV == s.MSSV && sv.Name == s.Name && sv.Age == s.Age)
                {
                    RemoveAt(index);
                    return;
                }
            }
        }
        public void RemoveAt(int index)
        {
            SV[] temp = new SV [this.length - 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = new SV {
                        MSSV = this.listSV[i].MSSV,
                        Name = this.listSV[i].Name,
                        Age = this.listSV[i].Age
                     };
            }
            for (int i = index ; i < this.length - 1; i++)
            {
                temp[i] = new SV {
                        MSSV = this.listSV[i + 1].MSSV,
                        Name = this.listSV[i + 1].Name,
                        Age = this.listSV[i + 1].Age
                     };
            }
            this.listSV = temp;
            this.length--;
        }
        public void Update(SV s, int index)
        {
            if(index < 0 || index >=this.length)
            {
                Console.WriteLine("Index error !!!");
                return;
            } 
            this.listSV[index].MSSV = s.MSSV;
            this.listSV[index].Name = s.Name;
            this.listSV[index].Age = s.Age;
        }
        public int IndexOf(SV s)
        {
            int index = -1;
            foreach(SV sv in this.listSV)
            {
                index++;
                if(sv.MSSV == s.MSSV && sv.Name == s.Name && sv.Age == s.Age)
                {
                    return index;
                }
            }
            return -1;
        }

        public void Sort()
        {
            for(int i = 0 ; i < this.length - 1; i++)
            for(int j = 0 ; j < this.length - i- 1; j++)
            {
                if(listSV[j].Equals(listSV[j + 1])) Swap(ref listSV[j], ref listSV[j + 1]);
            }
        }
        public void Swap(ref SV a, ref SV  b)
        {
            SV temp = new SV {
                        MSSV = a.MSSV,
                        Name = a.Name,
                        Age = a.Age
                     };
            a = b;
            b = temp;
        }
    }

    public class SV
    {
        public string MSSV {get; set;}

        public string Name {get; set;}

        public int Age {get; set;}

      
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