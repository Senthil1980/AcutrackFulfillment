using System;
using System.Collections.Generic;
using System.Text;

namespace AcutrackFulfillment.Core
{
    [Flags]
    public enum Permission
    {
        View = 1,
        Modify = 2,
        Manage = 4,
        Create = 8,
        Impersonate = 16
    }
}
