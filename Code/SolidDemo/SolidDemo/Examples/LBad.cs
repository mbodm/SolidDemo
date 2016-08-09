using SolidDemo.LGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.LBad
{
    public sealed class AdminUser : User
    {
        public override void Init()
        {
            base.Init();

            /* ... */
            throw new InvalidProgramException();
        }
    }
}
