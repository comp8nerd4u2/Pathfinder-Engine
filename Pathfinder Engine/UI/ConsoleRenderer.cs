using Pathfinder_Engine.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder_Engine.UI {
    /// <summary>
    /// Handles rendering console to display panel
    /// </summary>
    class ConsoleRenderer : IDrawable {
        Control controlRenderTarget;

        public ConsoleRenderer(Control controlRenderTarget) {
            this.controlRenderTarget = controlRenderTarget;
            controlRenderTarget.Paint += this.OnPaint;
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            Draw();
        }

        public void Draw() {
            throw new NotImplementedException();
        }
    }
}
