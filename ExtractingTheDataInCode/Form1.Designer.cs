namespace RaceDataYouTube
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnConnect = new Button();
            btnDisconnect = new Button();
            label1 = new Label();
            lblLapTime = new Label();
            label3 = new Label();
            lblLapRX = new Label();
            lblCarPos = new Label();
            label4 = new Label();
            lblTotalLaps = new Label();
            label5 = new Label();
            lblSector = new Label();
            label8 = new Label();
            lblTotalTime = new Label();
            label9 = new Label();
            lblPercent = new Label();
            label10 = new Label();
            lblDistance = new Label();
            label13 = new Label();
            lblSuspensionBL = new Label();
            label12 = new Label();
            lblSuspensionFL = new Label();
            lbl1 = new Label();
            lblSuspensionBR = new Label();
            label18 = new Label();
            lblSuspensionFR = new Label();
            label20 = new Label();
            lblSuspVelFR = new Label();
            label15 = new Label();
            lblSuspVelBR = new Label();
            label17 = new Label();
            lblSuspVelFL = new Label();
            label21 = new Label();
            lblSuspVelBL = new Label();
            label23 = new Label();
            lblWheelSpFR = new Label();
            label25 = new Label();
            lblWheelSpBR = new Label();
            lbl2 = new Label();
            lblWheelSpFL = new Label();
            label29 = new Label();
            lblWheelSpBL = new Label();
            label31 = new Label();
            lblGForceLon = new Label();
            label16 = new Label();
            lblGForceLat = new Label();
            label22 = new Label();
            lblRPMs = new Label();
            label19 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblX = new Label();
            label24 = new Label();
            lblY = new Label();
            label27 = new Label();
            lblZ = new Label();
            label30 = new Label();
            lblSpeed = new Label();
            label26 = new Label();
            lblZv = new Label();
            label32 = new Label();
            lblYv = new Label();
            label34 = new Label();
            lblXv = new Label();
            label36 = new Label();
            lblZr = new Label();
            label38 = new Label();
            lblYr = new Label();
            label40 = new Label();
            lblXr = new Label();
            label42 = new Label();
            lblZd = new Label();
            label44 = new Label();
            lblYd = new Label();
            label46 = new Label();
            lblXd = new Label();
            label48 = new Label();
            lblThrottle = new Label();
            label50 = new Label();
            lblGear = new Label();
            label52 = new Label();
            lblSteer = new Label();
            label54 = new Label();
            lblBrake = new Label();
            label56 = new Label();
            lblClutch = new Label();
            label58 = new Label();
            lblBrakeTempFR = new Label();
            label60 = new Label();
            lblBrakeTempBR = new Label();
            label62 = new Label();
            lblBrakeTempFL = new Label();
            label64 = new Label();
            lblBrakeTempBL = new Label();
            label66 = new Label();
            lblTrackID = new Label();
            label7 = new Label();
            lblVechileID = new Label();
            label14 = new Label();
            lblCarID = new Label();
            label68 = new Label();
            lblMaxGear = new Label();
            label70 = new Label();
            lblLastLapStageTime = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(21, 19);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(108, 49);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Enabled = false;
            btnDisconnect.Location = new Point(21, 74);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(108, 49);
            btnDisconnect.TabIndex = 1;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 49);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "LapTime";
            // 
            // lblLapTime
            // 
            lblLapTime.AutoSize = true;
            lblLapTime.Location = new Point(231, 49);
            lblLapTime.Name = "lblLapTime";
            lblLapTime.Size = new Size(13, 15);
            lblLapTime.TabIndex = 3;
            lblLapTime.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 49);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "LapRX";
            // 
            // lblLapRX
            // 
            lblLapRX.AutoSize = true;
            lblLapRX.Location = new Point(453, 49);
            lblLapRX.Name = "lblLapRX";
            lblLapRX.Size = new Size(13, 15);
            lblLapRX.TabIndex = 5;
            lblLapRX.Text = "0";
            // 
            // lblCarPos
            // 
            lblCarPos.AutoSize = true;
            lblCarPos.Location = new Point(221, 262);
            lblCarPos.Name = "lblCarPos";
            lblCarPos.Size = new Size(13, 15);
            lblCarPos.TabIndex = 7;
            lblCarPos.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 262);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "CarPos";
            // 
            // lblTotalLaps
            // 
            lblTotalLaps.AutoSize = true;
            lblTotalLaps.Location = new Point(453, 79);
            lblTotalLaps.Name = "lblTotalLaps";
            lblTotalLaps.Size = new Size(13, 15);
            lblTotalLaps.TabIndex = 11;
            lblTotalLaps.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 79);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "Total Laps";
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.Location = new Point(453, 108);
            lblSector.Name = "lblSector";
            lblSector.Size = new Size(13, 15);
            lblSector.TabIndex = 15;
            lblSector.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(349, 108);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 14;
            label8.Text = "Sector";
            // 
            // lblTotalTime
            // 
            lblTotalTime.AutoSize = true;
            lblTotalTime.Location = new Point(231, 19);
            lblTotalTime.Name = "lblTotalTime";
            lblTotalTime.Size = new Size(13, 15);
            lblTotalTime.TabIndex = 17;
            lblTotalTime.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(153, 19);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 16;
            label9.Text = "Total Time";
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(272, 109);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(13, 15);
            lblPercent.TabIndex = 23;
            lblPercent.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(153, 109);
            label10.Name = "label10";
            label10.Size = new Size(102, 15);
            label10.TabIndex = 22;
            label10.Text = "Percent Complete";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(231, 79);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(13, 15);
            lblDistance.TabIndex = 21;
            lblDistance.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(154, 79);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 20;
            label13.Text = "Distance";
            // 
            // lblSuspensionBL
            // 
            lblSuspensionBL.AutoSize = true;
            lblSuspensionBL.Location = new Point(505, 202);
            lblSuspensionBL.Name = "lblSuspensionBL";
            lblSuspensionBL.Size = new Size(13, 15);
            lblSuspensionBL.TabIndex = 29;
            lblSuspensionBL.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(494, 185);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 28;
            label12.Text = "SuspensionBL";
            // 
            // lblSuspensionFL
            // 
            lblSuspensionFL.AutoSize = true;
            lblSuspensionFL.Location = new Point(505, 170);
            lblSuspensionFL.Name = "lblSuspensionFL";
            lblSuspensionFL.Size = new Size(13, 15);
            lblSuspensionFL.TabIndex = 31;
            lblSuspensionFL.Text = "0";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(494, 153);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(79, 15);
            lbl1.TabIndex = 30;
            lbl1.Text = "SuspensionFL";
            // 
            // lblSuspensionBR
            // 
            lblSuspensionBR.AutoSize = true;
            lblSuspensionBR.Location = new Point(586, 202);
            lblSuspensionBR.Name = "lblSuspensionBR";
            lblSuspensionBR.Size = new Size(13, 15);
            lblSuspensionBR.TabIndex = 33;
            lblSuspensionBR.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(579, 185);
            label18.Name = "label18";
            label18.Size = new Size(81, 15);
            label18.TabIndex = 32;
            label18.Text = "SuspensionBR";
            // 
            // lblSuspensionFR
            // 
            lblSuspensionFR.AutoSize = true;
            lblSuspensionFR.Location = new Point(584, 170);
            lblSuspensionFR.Name = "lblSuspensionFR";
            lblSuspensionFR.Size = new Size(13, 15);
            lblSuspensionFR.TabIndex = 35;
            lblSuspensionFR.Text = "0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(579, 153);
            label20.Name = "label20";
            label20.Size = new Size(80, 15);
            label20.TabIndex = 34;
            label20.Text = "SuspensionFR";
            // 
            // lblSuspVelFR
            // 
            lblSuspVelFR.AutoSize = true;
            lblSuspVelFR.Location = new Point(587, 274);
            lblSuspVelFR.Name = "lblSuspVelFR";
            lblSuspVelFR.Size = new Size(13, 15);
            lblSuspVelFR.TabIndex = 43;
            lblSuspVelFR.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(579, 257);
            label15.Name = "label15";
            label15.Size = new Size(60, 15);
            label15.TabIndex = 42;
            label15.Text = "SuspVelFR";
            // 
            // lblSuspVelBR
            // 
            lblSuspVelBR.AutoSize = true;
            lblSuspVelBR.Location = new Point(586, 306);
            lblSuspVelBR.Name = "lblSuspVelBR";
            lblSuspVelBR.Size = new Size(13, 15);
            lblSuspVelBR.TabIndex = 41;
            lblSuspVelBR.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(579, 289);
            label17.Name = "label17";
            label17.Size = new Size(61, 15);
            label17.TabIndex = 40;
            label17.Text = "SuspVelBR";
            // 
            // lblSuspVelFL
            // 
            lblSuspVelFL.AutoSize = true;
            lblSuspVelFL.Location = new Point(505, 274);
            lblSuspVelFL.Name = "lblSuspVelFL";
            lblSuspVelFL.Size = new Size(13, 15);
            lblSuspVelFL.TabIndex = 39;
            lblSuspVelFL.Text = "0";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(493, 257);
            label21.Name = "label21";
            label21.Size = new Size(59, 15);
            label21.TabIndex = 38;
            label21.Text = "SuspVelFL";
            // 
            // lblSuspVelBL
            // 
            lblSuspVelBL.AutoSize = true;
            lblSuspVelBL.Location = new Point(505, 306);
            lblSuspVelBL.Name = "lblSuspVelBL";
            lblSuspVelBL.Size = new Size(13, 15);
            lblSuspVelBL.TabIndex = 37;
            lblSuspVelBL.Text = "0";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(492, 289);
            label23.Name = "label23";
            label23.Size = new Size(60, 15);
            label23.TabIndex = 36;
            label23.Text = "SuspVelBL";
            // 
            // lblWheelSpFR
            // 
            lblWheelSpFR.AutoSize = true;
            lblWheelSpFR.Location = new Point(790, 170);
            lblWheelSpFR.Name = "lblWheelSpFR";
            lblWheelSpFR.Size = new Size(13, 15);
            lblWheelSpFR.TabIndex = 51;
            lblWheelSpFR.Text = "0";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(781, 153);
            label25.Name = "label25";
            label25.Size = new Size(66, 15);
            label25.TabIndex = 50;
            label25.Text = "WheelSpFR";
            // 
            // lblWheelSpBR
            // 
            lblWheelSpBR.AutoSize = true;
            lblWheelSpBR.Location = new Point(790, 200);
            lblWheelSpBR.Name = "lblWheelSpBR";
            lblWheelSpBR.Size = new Size(13, 15);
            lblWheelSpBR.TabIndex = 49;
            lblWheelSpBR.Text = "0";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(781, 185);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(67, 15);
            lbl2.TabIndex = 48;
            lbl2.Text = "WheelSpBR";
            // 
            // lblWheelSpFL
            // 
            lblWheelSpFL.AutoSize = true;
            lblWheelSpFL.Location = new Point(700, 170);
            lblWheelSpFL.Name = "lblWheelSpFL";
            lblWheelSpFL.Size = new Size(13, 15);
            lblWheelSpFL.TabIndex = 47;
            lblWheelSpFL.Text = "0";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(691, 153);
            label29.Name = "label29";
            label29.Size = new Size(65, 15);
            label29.TabIndex = 46;
            label29.Text = "WheelSpFL";
            // 
            // lblWheelSpBL
            // 
            lblWheelSpBL.AutoSize = true;
            lblWheelSpBL.Location = new Point(700, 202);
            lblWheelSpBL.Name = "lblWheelSpBL";
            lblWheelSpBL.Size = new Size(13, 15);
            lblWheelSpBL.TabIndex = 45;
            lblWheelSpBL.Text = "0";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(691, 185);
            label31.Name = "label31";
            label31.Size = new Size(66, 15);
            label31.TabIndex = 44;
            label31.Text = "WheelSpBL";
            // 
            // lblGForceLon
            // 
            lblGForceLon.AutoSize = true;
            lblGForceLon.Location = new Point(413, 307);
            lblGForceLon.Name = "lblGForceLon";
            lblGForceLon.Size = new Size(13, 15);
            lblGForceLon.TabIndex = 55;
            lblGForceLon.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(349, 307);
            label16.Name = "label16";
            label16.Size = new Size(64, 15);
            label16.TabIndex = 54;
            label16.Text = "GForceLon";
            // 
            // lblGForceLat
            // 
            lblGForceLat.AutoSize = true;
            lblGForceLat.Location = new Point(413, 278);
            lblGForceLat.Name = "lblGForceLat";
            lblGForceLat.Size = new Size(13, 15);
            lblGForceLat.TabIndex = 53;
            lblGForceLat.Text = "0";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(347, 278);
            label22.Name = "label22";
            label22.Size = new Size(60, 15);
            label22.TabIndex = 52;
            label22.Text = "GForceLat";
            // 
            // lblRPMs
            // 
            lblRPMs.AutoSize = true;
            lblRPMs.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRPMs.Location = new Point(217, 201);
            lblRPMs.Name = "lblRPMs";
            lblRPMs.Size = new Size(17, 20);
            lblRPMs.TabIndex = 57;
            lblRPMs.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(156, 206);
            label19.Name = "label19";
            label19.Size = new Size(37, 15);
            label19.TabIndex = 56;
            label19.Text = "RPMs";
            // 
            // button1
            // 
            button1.Location = new Point(1288, 493);
            button1.Name = "button1";
            button1.Size = new Size(66, 32);
            button1.TabIndex = 58;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(963, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1090, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1208, 174);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(181, 169);
            pictureBox3.TabIndex = 61;
            pictureBox3.TabStop = false;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(528, 19);
            lblX.Name = "lblX";
            lblX.Size = new Size(13, 15);
            lblX.TabIndex = 63;
            lblX.Text = "0";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(508, 19);
            label24.Name = "label24";
            label24.Size = new Size(14, 15);
            label24.TabIndex = 62;
            label24.Text = "X";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(527, 49);
            lblY.Name = "lblY";
            lblY.Size = new Size(13, 15);
            lblY.TabIndex = 65;
            lblY.Text = "0";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(507, 49);
            label27.Name = "label27";
            label27.Size = new Size(14, 15);
            label27.TabIndex = 64;
            label27.Text = "Y";
            // 
            // lblZ
            // 
            lblZ.AutoSize = true;
            lblZ.Location = new Point(528, 79);
            lblZ.Name = "lblZ";
            lblZ.Size = new Size(13, 15);
            lblZ.TabIndex = 67;
            lblZ.Text = "0";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(507, 79);
            label30.Name = "label30";
            label30.Size = new Size(14, 15);
            label30.TabIndex = 66;
            label30.Text = "Z";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpeed.Location = new Point(217, 171);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(17, 20);
            lblSpeed.TabIndex = 69;
            lblSpeed.Text = "0";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(154, 175);
            label26.Name = "label26";
            label26.Size = new Size(39, 15);
            label26.TabIndex = 68;
            label26.Text = "Speed";
            // 
            // lblZv
            // 
            lblZv.AutoSize = true;
            lblZv.Location = new Point(789, 19);
            lblZv.Name = "lblZv";
            lblZv.Size = new Size(13, 15);
            lblZv.TabIndex = 75;
            lblZv.Text = "0";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(763, 19);
            label32.Name = "label32";
            label32.Size = new Size(20, 15);
            label32.TabIndex = 74;
            label32.Text = "Zv";
            // 
            // lblYv
            // 
            lblYv.AutoSize = true;
            lblYv.Location = new Point(694, 19);
            lblYv.Name = "lblYv";
            lblYv.Size = new Size(13, 15);
            lblYv.TabIndex = 73;
            lblYv.Text = "0";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(668, 19);
            label34.Name = "label34";
            label34.Size = new Size(20, 15);
            label34.TabIndex = 72;
            label34.Text = "Yv";
            // 
            // lblXv
            // 
            lblXv.AutoSize = true;
            lblXv.Location = new Point(604, 19);
            lblXv.Name = "lblXv";
            lblXv.Size = new Size(13, 15);
            lblXv.TabIndex = 71;
            lblXv.Text = "0";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(579, 19);
            label36.Name = "label36";
            label36.Size = new Size(20, 15);
            label36.TabIndex = 70;
            label36.Text = "Xv";
            // 
            // lblZr
            // 
            lblZr.AutoSize = true;
            lblZr.Location = new Point(789, 49);
            lblZr.Name = "lblZr";
            lblZr.Size = new Size(13, 15);
            lblZr.TabIndex = 81;
            lblZr.Text = "0";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(763, 49);
            label38.Name = "label38";
            label38.Size = new Size(18, 15);
            label38.TabIndex = 80;
            label38.Text = "Zr";
            // 
            // lblYr
            // 
            lblYr.AutoSize = true;
            lblYr.Location = new Point(694, 49);
            lblYr.Name = "lblYr";
            lblYr.Size = new Size(13, 15);
            lblYr.TabIndex = 79;
            lblYr.Text = "0";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(668, 49);
            label40.Name = "label40";
            label40.Size = new Size(17, 15);
            label40.TabIndex = 78;
            label40.Text = "Yr";
            // 
            // lblXr
            // 
            lblXr.AutoSize = true;
            lblXr.Location = new Point(604, 49);
            lblXr.Name = "lblXr";
            lblXr.Size = new Size(13, 15);
            lblXr.TabIndex = 77;
            lblXr.Text = "0";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(579, 49);
            label42.Name = "label42";
            label42.Size = new Size(18, 15);
            label42.TabIndex = 76;
            label42.Text = "Xr";
            // 
            // lblZd
            // 
            lblZd.AutoSize = true;
            lblZd.Location = new Point(790, 79);
            lblZd.Name = "lblZd";
            lblZd.Size = new Size(13, 15);
            lblZd.TabIndex = 87;
            lblZd.Text = "0";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(763, 79);
            label44.Name = "label44";
            label44.Size = new Size(21, 15);
            label44.TabIndex = 86;
            label44.Text = "Zd";
            // 
            // lblYd
            // 
            lblYd.AutoSize = true;
            lblYd.Location = new Point(694, 79);
            lblYd.Name = "lblYd";
            lblYd.Size = new Size(13, 15);
            lblYd.TabIndex = 85;
            lblYd.Text = "0";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(665, 79);
            label46.Name = "label46";
            label46.Size = new Size(20, 15);
            label46.TabIndex = 84;
            label46.Text = "Yd";
            // 
            // lblXd
            // 
            lblXd.AutoSize = true;
            lblXd.Location = new Point(603, 79);
            lblXd.Name = "lblXd";
            lblXd.Size = new Size(13, 15);
            lblXd.TabIndex = 83;
            lblXd.Text = "0";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(579, 79);
            label48.Name = "label48";
            label48.Size = new Size(21, 15);
            label48.TabIndex = 82;
            label48.Text = "Xd";
            // 
            // lblThrottle
            // 
            lblThrottle.AutoSize = true;
            lblThrottle.Location = new Point(413, 153);
            lblThrottle.Name = "lblThrottle";
            lblThrottle.Size = new Size(13, 15);
            lblThrottle.TabIndex = 89;
            lblThrottle.Text = "0";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(349, 153);
            label50.Name = "label50";
            label50.Size = new Size(49, 15);
            label50.TabIndex = 88;
            label50.Text = "Throttle";
            // 
            // lblGear
            // 
            lblGear.AutoSize = true;
            lblGear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGear.Location = new Point(217, 230);
            lblGear.Name = "lblGear";
            lblGear.Size = new Size(17, 20);
            lblGear.TabIndex = 91;
            lblGear.Text = "0";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Location = new Point(156, 234);
            label52.Name = "label52";
            label52.Size = new Size(31, 15);
            label52.TabIndex = 90;
            label52.Text = "Gear";
            // 
            // lblSteer
            // 
            lblSteer.AutoSize = true;
            lblSteer.Location = new Point(413, 182);
            lblSteer.Name = "lblSteer";
            lblSteer.Size = new Size(13, 15);
            lblSteer.TabIndex = 93;
            lblSteer.Text = "0";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new Point(349, 182);
            label54.Name = "label54";
            label54.Size = new Size(33, 15);
            label54.TabIndex = 92;
            label54.Text = "Steer";
            // 
            // lblBrake
            // 
            lblBrake.AutoSize = true;
            lblBrake.Location = new Point(412, 211);
            lblBrake.Name = "lblBrake";
            lblBrake.Size = new Size(13, 15);
            lblBrake.TabIndex = 95;
            lblBrake.Text = "0";
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(349, 211);
            label56.Name = "label56";
            label56.Size = new Size(36, 15);
            label56.TabIndex = 94;
            label56.Text = "Brake";
            // 
            // lblClutch
            // 
            lblClutch.AutoSize = true;
            lblClutch.Location = new Point(412, 239);
            lblClutch.Name = "lblClutch";
            lblClutch.Size = new Size(13, 15);
            lblClutch.TabIndex = 97;
            lblClutch.Text = "0";
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Location = new Point(347, 239);
            label58.Name = "label58";
            label58.Size = new Size(42, 15);
            label58.TabIndex = 96;
            label58.Text = "Clutch";
            // 
            // lblBrakeTempFR
            // 
            lblBrakeTempFR.AutoSize = true;
            lblBrakeTempFR.Location = new Point(789, 274);
            lblBrakeTempFR.Name = "lblBrakeTempFR";
            lblBrakeTempFR.Size = new Size(13, 15);
            lblBrakeTempFR.TabIndex = 105;
            lblBrakeTempFR.Text = "0";
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Location = new Point(778, 257);
            label60.Name = "label60";
            label60.Size = new Size(84, 15);
            label60.TabIndex = 104;
            label60.Text = "BrakesTempFR";
            // 
            // lblBrakeTempBR
            // 
            lblBrakeTempBR.AutoSize = true;
            lblBrakeTempBR.Location = new Point(790, 306);
            lblBrakeTempBR.Name = "lblBrakeTempBR";
            lblBrakeTempBR.Size = new Size(13, 15);
            lblBrakeTempBR.TabIndex = 103;
            lblBrakeTempBR.Text = "0";
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Location = new Point(778, 289);
            label62.Name = "label62";
            label62.Size = new Size(85, 15);
            label62.TabIndex = 102;
            label62.Text = "BrakesTempBR";
            // 
            // lblBrakeTempFL
            // 
            lblBrakeTempFL.AutoSize = true;
            lblBrakeTempFL.Location = new Point(700, 272);
            lblBrakeTempFL.Name = "lblBrakeTempFL";
            lblBrakeTempFL.Size = new Size(13, 15);
            lblBrakeTempFL.TabIndex = 101;
            lblBrakeTempFL.Text = "0";
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Location = new Point(691, 257);
            label64.Name = "label64";
            label64.Size = new Size(83, 15);
            label64.TabIndex = 100;
            label64.Text = "BrakesTempFL";
            // 
            // lblBrakeTempBL
            // 
            lblBrakeTempBL.AutoSize = true;
            lblBrakeTempBL.Location = new Point(700, 304);
            lblBrakeTempBL.Name = "lblBrakeTempBL";
            lblBrakeTempBL.Size = new Size(13, 15);
            lblBrakeTempBL.TabIndex = 99;
            lblBrakeTempBL.Text = "0";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Location = new Point(690, 289);
            label66.Name = "label66";
            label66.Size = new Size(84, 15);
            label66.TabIndex = 98;
            label66.Text = "BrakesTempBL";
            // 
            // lblTrackID
            // 
            lblTrackID.AutoSize = true;
            lblTrackID.Location = new Point(86, 175);
            lblTrackID.Name = "lblTrackID";
            lblTrackID.Size = new Size(13, 15);
            lblTrackID.TabIndex = 107;
            lblTrackID.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 175);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 106;
            label7.Text = "TrackID";
            // 
            // lblVechileID
            // 
            lblVechileID.AutoSize = true;
            lblVechileID.Location = new Point(86, 233);
            lblVechileID.Name = "lblVechileID";
            lblVechileID.Size = new Size(13, 15);
            lblVechileID.TabIndex = 109;
            lblVechileID.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 232);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 108;
            label14.Text = "VechileID";
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(86, 204);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(13, 15);
            lblCarID.TabIndex = 111;
            lblCarID.Text = "0";
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Location = new Point(22, 204);
            label68.Name = "label68";
            label68.Size = new Size(36, 15);
            label68.TabIndex = 110;
            label68.Text = "CarID";
            // 
            // lblMaxGear
            // 
            lblMaxGear.AutoSize = true;
            lblMaxGear.Location = new Point(453, 19);
            lblMaxGear.Name = "lblMaxGear";
            lblMaxGear.Size = new Size(13, 15);
            lblMaxGear.TabIndex = 113;
            lblMaxGear.Text = "0";
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Location = new Point(349, 19);
            label70.Name = "label70";
            label70.Size = new Size(86, 15);
            label70.TabIndex = 112;
            label70.Text = "Max Gear Num";
            // 
            // lblLastLapStageTime
            // 
            lblLastLapStageTime.AutoSize = true;
            lblLastLapStageTime.Location = new Point(236, 135);
            lblLastLapStageTime.Name = "lblLastLapStageTime";
            lblLastLapStageTime.Size = new Size(13, 15);
            lblLastLapStageTime.TabIndex = 115;
            lblLastLapStageTime.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(156, 135);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 114;
            label11.Text = "LastLapTime";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 334);
            Controls.Add(lblLastLapStageTime);
            Controls.Add(label11);
            Controls.Add(lblMaxGear);
            Controls.Add(label70);
            Controls.Add(lblCarID);
            Controls.Add(label68);
            Controls.Add(lblVechileID);
            Controls.Add(label14);
            Controls.Add(lblTrackID);
            Controls.Add(label7);
            Controls.Add(lblBrakeTempFR);
            Controls.Add(label60);
            Controls.Add(lblBrakeTempBR);
            Controls.Add(label62);
            Controls.Add(lblBrakeTempFL);
            Controls.Add(label64);
            Controls.Add(lblBrakeTempBL);
            Controls.Add(label66);
            Controls.Add(lblClutch);
            Controls.Add(label58);
            Controls.Add(lblBrake);
            Controls.Add(label56);
            Controls.Add(lblSteer);
            Controls.Add(label54);
            Controls.Add(lblGear);
            Controls.Add(label52);
            Controls.Add(lblThrottle);
            Controls.Add(label50);
            Controls.Add(lblZd);
            Controls.Add(label44);
            Controls.Add(lblYd);
            Controls.Add(label46);
            Controls.Add(lblXd);
            Controls.Add(label48);
            Controls.Add(lblZr);
            Controls.Add(label38);
            Controls.Add(lblYr);
            Controls.Add(label40);
            Controls.Add(lblXr);
            Controls.Add(label42);
            Controls.Add(lblZv);
            Controls.Add(label32);
            Controls.Add(lblYv);
            Controls.Add(label34);
            Controls.Add(lblXv);
            Controls.Add(label36);
            Controls.Add(lblSpeed);
            Controls.Add(label26);
            Controls.Add(lblZ);
            Controls.Add(label30);
            Controls.Add(lblY);
            Controls.Add(label27);
            Controls.Add(lblX);
            Controls.Add(label24);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lblRPMs);
            Controls.Add(label19);
            Controls.Add(lblGForceLon);
            Controls.Add(label16);
            Controls.Add(lblGForceLat);
            Controls.Add(label22);
            Controls.Add(lblWheelSpFR);
            Controls.Add(label25);
            Controls.Add(lblWheelSpBR);
            Controls.Add(lbl2);
            Controls.Add(lblWheelSpFL);
            Controls.Add(label29);
            Controls.Add(lblWheelSpBL);
            Controls.Add(label31);
            Controls.Add(lblSuspVelFR);
            Controls.Add(label15);
            Controls.Add(lblSuspVelBR);
            Controls.Add(label17);
            Controls.Add(lblSuspVelFL);
            Controls.Add(label21);
            Controls.Add(lblSuspVelBL);
            Controls.Add(label23);
            Controls.Add(lblSuspensionFR);
            Controls.Add(label20);
            Controls.Add(lblSuspensionBR);
            Controls.Add(label18);
            Controls.Add(lblSuspensionFL);
            Controls.Add(lbl1);
            Controls.Add(lblSuspensionBL);
            Controls.Add(label12);
            Controls.Add(lblPercent);
            Controls.Add(label10);
            Controls.Add(lblDistance);
            Controls.Add(label13);
            Controls.Add(lblTotalTime);
            Controls.Add(label9);
            Controls.Add(lblSector);
            Controls.Add(label8);
            Controls.Add(lblTotalLaps);
            Controls.Add(label5);
            Controls.Add(lblCarPos);
            Controls.Add(label4);
            Controls.Add(lblLapRX);
            Controls.Add(label3);
            Controls.Add(lblLapTime);
            Controls.Add(label1);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = " BuiltClever - Dirt Rally 2 - Extracting the data in code";
            TopMost = true;
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Button btnDisconnect;
        private Label label1;
        private Label lblLapTime;
        private Label label3;
        private Label lblLapRX;
        private Label lblCarPos;
        private Label label4;
        private Label lblTotalLaps;
        private Label label5;
        private Label lblSector;
        private Label label8;
        private Label lblTotalTime;
        private Label label9;
        private Label lblPercent;
        private Label label10;
        private Label lblDistance;
        private Label label13;
        private Label lblSuspensionBL;
        private Label label12;
        private Label lblSuspensionFL;
        private Label lbl1;
        private Label lblSuspensionBR;
        private Label label18;
        private Label lblSuspensionFR;
        private Label label20;
        private Label lblSuspVelFR;
        private Label label15;
        private Label lblSuspVelBR;
        private Label label17;
        private Label lblSuspVelFL;
        private Label label21;
        private Label lblSuspVelBL;
        private Label label23;
        private Label lblWheelSpFR;
        private Label label25;
        private Label lblWheelSpBR;
        private Label lbl2;
        private Label lblWheelSpFL;
        private Label label29;
        private Label lblWheelSpBL;
        private Label label31;
        private Label lblGForceLon;
        private Label label16;
        private Label lblGForceLat;
        private Label label22;
        private Label lblRPMs;
        private Label label19;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblX;
        private Label label24;
        private Label lblY;
        private Label label27;
        private Label lblZ;
        private Label label30;
        private Label lblSpeed;
        private Label label26;
        private Label lblZv;
        private Label label32;
        private Label lblYv;
        private Label label34;
        private Label lblXv;
        private Label label36;
        private Label lblZr;
        private Label label38;
        private Label lblYr;
        private Label label40;
        private Label lblXr;
        private Label label42;
        private Label lblZd;
        private Label label44;
        private Label lblYd;
        private Label label46;
        private Label lblXd;
        private Label label48;
        private Label lblThrottle;
        private Label label50;
        private Label lblGear;
        private Label label52;
        private Label lblSteer;
        private Label label54;
        private Label lblBrake;
        private Label label56;
        private Label lblClutch;
        private Label label58;
        private Label lblBrakeTempFR;
        private Label label60;
        private Label lblBrakeTempBR;
        private Label label62;
        private Label lblBrakeTempFL;
        private Label label64;
        private Label lblBrakeTempBL;
        private Label label66;
        private Label lblTrackID;
        private Label label7;
        private Label lblVechileID;
        private Label label14;
        private Label lblCarID;
        private Label label68;
        private Label lblMaxGear;
        private Label label70;
        private Label lblLastLapStageTime;
        private Label label11;
    }
}
