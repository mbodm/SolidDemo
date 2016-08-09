using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.LGood
{
    public class User
    {
        public virtual void Init()
        {
            /* ... */
            throw new InvalidCastException();
            /* ... */
            throw new InvalidOperationException();
        }
    }

    public sealed class StandardUser : User { }
    public sealed class SpecialUser : User { }

    public sealed class SomeClass
    {
        public void SomeMethod(User user)
        {
            try
            {
                user.Init();
            }
            catch (Exception e) when (e is InvalidCastException || e is InvalidOperationException)
            {
                // Critical abort !
            }
        }
    }
}
