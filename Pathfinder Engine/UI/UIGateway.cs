using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder_Engine.UI {
    /// <summary>
    /// Acts as a gateway between the engine and UI.
    /// </summary>
    class UIGateway {
        public static Dashboard DashboardInstance = null;
        public static ArrayList windowInstances = null;

        public static void InitializeUI() {
            windowInstances = new ArrayList();
            DashboardInstance = new Dashboard();
            DashboardInstance.ShowDialog();
        }

        public static DiceTool SpawnDiceTool() {
            DiceTool dTool = new DiceTool();
            windowInstances.Add(dTool);
            dTool.Show();
            return dTool;
        }

        public static void DisposeWindowInstance(Object instance) {
            Form fInstance = (Form)instance;
            windowInstances.Remove(instance);
            fInstance.Dispose();
        }
    }
}
