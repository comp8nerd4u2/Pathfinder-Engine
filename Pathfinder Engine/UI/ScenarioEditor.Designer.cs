namespace Pathfinder_Engine.UI {
    partial class ScenarioEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.scenarioCanvas = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // scenarioCanvas
            // 
            this.scenarioCanvas.BackColor = System.Drawing.Color.Black;
            this.scenarioCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scenarioCanvas.Location = new System.Drawing.Point(146, 47);
            this.scenarioCanvas.Name = "scenarioCanvas";
            this.scenarioCanvas.Size = new System.Drawing.Size(488, 469);
            this.scenarioCanvas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 537);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ScenarioEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scenarioCanvas);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ScenarioEditor";
            this.Text = "Scenario Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scenarioCanvas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}