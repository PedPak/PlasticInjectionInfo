namespace TazrighInfo
{
    partial class frmProductionEdit
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
            this.chkAllowEdit = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.txtCastFormat = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWorkingTime = new FloatingPointTextBox.floatTextBox();
            this.txtFullAutomaticTime = new FloatingPointTextBox.floatTextBox();
            this.txtTotalTimeforCoining = new FloatingPointTextBox.floatTextBox();
            this.txtSecondInjectionPressureTime = new FloatingPointTextBox.floatTextBox();
            this.txtBackCarriageTime = new FloatingPointTextBox.floatTextBox();
            this.txtHeadCarriageTime = new FloatingPointTextBox.floatTextBox();
            this.txtIntakeTime = new FloatingPointTextBox.floatTextBox();
            this.txtWaitTimeBetweenEjectors = new FloatingPointTextBox.floatTextBox();
            this.txtEjectorNumber = new IntegerTextBox.IntTextBox();
            this.txtWaitTimeBeforeEjector = new FloatingPointTextBox.floatTextBox();
            this.txtEjectorTime = new FloatingPointTextBox.floatTextBox();
            this.txtHookWaitTime = new FloatingPointTextBox.floatTextBox();
            this.txtWaitTimeAfterInjection = new FloatingPointTextBox.floatTextBox();
            this.txtInjectionTime = new FloatingPointTextBox.floatTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCoiningWeight = new FloatingPointTextBox.floatTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPressure = new FloatingPointTextBox.floatTextBox();
            this.txtBackTemperature = new IntegerTextBox.IntTextBox();
            this.txtMidTemperature = new IntegerTextBox.IntTextBox();
            this.txtHeadTemperature = new IntegerTextBox.IntTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAllowEdit
            // 
            this.chkAllowEdit.AutoSize = true;
            this.chkAllowEdit.Location = new System.Drawing.Point(599, 394);
            this.chkAllowEdit.Name = "chkAllowEdit";
            this.chkAllowEdit.Size = new System.Drawing.Size(110, 17);
            this.chkAllowEdit.TabIndex = 35;
            this.chkAllowEdit.Text = "اجازه انجام ويرايش";
            this.chkAllowEdit.UseVisualStyleBackColor = true;
            this.chkAllowEdit.CheckedChanged += new System.EventHandler(this.chkAllowEdit_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(520, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 25);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(383, 455);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 25);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "اعمال ويرايش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "وزن ضرب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "مواد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام دستگاه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام قالب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام قطعه";
            // 
            // txtMachine
            // 
            this.txtMachine.Location = new System.Drawing.Point(21, 88);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.ReadOnly = true;
            this.txtMachine.Size = new System.Drawing.Size(232, 21);
            this.txtMachine.TabIndex = 3;
            // 
            // txtCastFormat
            // 
            this.txtCastFormat.Location = new System.Drawing.Point(21, 60);
            this.txtCastFormat.Name = "txtCastFormat";
            this.txtCastFormat.ReadOnly = true;
            this.txtCastFormat.Size = new System.Drawing.Size(232, 21);
            this.txtCastFormat.TabIndex = 3;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(21, 29);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.ReadOnly = true;
            this.txtProduct.Size = new System.Drawing.Size(232, 21);
            this.txtProduct.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtProduct);
            this.groupBox1.Controls.Add(this.txtCoiningWeight);
            this.groupBox1.Controls.Add(this.txtCastFormat);
            this.groupBox1.Controls.Add(this.txtMachine);
            this.groupBox1.Controls.Add(this.txtMaterial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(364, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 182);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات توليد";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(20, 122);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.ReadOnly = true;
            this.txtMaterial.Size = new System.Drawing.Size(232, 21);
            this.txtMaterial.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWorkingTime);
            this.groupBox2.Controls.Add(this.txtFullAutomaticTime);
            this.groupBox2.Controls.Add(this.txtTotalTimeforCoining);
            this.groupBox2.Controls.Add(this.txtSecondInjectionPressureTime);
            this.groupBox2.Controls.Add(this.txtBackCarriageTime);
            this.groupBox2.Controls.Add(this.txtHeadCarriageTime);
            this.groupBox2.Controls.Add(this.txtIntakeTime);
            this.groupBox2.Controls.Add(this.txtWaitTimeBetweenEjectors);
            this.groupBox2.Controls.Add(this.txtEjectorNumber);
            this.groupBox2.Controls.Add(this.txtWaitTimeBeforeEjector);
            this.groupBox2.Controls.Add(this.txtEjectorTime);
            this.groupBox2.Controls.Add(this.txtHookWaitTime);
            this.groupBox2.Controls.Add(this.txtWaitTimeAfterInjection);
            this.groupBox2.Controls.Add(this.txtInjectionTime);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(12, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 460);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات زماني (ثانيه)";
            // 
            // txtWorkingTime
            // 
            this.txtWorkingTime.Location = new System.Drawing.Point(78, 429);
            this.txtWorkingTime.Name = "txtWorkingTime";
            this.txtWorkingTime.ReadOnly = true;
            this.txtWorkingTime.Size = new System.Drawing.Size(96, 25);
            this.txtWorkingTime.TabIndex = 25;
            // 
            // txtFullAutomaticTime
            // 
            this.txtFullAutomaticTime.Location = new System.Drawing.Point(79, 402);
            this.txtFullAutomaticTime.Name = "txtFullAutomaticTime";
            this.txtFullAutomaticTime.ReadOnly = true;
            this.txtFullAutomaticTime.Size = new System.Drawing.Size(96, 25);
            this.txtFullAutomaticTime.TabIndex = 25;
            // 
            // txtTotalTimeforCoining
            // 
            this.txtTotalTimeforCoining.Location = new System.Drawing.Point(78, 375);
            this.txtTotalTimeforCoining.Name = "txtTotalTimeforCoining";
            this.txtTotalTimeforCoining.ReadOnly = true;
            this.txtTotalTimeforCoining.Size = new System.Drawing.Size(96, 25);
            this.txtTotalTimeforCoining.TabIndex = 25;
            // 
            // txtSecondInjectionPressureTime
            // 
            this.txtSecondInjectionPressureTime.Location = new System.Drawing.Point(78, 339);
            this.txtSecondInjectionPressureTime.Name = "txtSecondInjectionPressureTime";
            this.txtSecondInjectionPressureTime.ReadOnly = true;
            this.txtSecondInjectionPressureTime.Size = new System.Drawing.Size(96, 25);
            this.txtSecondInjectionPressureTime.TabIndex = 25;
            // 
            // txtBackCarriageTime
            // 
            this.txtBackCarriageTime.Location = new System.Drawing.Point(79, 308);
            this.txtBackCarriageTime.Name = "txtBackCarriageTime";
            this.txtBackCarriageTime.ReadOnly = true;
            this.txtBackCarriageTime.Size = new System.Drawing.Size(96, 25);
            this.txtBackCarriageTime.TabIndex = 25;
            // 
            // txtHeadCarriageTime
            // 
            this.txtHeadCarriageTime.Location = new System.Drawing.Point(78, 273);
            this.txtHeadCarriageTime.Name = "txtHeadCarriageTime";
            this.txtHeadCarriageTime.ReadOnly = true;
            this.txtHeadCarriageTime.Size = new System.Drawing.Size(96, 25);
            this.txtHeadCarriageTime.TabIndex = 25;
            // 
            // txtIntakeTime
            // 
            this.txtIntakeTime.Location = new System.Drawing.Point(78, 238);
            this.txtIntakeTime.Name = "txtIntakeTime";
            this.txtIntakeTime.ReadOnly = true;
            this.txtIntakeTime.Size = new System.Drawing.Size(96, 25);
            this.txtIntakeTime.TabIndex = 25;
            // 
            // txtWaitTimeBetweenEjectors
            // 
            this.txtWaitTimeBetweenEjectors.Location = new System.Drawing.Point(78, 202);
            this.txtWaitTimeBetweenEjectors.Name = "txtWaitTimeBetweenEjectors";
            this.txtWaitTimeBetweenEjectors.ReadOnly = true;
            this.txtWaitTimeBetweenEjectors.Size = new System.Drawing.Size(96, 25);
            this.txtWaitTimeBetweenEjectors.TabIndex = 25;
            // 
            // txtEjectorNumber
            // 
            this.txtEjectorNumber.Location = new System.Drawing.Point(109, 175);
            this.txtEjectorNumber.Name = "txtEjectorNumber";
            this.txtEjectorNumber.ReadOnly = true;
            this.txtEjectorNumber.Size = new System.Drawing.Size(65, 21);
            this.txtEjectorNumber.TabIndex = 21;
            // 
            // txtWaitTimeBeforeEjector
            // 
            this.txtWaitTimeBeforeEjector.Location = new System.Drawing.Point(78, 144);
            this.txtWaitTimeBeforeEjector.Name = "txtWaitTimeBeforeEjector";
            this.txtWaitTimeBeforeEjector.ReadOnly = true;
            this.txtWaitTimeBeforeEjector.Size = new System.Drawing.Size(96, 25);
            this.txtWaitTimeBeforeEjector.TabIndex = 25;
            // 
            // txtEjectorTime
            // 
            this.txtEjectorTime.Location = new System.Drawing.Point(78, 115);
            this.txtEjectorTime.Name = "txtEjectorTime";
            this.txtEjectorTime.ReadOnly = true;
            this.txtEjectorTime.Size = new System.Drawing.Size(96, 25);
            this.txtEjectorTime.TabIndex = 25;
            // 
            // txtHookWaitTime
            // 
            this.txtHookWaitTime.Location = new System.Drawing.Point(78, 84);
            this.txtHookWaitTime.Name = "txtHookWaitTime";
            this.txtHookWaitTime.ReadOnly = true;
            this.txtHookWaitTime.Size = new System.Drawing.Size(96, 25);
            this.txtHookWaitTime.TabIndex = 25;
            // 
            // txtWaitTimeAfterInjection
            // 
            this.txtWaitTimeAfterInjection.Location = new System.Drawing.Point(78, 53);
            this.txtWaitTimeAfterInjection.Name = "txtWaitTimeAfterInjection";
            this.txtWaitTimeAfterInjection.ReadOnly = true;
            this.txtWaitTimeAfterInjection.Size = new System.Drawing.Size(96, 25);
            this.txtWaitTimeAfterInjection.TabIndex = 25;
            // 
            // txtInjectionTime
            // 
            this.txtInjectionTime.Location = new System.Drawing.Point(78, 25);
            this.txtInjectionTime.Name = "txtInjectionTime";
            this.txtInjectionTime.ReadOnly = true;
            this.txtInjectionTime.Size = new System.Drawing.Size(96, 25);
            this.txtInjectionTime.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "زمان مكث بعد از تزريق";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "زمان تزريق";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "زمان مكث گيره";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(236, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "تعداد دفعات پران";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(210, 375);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "كل زمان توليد يك ضرب";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "زمان پران";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(228, 433);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "ساعت كار دستگاه";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(208, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "مدت زمان فول اتوماتيك";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(192, 344);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "مدت زمان فشار دوم تزريق";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "زمان مكش";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(210, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "مدت زمان كالسكه جلو";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(183, 207);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "مدت زمان مكث بين چند پران";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(203, 311);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "مدت زمان كالسكه عقب";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(238, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "مكث قبل از پران";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(123, 156);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "گرم";
            // 
            // txtCoiningWeight
            // 
            this.txtCoiningWeight.Location = new System.Drawing.Point(156, 151);
            this.txtCoiningWeight.Name = "txtCoiningWeight";
            this.txtCoiningWeight.ReadOnly = true;
            this.txtCoiningWeight.Size = new System.Drawing.Size(96, 25);
            this.txtCoiningWeight.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPressure);
            this.groupBox3.Controls.Add(this.txtBackTemperature);
            this.groupBox3.Controls.Add(this.txtMidTemperature);
            this.groupBox3.Controls.Add(this.txtHeadTemperature);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(365, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 157);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مشخصات حرارتي و فشار (سانتي گراد)";
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(117, 121);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.ReadOnly = true;
            this.txtPressure.Size = new System.Drawing.Size(96, 25);
            this.txtPressure.TabIndex = 25;
            // 
            // txtBackTemperature
            // 
            this.txtBackTemperature.Location = new System.Drawing.Point(148, 94);
            this.txtBackTemperature.Name = "txtBackTemperature";
            this.txtBackTemperature.ReadOnly = true;
            this.txtBackTemperature.Size = new System.Drawing.Size(65, 21);
            this.txtBackTemperature.TabIndex = 21;
            // 
            // txtMidTemperature
            // 
            this.txtMidTemperature.Location = new System.Drawing.Point(148, 67);
            this.txtMidTemperature.Name = "txtMidTemperature";
            this.txtMidTemperature.ReadOnly = true;
            this.txtMidTemperature.Size = new System.Drawing.Size(65, 21);
            this.txtMidTemperature.TabIndex = 21;
            // 
            // txtHeadTemperature
            // 
            this.txtHeadTemperature.Location = new System.Drawing.Point(148, 34);
            this.txtHeadTemperature.Name = "txtHeadTemperature";
            this.txtHeadTemperature.ReadOnly = true;
            this.txtHeadTemperature.Size = new System.Drawing.Size(65, 21);
            this.txtHeadTemperature.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "درجه حرارت جلو";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "درجه حرارت وسط";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "درجه حرارت عقب";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(287, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "فشار";
            // 
            // frmProductionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 501);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkAllowEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductionEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ويرايش توليد";
            this.Load += new System.EventHandler(this.frmProductionEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAllowEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.TextBox txtCastFormat;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.GroupBox groupBox2;
        private FloatingPointTextBox.floatTextBox txtWorkingTime;
        private FloatingPointTextBox.floatTextBox txtFullAutomaticTime;
        private FloatingPointTextBox.floatTextBox txtTotalTimeforCoining;
        private FloatingPointTextBox.floatTextBox txtSecondInjectionPressureTime;
        private FloatingPointTextBox.floatTextBox txtBackCarriageTime;
        private FloatingPointTextBox.floatTextBox txtHeadCarriageTime;
        private FloatingPointTextBox.floatTextBox txtIntakeTime;
        private FloatingPointTextBox.floatTextBox txtWaitTimeBetweenEjectors;
        private IntegerTextBox.IntTextBox txtEjectorNumber;
        private FloatingPointTextBox.floatTextBox txtWaitTimeBeforeEjector;
        private FloatingPointTextBox.floatTextBox txtEjectorTime;
        private FloatingPointTextBox.floatTextBox txtHookWaitTime;
        private FloatingPointTextBox.floatTextBox txtWaitTimeAfterInjection;
        private FloatingPointTextBox.floatTextBox txtInjectionTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label24;
        private FloatingPointTextBox.floatTextBox txtCoiningWeight;
        private System.Windows.Forms.GroupBox groupBox3;
        private FloatingPointTextBox.floatTextBox txtPressure;
        private IntegerTextBox.IntTextBox txtBackTemperature;
        private IntegerTextBox.IntTextBox txtMidTemperature;
        private IntegerTextBox.IntTextBox txtHeadTemperature;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;

    }
}