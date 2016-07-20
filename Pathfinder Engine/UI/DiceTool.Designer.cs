namespace Pathfinder_Engine.UI {
    partial class DiceTool {
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
            this.label1 = new System.Windows.Forms.Label();
            this.sidesOption = new System.Windows.Forms.NumericUpDown();
            this.rollButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultDisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundOption = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sidesOption)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sides:";
            // 
            // sidesOption
            // 
            this.sidesOption.Location = new System.Drawing.Point(54, 7);
            this.sidesOption.Name = "sidesOption";
            this.sidesOption.Size = new System.Drawing.Size(63, 20);
            this.sidesOption.TabIndex = 1;
            this.sidesOption.ValueChanged += new System.EventHandler(this.sidesOption_ValueChanged);
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(9, 56);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(108, 23);
            this.rollButton.TabIndex = 2;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.resultDisplay);
            this.groupBox1.Location = new System.Drawing.Point(123, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // resultDisplay
            // 
            this.resultDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultDisplay.Location = new System.Drawing.Point(3, 16);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(65, 50);
            this.resultDisplay.TabIndex = 0;
            this.resultDisplay.Text = "0";
            this.resultDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultDisplay.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Round:";
            // 
            // roundOption
            // 
            this.roundOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roundOption.FormattingEnabled = true;
            this.roundOption.Items.AddRange(new object[] {
            "UP",
            "NONE",
            "DOWN"});
            this.roundOption.Location = new System.Drawing.Point(54, 29);
            this.roundOption.Name = "roundOption";
            this.roundOption.Size = new System.Drawing.Size(63, 21);
            this.roundOption.TabIndex = 5;
            this.roundOption.SelectedIndexChanged += new System.EventHandler(this.roundOption_SelectedIndexChanged);
            // 
            // DiceTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 84);
            this.Controls.Add(this.roundOption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.sidesOption);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiceTool";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Dice";
            this.Load += new System.EventHandler(this.DiceTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sidesOption)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sidesOption;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label resultDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roundOption;
    }
}