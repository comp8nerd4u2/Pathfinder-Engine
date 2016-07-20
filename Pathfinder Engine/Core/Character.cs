using Pathfinder_Engine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pathfinder_Engine.Core {
    class Character : ISelfSerializable<Character> {

        int hp;
        public Character Deserialize(StreamReader target) {
            throw new NotImplementedException();
        }

        public void Serialize(StreamWriter target) {
            target.Write(hp);
            throw new NotImplementedException();
        }
    }
}
