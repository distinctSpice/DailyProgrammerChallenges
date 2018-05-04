using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRabbitProblem.Implementation
{
    public class RabbitSimulation
    {
        private const int MALE_PER_LITTER = 5;
        private const int FEMALE_PER_LITTER = 9;

        private readonly int _targetPopulation;
        private int _maleRabbits;
        private int _femaleRabbits;

        private List<Rabbit> _rabbits;

        public RabbitSimulation(int maleRabbits, int femaleRabbits, int targetPopulation)
        {
            _maleRabbits = maleRabbits;
            _femaleRabbits = femaleRabbits;
            _targetPopulation = targetPopulation;

            _rabbits = new List<Rabbit>();
            _rabbits.AddRange(Breed(maleRabbits, femaleRabbits));
        }

        public Tuple<int, int, int> Begin()
        {
            var months = 0;
            var aliveRabbitsCount = _rabbits.Count(r => r.Status != Rabbit.RabbitStatusEnums.Dead);

            while (aliveRabbitsCount < _targetPopulation)
            {
                var newRabbits = Breed();
                _rabbits.AddRange(newRabbits);

                foreach (var rabbit in _rabbits)
                {
                    rabbit.Age++;

                    //Debug.WriteLine(
                    //    string.Format("{0} {1}", rabbit.Age, rabbit.Status));
                }

                //Debug.WriteLine("-------------------------");

                aliveRabbitsCount = _rabbits.Count(r => r.Status != Rabbit.RabbitStatusEnums.Dead);
                months++;
            }

            return new Tuple<int, int, int>(
                _rabbits.Count(r => r.Status != Rabbit.RabbitStatusEnums.Dead),
                _rabbits.Count(r => r.Status == Rabbit.RabbitStatusEnums.Dead),
                months);
        }
        
        public List<Rabbit> Breed()
        {
            var newRabbits = new List<Rabbit>();
            var validPairCount = GetValidRabbitPairs();

            for (var i = 0; i < MALE_PER_LITTER * validPairCount; i++)
            {
                newRabbits.Add(new Rabbit { Gender = Rabbit.RabbitGenderEnums.Male });
                _maleRabbits++;
            }

            for (var i = 0; i < FEMALE_PER_LITTER * validPairCount; i++)
            {
                newRabbits.Add(new Rabbit { Gender = Rabbit.RabbitGenderEnums.Female });
                _femaleRabbits++;
            }
            
            return newRabbits;
        }

        public List<Rabbit> Breed(int maleSize, int femaleSize)
        {
            var newRabbits = new List<Rabbit>();

            for (var i = 0; i < maleSize; i++)
            {
                newRabbits.Add(new Rabbit { Gender = Rabbit.RabbitGenderEnums.Male });
                _maleRabbits++;
            }

            for (var i = 0; i < femaleSize; i++)
            {
                newRabbits.Add(new Rabbit { Gender = Rabbit.RabbitGenderEnums.Female });
                _femaleRabbits++;
            }

            return newRabbits;
        }

        public int GetValidRabbitPairs()
        {
            var breedingFemales = _rabbits.Count(r => r.Gender == Rabbit.RabbitGenderEnums.Female && r.Status == Rabbit.RabbitStatusEnums.Fertile);
            return breedingFemales;
        }
    }
}
