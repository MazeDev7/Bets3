using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingGame
{
    public interface INumberGenerator
    {
        int Next(int minValue, int maxValue);
    }

    public class FakeNumberGenerator : INumberGenerator
    {
        private List<int> _valuesToGenerate;
        private int numberOfNumbersGenerated;

        public FakeNumberGenerator(List<int> valuesToGenerate)
        {
            _valuesToGenerate = valuesToGenerate;
            numberOfNumbersGenerated = 0;
        }
        public int Next(int minValue, int maxValue)
        {
            return _valuesToGenerate[numberOfNumbersGenerated++ % _valuesToGenerate.Count];
        }
    }

    public class RandomNumberGenerator : INumberGenerator
    {
        private Random random;

        public RandomNumberGenerator()
        {
            random = new Random();
        }

        public int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }

}
