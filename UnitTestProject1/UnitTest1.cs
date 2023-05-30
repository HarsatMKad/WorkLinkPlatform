using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkLink;
using System.IO;
using Newtonsoft.Json;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestAreNotEqualMethod()
    {
      Vacancy Vacancy = new Vacancy();
      Resume Resume = new Resume();
      Resume.AddObserver(Vacancy);
      Resume Resume2 = new Resume();

      Assert.AreNotEqual(Resume2, Resume);
    }

    [TestMethod]
    public void TestRemoveObserverMethod()
    {
      Vacancy Vacancy = new Vacancy();
      Resume Resume = new Resume();
      Resume Resume2 = Resume;

      Resume.AddObserver(Vacancy);
      Resume.RemoveObserver();

      Assert.AreEqual(Resume2, Resume);
    }

    [TestMethod]
    public void TestFactoryMethod()
    {
      CreatorVacancy Creator = new CreatorProgrammerVacancy();
      Vacancy Vacancy = Creator.FactoryMethod();
      ProgrammerVacancy ProgrammerVacancy = new ProgrammerVacancy();
      Assert.AreEqual(ProgrammerVacancy.GetType(), Vacancy.GetType());

      CreatorVacancy CreatorMechanicVacancy = new CreatorMechanicVacancy();
      Vacancy = CreatorMechanicVacancy.FactoryMethod();
      MechanicVacancy MechanicVacancy = new MechanicVacancy();
      Assert.AreEqual(MechanicVacancy.GetType(), Vacancy.GetType());

      CreatorTeacherVacancy CreatorTeacherVacancy = new CreatorTeacherVacancy();
      Vacancy = CreatorTeacherVacancy.FactoryMethod();
      TeacherVacancy TeacherVacancy = new TeacherVacancy();
      Assert.AreEqual(TeacherVacancy.GetType(), Vacancy.GetType());

      CreatorAccountantVacancy CreatorAccountantVacancy = new CreatorAccountantVacancy();
      Vacancy = CreatorAccountantVacancy.FactoryMethod();
      AccountantVacancy AccountantVacancy = new AccountantVacancy();
      Assert.AreEqual(AccountantVacancy.GetType(), Vacancy.GetType());

      CreatorDoctorVacancy CreatorDoctorVacancy = new CreatorDoctorVacancy();
      Vacancy = CreatorDoctorVacancy.FactoryMethod();
      DoctorVacancy DoctorVacancy = new DoctorVacancy();
      Assert.AreEqual(DoctorVacancy.GetType(), Vacancy.GetType());

      CreatorWaiterVacancy CreatorWaiterVacancy = new CreatorWaiterVacancy();
      Vacancy = CreatorWaiterVacancy.FactoryMethod();
      WaiterVacancy WaiterVacancy = new WaiterVacancy();
      Assert.AreEqual(WaiterVacancy.GetType(), Vacancy.GetType());
    }

    [TestMethod]
    public void TestUndoMethod()
    {
      Resume Resume = JsonConvert.DeserializeObject<Resume>(File.ReadAllText("Resume.json"));
      Resume = new Resume("1", "2", "3", "4", "5", "6", "7", "8", 9, "10", "11");

      Invoker invoker = new Invoker();
      Receiver receiver = new Receiver();
      ConcreteCommand command = new ConcreteCommand(receiver);
      invoker.SetCommand(command);
      Resume = invoker.Undo();

      Assert.AreNotEqual(Resume, new Resume("1", "2", "3", "4", "5", "6", "7", "8", 9, "10", "11"));
    }

    [TestMethod]
    public void TestRunMethod()
    {
      Resume Resume = new Resume("1", "2", "3", "4", "5", "6", "7", "8", 9, "10", "11");
      string RonstituentsResume = Resume.LastNameFirstName + Resume.Citizenship + Resume.Address + Resume.DateBirth + Resume.Sex + Resume.EducationInfo + Resume.PhoneNumber + Resume.Mail + Resume.DesiredSalary.ToString() + Resume.Skills + Resume.AdditionalInfo;
      Invoker invoker = new Invoker();
      Receiver receiver = new Receiver();
      ConcreteCommand command = new ConcreteCommand(receiver);
      invoker.SetCommand(command);

      Resume NewResume = invoker.Run("1", "2", "3", "4", "5", "6", "7", "8", 9, "10", "11");
      string RonstituentsNewResume = NewResume.LastNameFirstName + NewResume.Citizenship + NewResume.Address + NewResume.DateBirth + NewResume.Sex + NewResume.EducationInfo + NewResume.PhoneNumber + NewResume.Mail + NewResume.DesiredSalary.ToString() + NewResume.Skills + NewResume.AdditionalInfo;

      Assert.AreEqual(RonstituentsResume, RonstituentsNewResume);
    }

    [TestMethod]
    public void TestAcceptMethod()
    {
      Invoker invoker = new Invoker();
      Receiver receiver = new Receiver();
      ConcreteCommand command = new ConcreteCommand(receiver);
      invoker.SetCommand(command);
      Resume NewResume = invoker.Run("1", "2", "3", "4", "5", "6", "7", "8", 9, "10", "11");
      string RonstituentsNewResume = NewResume.LastNameFirstName + NewResume.Citizenship + NewResume.Address + NewResume.DateBirth + NewResume.Sex + NewResume.EducationInfo + NewResume.PhoneNumber + NewResume.Mail + NewResume.DesiredSalary.ToString() + NewResume.Skills + NewResume.AdditionalInfo;
      invoker.Accept();

      Resume JSONResume = JsonConvert.DeserializeObject<Resume>(File.ReadAllText("Resume.json"));
      string RonstituentsJSONResume = JSONResume.LastNameFirstName + JSONResume.Citizenship + JSONResume.Address + JSONResume.DateBirth + JSONResume.Sex + JSONResume.EducationInfo + JSONResume.PhoneNumber + JSONResume.Mail + JSONResume.DesiredSalary.ToString() + JSONResume.Skills + JSONResume.AdditionalInfo;

      Assert.AreEqual(RonstituentsNewResume, RonstituentsJSONResume);
    }
  }
}
