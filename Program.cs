using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLink
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] skils = { "fwe", "ghtegh", "qfd" };
      Resume r = new Resume("Rfltcybrjd Vb[fbk", "hjccbz", "rtvthjdj", "02.04.2004", "male", "rtvue", 5487624105, "grewge@greg.com", 50000, skils, "gweirghuewhfuigewr");

      CreatorVacancy cv = new CreatorVacancyProgrammer();
      Vacancy v = cv.FactoryMethod();

      r.AddVacancies(v);
      r.AddVacancies(v);
      r.AddVacancies(v);

      r.NotifyObservers();

      foreach(Vacancy item in r.AcceptedVacancies)
      {
        Console.WriteLine(item.ToString());
      }

      Invoker invoker = new Invoker();
      Receiver receiver = new Receiver();
      ConcreteCommand command = new ConcreteCommand(receiver);
      invoker.SetCommand(command);
      invoker.Run();

      Console.ReadKey();
    }
  }
}
