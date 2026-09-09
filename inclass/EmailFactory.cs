using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass
{
    public class EmailFactory : NotificationFactory
    {
        public override INotification CreateINotification()
        {
            return new EmailINotification();
        }
    }
}
