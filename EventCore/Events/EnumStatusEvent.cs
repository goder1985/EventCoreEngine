using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCore.Events
{
    public enum EnumStatusEvent
    {
        None,
        EventExist,
        AlreadyHandleSubScrible,
        HandleNotSubScrible,
        NotFoundEvent,
        Sucsess,
    }
}
