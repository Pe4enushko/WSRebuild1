using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSkillsRebuild1
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderFinished { get; set; }
        public string PatientLogin { get; set; }
        public Order(int ID, DateTime orderDate, string patientLogin)
        {
            OrderDate = orderDate;
            OrderFinished = DateTime.MinValue;
            OrderId = ID;
            PatientLogin = patientLogin;
        }
        public Order(int ID, DateTime orderDate,DateTime orderFinished, string patientLogin)
        {
            OrderId = ID;
            OrderDate = orderDate;
            OrderFinished = orderFinished;
            PatientLogin = patientLogin;
        }
        public string GetOrderString()
        {
            if (OrderFinished != DateTime.MinValue)
            {
                return $"ID: {OrderId} Created: {OrderDate.Date.ToString("yyyy-MM-dd")} Finished: {OrderFinished.Date.ToString("yyyy-MM-dd")} Patient: {PatientLogin}";
            }
            else
            {
                return $"ID: {OrderId} Created: {OrderDate.Date.ToString("yyyy-MM-dd")} Patient: {PatientLogin}";
            }
        }

    }
}
