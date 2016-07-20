using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Engine.Data {
    class Database : ISelfSerializable<Database> {
        TreeNode root;

        public Database Deserialize(StreamReader target) {
            throw new NotImplementedException();
        }

        public void Serialize(StreamWriter target) {
            throw new NotImplementedException();
        }
    }
}
