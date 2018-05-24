using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Interfaces;

namespace Test.Classes
{
    /*Приложение с авторизацией (включает в себя три модуля)
А) Модуль Прикрепления пациента
Б) Контролирующий модуль
В) Отчет о прикрепленных пациентах

авторизуемый пользователь, может иметь права доступа как к одному из этих модулей, так и ко всем сразу.
*/
    public class ModuleSet
    {
        public bool Zakreplenir(ref GeterationMedSenter organ, ref GenerationPatien pat, out string message)
        {
            Console.Clear();

            foreach (Patient item in pat.listPat)
            {
                item.PrintInfo();
            }
            Console.WriteLine("");
            Patient selP = new Patient();
            Console.WriteLine("Select Patient ");
            int choiceP = Int32.Parse(Console.ReadLine());
            selP = pat[choiceP];
            Console.WriteLine("");


            foreach (MedOrganization item2 in organ.listMed)
            {
                item2.PrintInfo();
            }
            Console.WriteLine("");
            MedOrganization selM = new MedOrganization();
            Console.WriteLine("Select Med organization ");
            int choiceM = Int32.Parse(Console.ReadLine());
            selM = organ[choiceM];
            Console.WriteLine("");

            Console.Clear();

            var t = organ.listMed.FirstOrDefault(f => f.Id == choiceM);

            foreach (var p in t.patients)
            {
                if (p.IIN == choiceP)
                {
                    message = "This patient is already attached!";
                    return false;
                }
            }

            t.patients.Add(selP);
            pat.listPat.FirstOrDefault(f => f.IIN == choiceP)
                .MedOrgan = selM;

            message = "The patient is successfully attached!";
            return true;
        }

    }

}

