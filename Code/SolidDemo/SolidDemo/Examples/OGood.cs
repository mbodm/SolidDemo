using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.OGood
{
    public class User
    {
        public virtual int GetRating() { return 1000; } // BaseValue
    }

    public sealed class StandardUser : User
    {
        public override int GetRating() { return base.GetRating() + 200; }
    }

    public sealed class AdminUser : User
    {
        public override int GetRating() { return base.GetRating() + 500; }
    }

    public sealed class SomeClass
    {
        public int GetUserRating(User user)
        {
            return user.GetRating();
        }
    }
}
