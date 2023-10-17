//Create a function that takes a number as its only argument and returns true if it's less than or equal to zero, otherwise return false.
using System;

namespace Challenges
{
    public class Program8
    {
        public static bool LessThanOrEqualToZero(double a) => a <= 0 ;
    }
}
/*
         public bool TernnaryG(double a) => a > 0 ? false : true;

        {
            return a > 0 ? false : true;
        }

        public bool SimpleG(double a) => !(0 < a);

        public bool SimpleBodyG(double a)
        {
            return !(0 < a);
        }

        public bool TraditionalG(double a)
        {
            if (a > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool TraditionalF(double a)
        {
            if (!(0 < a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SwitchInsG(double a)
        {
            switch (a)
            {
                case > 0:
                    return false;
                default:
                    return true;
            }
        }

        public bool SwitchExpG(double a)
        {
            return a switch
            {
                > 0 => false,
                _ => true
            };
        }

        public bool Ternnary(double a) => a <= 0 ? true : false;

        public bool TernnaryBody(double a)
        {
            return a <= 0 ? true : false;
        }

        public bool Simple(double a) => a <= 0;

        public bool SimpleBody(double a)
        {
            return a <= 0;
        }

        public bool Traditional(double a)
        {
            if (a <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SwitchIns(double a)
        {
            switch (a)
            {
                case <= 0:
                    return true;
                default:
                    return false;
            }
        }

        public bool SwitchExp(double a)
        {
            return a switch
            {
                <= 0 => true,
                _ => false
            };
        }
*/