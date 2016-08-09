using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.OBad
{
    public enum UserType { StandardUser, AdminUser }

    public sealed class SomeClass
    {
        private const int BaseValue = 1000;

        public int GetUserRating(UserType userType)
        {
            int result;

            switch (userType)
            {
                case UserType.StandardUser:
                    result = BaseValue + 200;
                    break;
                case UserType.AdminUser:
                    result = BaseValue + 500;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}
