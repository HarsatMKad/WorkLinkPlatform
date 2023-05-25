using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLink
{
  abstract class CreatorVacancy 
  {
    public abstract Vacancy FactoryMethod();
  }

  class CreatorVacancyProgrammer : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new VacancyProgrammer();
    }
  }
}
