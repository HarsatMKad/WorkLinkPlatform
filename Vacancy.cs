using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLink
{
  abstract class Vacancy : IObserver
  {
    public void Update()
    {
      Console.WriteLine("Новая вакансия добавлена");
    }
  }

  class VacancyProgrammer : Vacancy
  {
    string Name = "VacancyNAME";
    int Salary = 10000;
    string[] RequiredSkills = { "abc1", "abc2", "abc3" };
    string Content = "fwqfgjergiuershgjkerhng";
    string Company = "OOO fgewrger";
    int CompanyRating = 4;
  }
}
