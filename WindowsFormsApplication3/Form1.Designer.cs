namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Epics.AlarmColors alarmColors9 = new Epics.AlarmColors();
            Epics.AlarmColors alarmColors10 = new Epics.AlarmColors();
            Epics.AlarmColors alarmColors11 = new Epics.AlarmColors();
            Epics.AlarmColors alarmColors12 = new Epics.AlarmColors();
            Epics.AlarmColors alarmColors13 = new Epics.AlarmColors();
            Epics.AlarmColors alarmColors14 = new Epics.AlarmColors();
            Epics.AlarmColors alarmColors15 = new Epics.AlarmColors();
            Epics.AlarmColors alarmColors16 = new Epics.AlarmColors();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shape1 = new Epics.Controls.Shape(this.components);
            this.shape3 = new Epics.Controls.Shape(this.components);
            this.shape4 = new Epics.Controls.Shape(this.components);
            this.shape5 = new Epics.Controls.Shape(this.components);
            this.shape2 = new Epics.Controls.Shape(this.components);
            this.shape6 = new Epics.Controls.Shape(this.components);
            this.shape7 = new Epics.Controls.Shape(this.components);
            this.shape8 = new Epics.Controls.Shape(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.epicsLabel1 = new Epics.Controls.EpicsLabel(this.components);
            this.epicsLabel4 = new Epics.Controls.EpicsLabel(this.components);
            this.epicsLabel5 = new Epics.Controls.EpicsLabel(this.components);
            this.epicsLabel2 = new Epics.Controls.EpicsLabel(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epicsLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epicsLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epicsLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epicsLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DG535 SRS Delay/Pulse Unit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.epicsLabel2);
            this.groupBox1.Controls.Add(this.epicsLabel5);
            this.groupBox1.Controls.Add(this.epicsLabel4);
            this.groupBox1.Controls.Add(this.epicsLabel1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.shape2);
            this.groupBox1.Controls.Add(this.shape6);
            this.groupBox1.Controls.Add(this.shape7);
            this.groupBox1.Controls.Add(this.shape8);
            this.groupBox1.Controls.Add(this.shape5);
            this.groupBox1.Controls.Add(this.shape4);
            this.groupBox1.Controls.Add(this.shape3);
            this.groupBox1.Controls.Add(this.shape1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Units overview";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unit name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Open control panel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alarm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Connected";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // shape1
            // 
            this.shape1.Location = new System.Drawing.Point(179, 91);
            this.shape1.Name = "shape1";
            this.shape1.ShapeType = Epics.Controls.Shape.Shapes.Ellipse;
            this.shape1.Size = new System.Drawing.Size(14, 14);
            this.shape1.TabIndex = 6;
            // 
            // shape3
            // 
            this.shape3.Location = new System.Drawing.Point(179, 63);
            this.shape3.Name = "shape3";
            this.shape3.ShapeType = Epics.Controls.Shape.Shapes.Ellipse;
            this.shape3.Size = new System.Drawing.Size(14, 14);
            this.shape3.TabIndex = 7;
            // 
            // shape4
            // 
            this.shape4.Location = new System.Drawing.Point(179, 120);
            this.shape4.Name = "shape4";
            this.shape4.ShapeType = Epics.Controls.Shape.Shapes.Ellipse;
            this.shape4.Size = new System.Drawing.Size(14, 14);
            this.shape4.TabIndex = 8;
            // 
            // shape5
            // 
            this.shape5.Location = new System.Drawing.Point(179, 149);
            this.shape5.Name = "shape5";
            this.shape5.ShapeType = Epics.Controls.Shape.Shapes.Ellipse;
            this.shape5.Size = new System.Drawing.Size(14, 14);
            this.shape5.TabIndex = 9;
            // 
            // shape2
            // 
            this.shape2.Location = new System.Drawing.Point(247, 149);
            this.shape2.Name = "shape2";
            this.shape2.ShapeType = Epics.Controls.Shape.Shapes.Ellipse;
            this.shape2.Size = new System.Drawing.Size(14, 14);
            this.shape2.TabIndex = 13;
            // 
            // shape6
            // 
            this.shape6.Location = new System.Drawing.Point(247, 120);
            this.shape6.Name = "shape6";
            this.shape6.ShapeType = Epics.Controls.Shape.Shapes.Ellipse;
            this.shape6.Size = new System.Drawing.Size(14, 14);
            this.shape6.TabIndex = 12;
            // 
            // shape7
            // 
            this.shape7.Location = new System.Drawing.Point(247, 63);
            this.shape7.Name = "shape7";
            this.shape7.ShapeType = Epics.Controls.Shape.Shapes.Ellipse;
            this.shape7.Size = new System.Drawing.Size(14, 14);
            this.shape7.TabIndex = 11;
            // 
            // shape8
            // 
            this.shape8.Location = new System.Drawing.Point(247, 91);
            this.shape8.Name = "shape8";
            this.shape8.ShapeType = Epics.Controls.Shape.Shapes.Ellipse;
            this.shape8.Size = new System.Drawing.Size(14, 14);
            this.shape8.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Settings";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Settings";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // epicsLabel1
            // 
            this.epicsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epicsLabel1.ColorPV.AlarmColors = alarmColors9;
            this.epicsLabel1.ColorPV.InvalidColor = System.Drawing.Color.White;
            this.epicsLabel1.ColorPV.PV = "";
            this.epicsLabel1.CustomFormat = "";
            this.epicsLabel1.Index = ((uint)(0u));
            this.epicsLabel1.Location = new System.Drawing.Point(28, 58);
            this.epicsLabel1.Name = "epicsLabel1";
            this.epicsLabel1.PV = "";
            this.epicsLabel1.Size = new System.Drawing.Size(100, 23);
            this.epicsLabel1.TabIndex = 18;
            this.epicsLabel1.VisibilityPV.AlarmColors = alarmColors10;
            this.epicsLabel1.VisibilityPV.PV = "";
            // 
            // epicsLabel4
            // 
            this.epicsLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epicsLabel4.ColorPV.AlarmColors = alarmColors11;
            this.epicsLabel4.ColorPV.InvalidColor = System.Drawing.Color.White;
            this.epicsLabel4.ColorPV.PV = "";
            this.epicsLabel4.CustomFormat = "";
            this.epicsLabel4.Index = ((uint)(0u));
            this.epicsLabel4.Location = new System.Drawing.Point(28, 86);
            this.epicsLabel4.Name = "epicsLabel4";
            this.epicsLabel4.PV = "";
            this.epicsLabel4.Size = new System.Drawing.Size(100, 23);
            this.epicsLabel4.TabIndex = 21;
            this.epicsLabel4.VisibilityPV.AlarmColors = alarmColors12;
            this.epicsLabel4.VisibilityPV.PV = "";
            // 
            // epicsLabel5
            // 
            this.epicsLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epicsLabel5.ColorPV.AlarmColors = alarmColors13;
            this.epicsLabel5.ColorPV.InvalidColor = System.Drawing.Color.White;
            this.epicsLabel5.ColorPV.PV = "";
            this.epicsLabel5.CustomFormat = "";
            this.epicsLabel5.Index = ((uint)(0u));
            this.epicsLabel5.Location = new System.Drawing.Point(28, 115);
            this.epicsLabel5.Name = "epicsLabel5";
            this.epicsLabel5.PV = "";
            this.epicsLabel5.Size = new System.Drawing.Size(100, 23);
            this.epicsLabel5.TabIndex = 22;
            this.epicsLabel5.VisibilityPV.AlarmColors = alarmColors14;
            this.epicsLabel5.VisibilityPV.PV = "";
            // 
            // epicsLabel2
            // 
            this.epicsLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epicsLabel2.ColorPV.AlarmColors = alarmColors15;
            this.epicsLabel2.ColorPV.InvalidColor = System.Drawing.Color.White;
            this.epicsLabel2.ColorPV.PV = "";
            this.epicsLabel2.CustomFormat = "";
            this.epicsLabel2.Index = ((uint)(0u));
            this.epicsLabel2.Location = new System.Drawing.Point(28, 144);
            this.epicsLabel2.Name = "epicsLabel2";
            this.epicsLabel2.PV = "";
            this.epicsLabel2.Size = new System.Drawing.Size(100, 23);
            this.epicsLabel2.TabIndex = 23;
            this.epicsLabel2.VisibilityPV.AlarmColors = alarmColors16;
            this.epicsLabel2.VisibilityPV.PV = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DG535 controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epicsLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epicsLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epicsLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epicsLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Epics.Controls.Shape shape5;
        private Epics.Controls.Shape shape4;
        private Epics.Controls.Shape shape3;
        private Epics.Controls.Shape shape1;
        private Epics.Controls.Shape shape2;
        private Epics.Controls.Shape shape6;
        private Epics.Controls.Shape shape7;
        private Epics.Controls.Shape shape8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Epics.Controls.EpicsLabel epicsLabel2;
        private Epics.Controls.EpicsLabel epicsLabel5;
        private Epics.Controls.EpicsLabel epicsLabel4;
        private Epics.Controls.EpicsLabel epicsLabel1;


    }
}

