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

    public string LastNameFirstName;
    public string Citizenship;
    public string Address;
    public string DateBirth;
    public string Sex;
    public string EducationInfo;
    public long PhoneNumber;
    public string Mail;
    public long DesiredSalary;
    public string Skills;
    public string AdditionalInfo;
    public List<Vacancy> AcceptedVacancies;

    public Resume(string LastNameFirstName, string Citizenship, string Address, string DateBirth, string Sex, string EducationInfo, long PhoneNumber, string Mail, long DesiredSalary, string Skills, string AdditionalInfo)
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
}
