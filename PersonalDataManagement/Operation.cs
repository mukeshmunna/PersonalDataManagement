using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDataManagement
{
    public class Operation
    {
        public void RetreiveTopTwoRecords(List<Person> list)
        {
            var result = list.Where(x => x.Age < 60).Take(2);
            Display(result.ToList());
        }
        public void Display(List<Person> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.SSN + " " + data.Name + " " + data.Address + " " + data.Age);
            }
        }
    }
}
