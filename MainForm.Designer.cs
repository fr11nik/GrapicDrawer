namespace GraphicDraw
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dragControl1 = new formsDragControl.DragControl();
            this.labelFunction = new System.Windows.Forms.Label();
            this.textBoxFuncion = new System.Windows.Forms.TextBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            this.numeric2 = new System.Windows.Forms.NumericUpDown();
            this.buttonStartBuild = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 31);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(515, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 31);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel1;
            // 
            // labelFunction
            // 
            this.labelFunction.AutoSize = true;
            this.labelFunction.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunction.Location = new System.Drawing.Point(26, 98);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(64, 29);
            this.labelFunction.TabIndex = 1;
            this.labelFunction.Text = "y(x)=";
            // 
            // textBoxFuncion
            // 
            this.textBoxFuncion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFuncion.Font = new System.Drawing.Font("Bahnschrift Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFuncion.Location = new System.Drawing.Point(96, 85);
            this.textBoxFuncion.Multiline = true;
            this.textBoxFuncion.Name = "textBoxFuncion";
            this.textBoxFuncion.Size = new System.Drawing.Size(411, 53);
            this.textBoxFuncion.TabIndex = 2;
            this.textBoxFuncion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxFuncion_MouseClick);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInterval.Location = new System.Drawing.Point(246, 154);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(96, 29);
            this.labelInterval.TabIndex = 1;
            this.labelInterval.Text = "Interval";
            // 
            // numeric1
            // 
            this.numeric1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numeric1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric1.Location = new System.Drawing.Point(214, 196);
            this.numeric1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(51, 21);
            this.numeric1.TabIndex = 3;
            this.numeric1.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numeric2
            // 
            this.numeric2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.numeric2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numeric2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric2.Location = new System.Drawing.Point(319, 196);
            this.numeric2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(51, 21);
            this.numeric2.TabIndex = 3;
            this.numeric2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonStartBuild
            // 
            this.buttonStartBuild.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStartBuild.FlatAppearance.BorderSize = 0;
            this.buttonStartBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartBuild.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartBuild.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStartBuild.Location = new System.Drawing.Point(434, 249);
            this.buttonStartBuild.Name = "buttonStartBuild";
            this.buttonStartBuild.Size = new System.Drawing.Size(128, 48);
            this.buttonStartBuild.TabIndex = 4;
            this.buttonStartBuild.Text = "BuildGraph";
            this.buttonStartBuild.UseVisualStyleBackColor = false;
            this.buttonStartBuild.Click += new System.EventHandler(this.ButtonStartBuild_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 319);
            this.Controls.Add(this.buttonStartBuild);
            this.Controls.Add(this.numeric2);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.textBoxFuncion);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.labelFunction);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private formsDragControl.DragControl dragControl1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.TextBox textBoxFuncion;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numeric1;
        private System.Windows.Forms.NumericUpDown numeric2;
        private System.Windows.Forms.Button buttonStartBuild;
    }
}