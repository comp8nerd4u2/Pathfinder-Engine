using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Engine.Core {
    class Dice {
        public int Sides;
        public Round RoundingBehaviour;
        public Random oRand;

        public enum Round {
            UP, DOWN
        }

        public Dice(int sides, Round roundingBehaviour) {
            Sides = sides;
            RoundingBehaviour = roundingBehaviour;
            oRand = new Random();
        }

        public int Roll() {
            double dRand = oRand.NextDouble() * Sides;
            int result = 0;
            switch (RoundingBehaviour) {
                case Round.DOWN:
                    result = (int)Math.Floor(dRand);
                    break;
                case Round.UP:
                    result = (int)Math.Ceiling(dRand);
                    break;
            }
            return result;
        }
    }
}
