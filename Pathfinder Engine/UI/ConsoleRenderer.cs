using Pathfinder_Engine.Graphics;
using SharpDX.Mathematics.Interop;
using SharpDX.Direct2D1;
using SharpDX.DXGI;
using SharpDX;
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
        Control control;
        WindowRenderTarget target;

        public ConsoleRenderer(Control controlRenderTarget) {
            this.control = controlRenderTarget;
            controlRenderTarget.Paint += this.OnPaint;
            RenderTargetProperties rtp = new RenderTargetProperties() {
                DpiX = GraphicsManager.factory.DesktopDpi.Width,
                DpiY = GraphicsManager.factory.DesktopDpi.Height,
                MinLevel = FeatureLevel.Level_DEFAULT,
                PixelFormat = new PixelFormat(Format.B8G8R8A8_UNorm, SharpDX.Direct2D1.AlphaMode.Unknown),
                Type = RenderTargetType.Hardware,
                Usage = RenderTargetUsage.None
            };
            HwndRenderTargetProperties hrtp = new HwndRenderTargetProperties() {
                Hwnd = controlRenderTarget.Handle,
                PixelSize = new Size2(controlRenderTarget.Width, controlRenderTarget.Height),
                PresentOptions = PresentOptions.Immediately
            };
            target = new WindowRenderTarget(GraphicsManager.factory, rtp, hrtp);
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            Draw();
        }

        public void Draw() {
            Console.WriteLine("Drawing");
            target.BeginDraw();
            target.Clear(Color.Black.ToColor4());
            Ellipse e = new Ellipse(new Vector2(50, 50), 50, 50);
            target.FillEllipse(e, new SolidColorBrush(target, Color.CornflowerBlue.ToColor4()));
            //target.Dra
            target.EndDraw();
        }
    }
}
