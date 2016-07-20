using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Engine.Core {
    class Console {
        private static char[] rawBuffer = new char[500000];
        private static string buffer = "";

        public static void print(string message) {
            buffer += message;
        }

        public static void println(string message) {
            print(message + "\r\n");
        }
    }
}
