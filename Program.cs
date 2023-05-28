using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WorkLink
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      string[] skils = { "fwe", "ghtegh", "qfd" };
      Resume r = new Resume("Rfltcybrjd Vb[fbk", "hjccbz", "rtvthjdj", "02.04.2004", "male", "rtvue", 5487624105, "grewge@greg.com", 50000, skils, "gweirghuewhfuigewr");

      CreatorVacancy cv = new CreatorProgrammerVacancy();
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
      */


      /*
      List<Vacancy> vacanciList = new List<Vacancy>();

      Vacancy prog1 = new ProgrammerVacancy();
      prog1.VacancyType = prog1.GetType().Name;
      prog1.Name = "Программист";
      prog1.Salary = 95000;
      string[] skils1 = { "Высшее образование техника-программиста", "Опыт работы с C#, JavaScript", "Стаж-работы 2 года" };
      prog1.RequiredSkills = skils1;
      prog1.Details = "Разработка кодового базиса для ПО разного назначения.";
      prog1.Company = "ООО Цифровое Будущее";
      prog1.CompanyRating = 4.6;
      vacanciList.Add(prog1);

      Vacancy prog2 = new ProgrammerVacancy();
      prog2.VacancyType = prog2.GetType().Name;
      prog2.Name = "Администратор баз данных";
      prog2.Salary = 80000;
      string[] skils2 = { "Среднее профессиональное образование техника-программиста", "Опыт работы с SQL", "Стаж работы 2 года" };
      prog2.RequiredSkills = skils2;
      prog2.Details = "Создание и администрирование баз данных для ПО коммерческого предназначения.";
      prog2.Company = "ОАО EyeTeam";
      prog2.CompanyRating = 3.8;
      vacanciList.Add(prog2);

      Vacancy prog3 = new ProgrammerVacancy();
      prog3.VacancyType = prog3.GetType().Name;
      prog3.Name = "Программист Python";
      prog3.Salary = 50000;
      string[] skils3 = { "Умение работать с Python, JS, MySQL", "Знание Django Framework", "Опыт работы 1-3 года" };
      prog3.RequiredSkills = skils3;
      prog3.Details = "Разработкой высоконагруженных систем.";
      prog3.Company = "ООО МИРИТ";
      prog3.CompanyRating = 4.7;
      vacanciList.Add(prog3);

      Vacancy prog4 = new ProgrammerVacancy();
      prog4.VacancyType = prog4.GetType().Name;
      prog4.Name = "Программист-стажер 1C";
      prog4.Salary = 35000;
      string[] skils4 = { "Профильное образование" };
      prog4.RequiredSkills = skils4;
      prog4.Details = "Автоматизацией предприятий на базе 1С";
      prog4.Company = "ООО Центр Автоматизации";
      prog4.CompanyRating = 4.6;
      vacanciList.Add(prog4);



      Vacancy mech1 = new MechanicVacancy();
      mech1.VacancyType = mech1.GetType().Name;
      mech1.Name = "Автомеханик";
      mech1.Salary = 65000;
      string[] skils5 = { "Среднее профессиональное образование автомеханика", "Опыт обслуживания общественного транспорта" };
      mech1.RequiredSkills = skils5;
      mech1.Details = "Диагностика, ремонт и обслуживание транспортных средств, в том числе и общественного транспорта для ОАО Общая Дорога";
      mech1.Company = "ОАО Надежный Мотор";
      mech1.CompanyRating = 4.2;
      vacanciList.Add(mech1);

      Vacancy mech2 = new MechanicVacancy();
      mech2.VacancyType = mech2.GetType().Name;
      mech2.Name = "Автомеханик";
      mech2.Salary = 55000;
      string[] skils6 = { "Среднее профессиональное образование автомеханика" };
      mech2.RequiredSkills = skils6;
      mech2.Details = "Диагностика, ремонт и обслуживание транспортных средств";
      mech2.Company = "ООО Техномонстр";
      mech2.CompanyRating = 3.5;
      vacanciList.Add(mech2);

      Vacancy mech3 = new MechanicVacancy();
      mech3.VacancyType = mech3.GetType().Name;
      mech3.Name = "Машинист общественного железнодорожного транспорта метрополитена";
      mech3.Salary = 55000;
      string[] skils7 = { "Среднее общее образование", "Справки из психоневрологического и наркологического диспансеров" };
      mech3.RequiredSkills = skils7;
      mech3.Details = "Оперирование общественными поездами метрополитена.";
      mech3.Company = "МУП Новосибирский Метрополитен";
      mech3.CompanyRating = 4.1;
      vacanciList.Add(mech3);



      Vacancy other1 = new OtherVacancy();
      other1.VacancyType = other1.GetType().Name;
      other1.Name = "Грузчик";
      other1.Salary = 45000;
      string[] skils8 = { "Водительские права категории C", "Физическая снаровка" };
      other1.RequiredSkills = skils8;
      other1.Details = "Перевозка строительных материалов. Также нужно будет иногда тоскать материалы на строительных комплексах вручную.";
      other1.Company = "ОАО Комплекс-Строй";
      other1.CompanyRating = 3.5;
      vacanciList.Add(other1);

      Vacancy other2 = new OtherVacancy();
      other2.VacancyType = other2.GetType().Name;
      other2.Name = "Кассир";
      other2.Salary = 15000;
      string[] skils9 = { "" };
      other2.RequiredSkills = skils9;
      other2.Details = "Обслуживание кассы магазина. Пополниние припасов в салоне магазина.";
      other2.Company = "ООО Ярче";
      other2.CompanyRating = 4.3;
      vacanciList.Add(other2);

      Vacancy other3 = new OtherVacancy();
      other3.VacancyType = other3.GetType().Name;
      other3.Name = "Сварщик";
      other3.Salary = 30000;
      string[] skils10 = { "Среднее профессиональное образование сварщика электросварочных и газосварочных работ, или среднее профессиональное образование наладчика сварочного и газоплазморезательного оборудования" };
      other3.RequiredSkills = skils10;
      other3.Details = "Сварочные работы на строительных комплексах, в жилых помещениях.";
      other3.Company = "ОАО Комплекс-Строй";
      other3.CompanyRating = 4.4;
      vacanciList.Add(other3);

      Vacancy other4 = new OtherVacancy();
      other4.VacancyType = other4.GetType().Name;
      other4.Name = "Сторож";
      other4.Salary = 15000;
      string[] skils11 = { "" };
      other4.RequiredSkills = skils11;
      other4.Details = "Ночная охрана территории детского сада.";
      other4.Company = "МБДОУ Детский Сад №41";
      other4.CompanyRating = 3.2;
      vacanciList.Add(other4);

      Vacancy other5 = new OtherVacancy();
      other5.VacancyType = other5.GetType().Name;
      other5.Name = "Дворник";
      other5.Salary = 20000;
      string[] skils12 = { "" };
      other5.RequiredSkills = skils12;
      other5.Details = "Уборка территории детского сада.";
      other5.Company = "МБДОУ Детский Сад №41";
      other5.CompanyRating = 3.2;
      vacanciList.Add(other5);

      Vacancy other6 = new OtherVacancy();
      other6.VacancyType = other6.GetType().Name;
      other6.Name = "Кондуктор общественного железнодорожного транспорта";
      other6.Salary = 20000;
      string[] skils13 = { "" };
      other6.RequiredSkills = skils13;
      other6.Details = "Проверка билетов и обеспечение комфортной поездки пассажиров поезда.";
      other6.Company = "ОАО РЖД";
      other6.CompanyRating = 3.9;
      vacanciList.Add(other6);

      Vacancy other7 = new OtherVacancy();
      other7.VacancyType = other7.GetType().Name;
      other7.Name = "Консультант продаж электроприборов";
      other7.Salary = 20000;
      string[] skils18 = { "Среднее общее образование", "Опыт работы с людьми", "Знание ассортемента и тенденций в отрасли" };
      other7.RequiredSkills = skils18;
      other7.Details = "Консультация и обслуживание покупателей, подбор техники.";
      other7.Company = "ПАО М.Видео";
      other7.CompanyRating = 4.0;
      vacanciList.Add(other7);



      Vacancy tech1 = new TeacherVacancy();
      tech1.VacancyType = tech1.GetType().Name;
      tech1.Name = "Педагог математических наук средних классов";
      tech1.Salary = 45000;
      string[] skils14 = { "Высшее математическое образование" };
      tech1.RequiredSkills = skils14;
      tech1.Details = "Обучение курсов алгебры и геометрии ученикам 5-9 классов.";
      tech1.Company = "МБОУ Школа №23";
      tech1.CompanyRating = 3.4;
      vacanciList.Add(tech1);

      Vacancy tech2 = new TeacherVacancy();
      tech2.VacancyType = tech2.GetType().Name;
      tech2.Name = "Педагог младших классов";
      tech2.Salary = 40000;
      string[] skils15 = { "Среднее профессиональное образование педагогики" };
      tech2.RequiredSkills = skils15;
      tech2.Details = "Обучение курсов русского языка, литературы и математики ученикам 1-4 классов.";
      tech2.Company = "МБОУ Школа №23";
      tech2.CompanyRating = 3.4;
      vacanciList.Add(tech2);



      Vacancy qwer1 = new AccountantVacancy();
      qwer1.VacancyType = qwer1.GetType().Name;
      qwer1.Name = "Бухгалтер отдела продаж";
      qwer1.Salary = 60000;
      string[] skils16 = { "Дополнительное профессиональное образование бухгалтера", "Стаж работы 3 года" };
      qwer1.RequiredSkills = skils16;
      qwer1.Details = "Учет поставок и использования продукции. Финансовый учет отдела.";
      qwer1.Company = "ООО Магнит";
      qwer1.CompanyRating = 4.4;
      vacanciList.Add(qwer1);

      Vacancy qwer2 = new AccountantVacancy();
      qwer2.VacancyType = qwer2.GetType().Name;
      qwer2.Name = "Маркетолог отдела продаж";
      qwer2.Salary = 60000;
      string[] skils17 = { "Высшее образование маркетинга или отраслевого маркетинга товаров и услуг", "Опыт работы 2 года" };
      qwer2.RequiredSkills = skils17;
      qwer2.Details = "Изучение тенденций рынка коммерции, утверждение стратегии развития продуктов, работа с клиентами";
      qwer2.Company = "ОАО EyeTeam";
      qwer2.CompanyRating = 4.8;
      vacanciList.Add(qwer2);



      Vacancy doc = new DoctorVacancy();
      doc.VacancyType = doc.GetType().Name;
      doc.Name = "Врач-терапевт";
      doc.Salary = 30000;
      string[] skils19 = { "Высшее профессиональное или послевузовское медицинское образование" };
      doc.RequiredSkills = skils19;
      doc.Details = "Диагностика заболеваний и первичная профилактика пациентов. Запись пациентов на прием врачам.";
      doc.Company = "ГАУЗ Клинический Консультативно-Диагностический Центр им. И.А. Колпинского";
      doc.CompanyRating = 4.2;
      vacanciList.Add(doc);



      Vacancy rewq = new WaiterVacancy();
      rewq.VacancyType = rewq.GetType().Name;
      rewq.Name = "Официант";
      rewq.Salary = 40000;
      string[] skils20 = { "Опыт работы с людьми" };
      rewq.RequiredSkills = skils20;
      rewq.Details = "Обслуживание клиентов кафе.";
      rewq.Company = "ИП Коффеёк";
      rewq.CompanyRating = 3.8;
      vacanciList.Add(rewq);

      
      JsonSerializer Serializer = new JsonSerializer();

      using (StreamWriter Writer = new StreamWriter("Vacancies.json"))
      {
        JsonTextWriter JsonWriter = new JsonTextWriter(Writer) { CloseOutput = false };
        Serializer.Serialize(JsonWriter, vacanciList);
      }
      */

      /*
      string q = "Rfltcybrjd Vb[fbk";
      string w = "Hjccbz";
      string e = "Rtvthjdj";
      string r = "02.04.2004";
      string t = "male";
      string y = "Rtvue";
      long u = 89511731009;
      string i = "frwefg@fwggs.com";
      int a = 25000;
      string skils =  "qw, re, df" ;
      string s = "fgwfgweruilghewruihewuiglhewufiorghlewr;";

      Resume resum = new Resume(q, w, e, r, t, y, u, i, a, skils, s);

      JsonSerializer Serializer = new JsonSerializer();

      using (StreamWriter Writer = new StreamWriter("Resume.json"))
      {
        JsonTextWriter JsonWriter = new JsonTextWriter(Writer) { CloseOutput = false };
        Serializer.Serialize(JsonWriter, resum);
      }
      */
      
    Application.Run(new Form1());
    
      /*
      int a = 21;
      int c = 22;
      int d = 23;
      int e = 24;
      int f = 25;
      int b = 5;
      Console.WriteLine(a % b);
      Console.WriteLine(c % b);
      Console.WriteLine(d % b);
      Console.WriteLine(e % b);
      Console.WriteLine(f % b);
      */
      Console.ReadKey();
    }
  }
}
