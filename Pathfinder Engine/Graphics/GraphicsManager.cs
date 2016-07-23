﻿using SharpDX.Direct2D1;
using ID2D1Factory = SharpDX.Direct2D1.Factory1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Engine.Graphics {
    class GraphicsManager {
        public static ID2D1Factory factory;

        public static void Initialize() {
            factory = new ID2D1Factory(FactoryType.SingleThreaded, DebugLevel.None);
        }

        public static void test() {

        }
    }
}
