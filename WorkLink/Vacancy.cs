using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WorkLink
{
  public class Vacancy : IObserver
  {
    public int ID;
    public string VacancyType;
    public string Name;
    public long Salary;
    public string RequiredSkills;
    public string Details;
    public string Company;
    public double CompanyRating;

    public void Update()
    {
      MessageBox.Show("Новая вакансия добавлена");
    }
  }

  public class ProgrammerVacancy : Vacancy
  { }

  public class MechanicVacancy : Vacancy
  { }

  public class OtherVacancy : Vacancy
  { }

  public class TeacherVacancy : Vacancy
  { }

  public class AccountantVacancy : Vacancy 
  { }

  public class DoctorVacancy : Vacancy
  { }

  public class WaiterVacancy : Vacancy 
  { }
}
