using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLink
{
  class Resume : IObservable
  {
    private List<IObserver> Observers;

    string LastNameFirstName;
    string Citizenship;
    string Address;
    string DateBirth;
    string Sex;
    string EducationInfo;
    long PhoneNumber;
    string Mail;
    int DesiredSalary;
    string[] Skills;
    string AdditionalInfo;
    public List<Vacancy> AcceptedVacancies;

    public Resume(string LastNameFirstName, string Citizenship, string Address, string DateBirth, string Sex, string EducationInfo, long PhoneNumber, string Mail, int DesiredSalary, string[] Skills, string AdditionalInfo)
    {
      Observers = new List<IObserver>();
      AcceptedVacancies = new List<Vacancy>();
      this.LastNameFirstName = LastNameFirstName;
      this.Citizenship = Citizenship;
      this.Address = Address;
      this.DateBirth = DateBirth;
      this.Sex = Sex;
      this.EducationInfo = EducationInfo;
      this.PhoneNumber = PhoneNumber;
      this.Mail = Mail;
      this.DesiredSalary = DesiredSalary;
      this.Skills = Skills;
      this.AdditionalInfo = AdditionalInfo;
    }

    public void AddVacancies(Vacancy Vacancy)
    {
      AcceptedVacancies.Add(Vacancy);
      Observers.Add(Vacancy);
    }

    public void RemoveVacancies(Vacancy Vacancy)
    {
      AcceptedVacancies.Remove(Vacancy);
      Observers.Remove(Vacancy);
    }

    public void NotifyObservers()
    {
      foreach (IObserver observer in Observers)
        observer.Update();
    }
  }
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
