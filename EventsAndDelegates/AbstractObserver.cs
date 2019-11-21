using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class AbstractObserver
    {
        public AndreisDelegate Update;
        public virtual void Abonare()
        {
            MeteoStation.Instance.Attach(Update);
        }
    }
}
