using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass
{
    public abstract class NotificationFactory
    {
        public abstract INotification CreateINotification();

        public void NotifyUser(string message)
        {
            INotification notification = CreateINotification();
            notification.Send(message);
        }
    }
}
