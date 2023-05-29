using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLink
{
  interface IObserver
  {
    void Update();
  }

  interface IObservable
  {
    void AddObserver(Vacancy o);
    void RemoveObserver();
    void NotifyObserver();
  }

}
