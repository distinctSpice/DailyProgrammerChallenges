using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRabbitProblem.Implementation
{
    public class Rabbit
    {
        private const int NEWBORN_AGE = 2;
        private const int FERTILE_AGE_START = 4;
        private const int MAXIMUM_AGE = 96; // in months

        public enum RabbitGenderEnums
        {
            Male = 1,
            Female = 2
        }

        public enum RabbitStatusEnums
        {
            Newborn = 1,
            Fertile = 2,
            Dead = 3
        }

        public Rabbit()
        {
            Age = 2;
        }

        public RabbitGenderEnums Gender { get; set; }
        public int Age { get; set; }
        public RabbitStatusEnums Status
        {
            get
            {
                if (Age >= NEWBORN_AGE)
                {
                    return RabbitStatusEnums.Newborn;
                }
                else if (Age >= FERTILE_AGE_START && Age < MAXIMUM_AGE)
                {
                    return RabbitStatusEnums.Fertile;
                }
                else
                {
                    return RabbitStatusEnums.Dead;
                }
            }
        }
    }
}
