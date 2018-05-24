using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test.Classes
{
    /*4.	Запросы на прикрепление (Дата создания, Дата обработки, Пациент, статус запроса)*/
    public class AttachmentRequests 
    {
        public DateTime StartCreation { get; set; }
        public DateTime ВateOfProcessing { get; set; }
        public string status { get; set; }
        public string Patient { get; set; }
        public string MedOrganis { get; set; }
    }
}
