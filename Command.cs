using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WorkLink
{
  class Receiver
  {
    Resume Resume;
    public Resume ChangeResume(string LastNameFirstName, string Citizenship, string Address, string DateBirth, string Sex, string EducationInfo, long PhoneNumber, string Mail, long DesiredSalary, string Skills, string AdditionalInfo)
    {
      Resume = new Resume(LastNameFirstName, Citizenship, Address, DateBirth, Sex, EducationInfo, PhoneNumber, Mail, DesiredSalary, Skills, AdditionalInfo);
      return Resume;
    }

    public Resume SaveResume()
    {
      JsonSerializer Serializer = new JsonSerializer();

      using (StreamWriter Writer = new StreamWriter("Resume.json"))
      {
        JsonTextWriter JsonWriter = new JsonTextWriter(Writer) { CloseOutput = false };
        Serializer.Serialize(JsonWriter, Resume);
      }
      return Resume;
    }

    public Resume CancelChanges()
    {
      string JsonFileName = "Resume.json";
      Resume = JsonConvert.DeserializeObject<Resume>(File.ReadAllText(JsonFileName));
      return Resume;
    }
  }

  abstract class Command
  {
    public abstract Resume Execute(string LastNameFirstName, string Citizenship, string Address, string DateBirth, string Sex, string EducationInfo, long PhoneNumber, string Mail, long DesiredSalary, string Skills, string AdditionalInfo);

    public abstract Resume Accept();

    public abstract Resume Undo();
  }

  class ConcreteCommand : Command
  {
    Resume Resume;
    Receiver receiver;
    public ConcreteCommand(Receiver r)
    {
      receiver = r;
    }
    public override Resume Execute(string LastNameFirstName, string Citizenship, string Address, string DateBirth, string Sex, string EducationInfo, long PhoneNumber, string Mail, long DesiredSalary, string Skills, string AdditionalInfo)
    {
      Resume = receiver.ChangeResume(LastNameFirstName, Citizenship, Address, DateBirth, Sex, EducationInfo, PhoneNumber, Mail, DesiredSalary, Skills, AdditionalInfo);
      return Resume;
    }

    public override Resume Accept()
    {
      Resume = receiver.SaveResume();
      return Resume;
    }

    public override Resume Undo()
    {
      Resume = receiver.CancelChanges();
      return Resume;
    }
  }
  class Invoker
  {
    Resume Resume;
    Command command;
    public void SetCommand(Command c)
    {
      command = c;
    }
    public Resume Run(string LastNameFirstName, string Citizenship, string Address, string DateBirth, string Sex, string EducationInfo, long PhoneNumber, string Mail, long DesiredSalary, string Skills, string AdditionalInfo)
    {
      Resume = command.Execute(LastNameFirstName, Citizenship, Address, DateBirth, Sex, EducationInfo, PhoneNumber, Mail, DesiredSalary, Skills, AdditionalInfo);
      return Resume;
    }

    public Resume Accept()
    {
      Resume = command.Accept();
      return Resume;
    }

    public Resume Undo()
    {
      Resume = command.Undo();
      return Resume;
    }
  }
}
