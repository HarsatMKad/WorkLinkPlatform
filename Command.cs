using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLink
{
  class Receiver
  {
    public void Operation()
    {
      Console.WriteLine("функция работает");
    }
  }

  abstract class Command
  {
    public abstract void Execute();
  }

  class ConcreteCommand : Command
  {
    Receiver receiver;
    public ConcreteCommand(Receiver r)
    {
      receiver = r;
    }
    public override void Execute()
    {
      receiver.Operation();
    }
  }
  class Invoker
  {
    Command command;
    public void SetCommand(Command c)
    {
      command = c;
    }
    public void Run()
    {
      command.Execute();
    }
  }
}
