using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLink
{
  public abstract class CreatorVacancy 
  {
    public abstract Vacancy FactoryMethod();
  }

  public class CreatorProgrammerVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new ProgrammerVacancy();
    }
  }

  public class CreatorMechanicVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new MechanicVacancy();
    }
  }

  public class CreatorOtherVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new OtherVacancy();
    }
  }

  public class CreatorTeacherVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new TeacherVacancy();
    }
  }

  public class CreatorAccountantVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new AccountantVacancy();
    }
  }

  public class CreatorDoctorVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new DoctorVacancy();
    }
  }

  public class CreatorWaiterVacancy : CreatorVacancy
  {
    public override Vacancy FactoryMethod()
    {
      return new WaiterVacancy();
    }
  }
}
