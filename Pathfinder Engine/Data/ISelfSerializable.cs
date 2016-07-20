using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Engine.Data {
    interface ISelfSerializable<T> {
        void Serialize(StreamWriter target);
        T Deserialize(StreamReader target);
    }
}
