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

  class CreatorProgrammerVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new ProgrammerVacancy();
    }
  }

  class CreatorMechanicVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new MechanicVacancy();
    }
  }

  class CreatorOtherVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new OtherVacancy();
    }
  }

  class CreatorTeacherVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new TeacherVacancy();
    }
  }

  class CreatorAccountantVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new AccountantVacancy();
    }
  }

  class CreatorDoctorVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new DoctorVacancy();
    }
  }

  class CreatorWaiterVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new WaiterVacancy();
    }
  }
}
