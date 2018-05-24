using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
    public enum Organisation { Policlinnika6 = 1, Policlinnika12, HAK, Sunkar, Rakhat, Policlinnika3, Policlinnika4 }
    public enum Addresss { Shevshenko22, Aptynsarina3, Matepfkrf11, AbilayHana43, KabanbayBatyra81, Abaya2, Doatyr310 }

    public class GeterationMedSenter
    {
        private Random rand = new Random();
        public List<MedOrganization> listMed;

        public MedOrganization this[int id]
        {
            get
            {
                foreach (MedOrganization item in listMed)
                {
                    if (item.Id == id)
                        return item;
                }
                return null;
            }
        }

        public GeterationMedSenter()
        {
            listMed = new List<MedOrganization>();
        }

        public void GenetateMed()
        {
            for (int i = 1; i < 7; i++)
            {
                MedOrganization med = new MedOrganization();
                med.Id = i;
                med.NameOrg = ((Organisation)(rand.Next(0, 6))).ToString();
                med.Address = ((Addresss)rand.Next(0, 6)).ToString();
                med.Tel = (rand.Next(300000, 999999)).ToString();
                listMed.Add(med);
            }
        }

        public void PrintMed()
        {
            foreach (MedOrganization item in listMed)
            {
                item.PrintInfo();
                Console.WriteLine("----------------------------------");
            }
        }


        public MedOrganization SearchMedOrg()
        {
            Console.Clear();
            PrintMed();
            Console.WriteLine("Enter Med organization Name and telephone ");
            string MedName = Console.ReadLine();
            string tel = Console.ReadLine();

            bool t = false;
            foreach (MedOrganization item in listMed)
            {
                if (item.NameOrg.Contains(MedName) && item.Tel.Contains(tel))
                {
                    item.PrintInfo();
                    return item;
                    t = true;

                    break;
                }
            }
            if (!t) Console.WriteLine("There is no such Med organization");
            return null;
        }
    }
}
