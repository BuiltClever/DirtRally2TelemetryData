// ---------------------------------------------------------
// Dirty Rally 2 Get Telemetry data
// ---------------------------------------------------------
// Created by BuiltClever for our Telemetry Rally YouTube series at  https://www.youtube.com/@builtclever
// Video featureing this code: 
// Video with Telemetry properties in full detail: https://www.youtube.com/watch?v=c9YiPMefTNY&pp=0gcJCckJAYcqIYzv
// Video to set up config file in DR2: https://www.youtube.com/watch?v=Scy-xjmJ-kU
// Web Site: http://www.builtClever.com
// ---------------------------------------------------------
using System.Runtime.InteropServices;

namespace RaceDataYouTube
{
    public partial class Form1 : Form
    {
            
        private CancellationTokenSource? c_CancellationTokenSource = null;
        private bool c_blnCurrentlyUpdating = false;

        public Form1()
        {
            InitializeComponent();
        }


        private async void btnConnect_Click(object sender, EventArgs e)
        {

            System.Net.Sockets.UdpClient udpGameData = new System.Net.Sockets.UdpClient();
            udpGameData.ExclusiveAddressUse = false;

            System.Net.IPAddress DirtRally2IPAddress = System.Net.IPAddress.Parse("127.0.0.1");
            int DirtRally2Port = 20777;

            System.Net.IPEndPoint myGroupEP = new System.Net.IPEndPoint(DirtRally2IPAddress, DirtRally2Port);
            udpGameData.Client.Bind(myGroupEP);
            btnDisconnect.Enabled = true;
            btnConnect.Enabled = false;

            // ---------------------------------------------
            // Listen For GameData
            // ---------------------------------------------
            c_CancellationTokenSource = new System.Threading.CancellationTokenSource();
            await ListenForGameData(udpGameData, c_CancellationTokenSource.Token);

            // Stopped listening (CancellationToken was cancelled)
            udpGameData.Close();
            udpGameData.Dispose();

        }

        private async Task ListenForGameData(System.Net.Sockets.UdpClient p_UdpClient, CancellationToken p_CancellationToken)
        {

            System.Net.Sockets.UdpReceiveResult result;
            do
            {
                result = await p_UdpClient.ReceiveAsync();

                if (p_CancellationToken.IsCancellationRequested == true)
                {
                    return;
                }

                if (c_blnCurrentlyUpdating == false)
                {
                    byte[] data = result.Buffer;
                    TelemetryData myTelemetry = ByteArrayToStructure(data);
                                                            
                    c_blnCurrentlyUpdating = true;
                    this.Invoke((Action)(() => // Update UI on the main thread
                    {
                        UpdateFormTelemetryData(myTelemetry);
                        c_blnCurrentlyUpdating = false;
                    }));
                }

            } while (true);

        }





        public static TelemetryData ByteArrayToStructure(byte[] aryBytes)
        {
            TelemetryData myResult = new TelemetryData();
            int len = Marshal.SizeOf(myResult);
            IntPtr i = Marshal.AllocHGlobal(len);
            Marshal.Copy(aryBytes, 0, i, len);
            myResult = (TelemetryData)Marshal.PtrToStructure(i, myResult.GetType())!;
            Marshal.FreeHGlobal(i);

            return myResult;
        }



        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void Disconnect()
        {
            if (c_CancellationTokenSource != null)
            {
                c_CancellationTokenSource.Cancel();
                c_CancellationTokenSource.Dispose();
                c_CancellationTokenSource = null;
            }
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }


        private void UpdateFormTelemetryData(TelemetryData gameInfo)
        {
           
            lblSpeed.Text = (gameInfo.Speed * 3.6F).ToString(); // Speed - Velocity (Speed [meters per second]) * 3.6 for kilometres per hour, * 2.2369 = miles per hour
            lblRPMs.Text = (gameInfo.EngineRate / 100).ToString(); // Engine Rate [0-1000] (divide by 100 to get RPMs [0 – 10])

            lblTotalTime.Text = gameInfo.TotalTime.ToString();
            lblLapTime.Text = gameInfo.LapTime.ToString();
            lblDistance.Text = gameInfo.Distance.ToString();
            lblPercent.Text = gameInfo.PercentComplete.ToString();
            lblMaxGear.Text = gameInfo.MaxGearNumber.ToString();

            lblGear.Text = gameInfo.Gear.ToString();
            lblThrottle.Text = gameInfo.Throttle.ToString();
            lblSteer.Text = gameInfo.Steer.ToString();
            lblBrake.Text = gameInfo.Brake.ToString();
            lblClutch.Text = gameInfo.Clutch.ToString();

            lblLapRX.Text = gameInfo.Lap_RX.ToString();
            lblCarPos.Text = gameInfo.CarPosition_RX.ToString();
            lblSector.Text = gameInfo.Sector.ToString();
            lblTotalLaps.Text = gameInfo.TotalLaps_RX.ToString();
            lblLastLapStageTime.Text = gameInfo.LastLapTimeRX.ToString();

            lblX.Text = gameInfo.X.ToString();
            lblY.Text = gameInfo.Y.ToString();
            lblZ.Text = gameInfo.Z.ToString();

            lblXv.Text = gameInfo.Xv.ToString();
            lblYv.Text = gameInfo.Yv.ToString();
            lblZv.Text = gameInfo.Zv.ToString();

            lblXr.Text = gameInfo.Xr.ToString();
            lblYr.Text = gameInfo.Yr.ToString();
            lblZr.Text = gameInfo.Zr.ToString();

            lblXd.Text = gameInfo.Xd.ToString();
            lblYd.Text = gameInfo.Yd.ToString();
            lblZd.Text = gameInfo.Zd.ToString();


            lblTrackID.Text = gameInfo.TrackID.ToString();
            lblVechileID.Text = gameInfo.VehicleID.ToString();
            lblCarID.Text = gameInfo.CarID.ToString();

            lblGForceLon.Text = gameInfo.Gforce_lon.ToString();
            lblGForceLat.Text = gameInfo.Gforce_lat.ToString();


            lblSuspensionFL.Text = gameInfo.Susp_pos_fl.ToString();
            lblSuspensionFR.Text = gameInfo.Susp_pos_fr.ToString();
            lblSuspensionBL.Text = gameInfo.Susp_pos_bl.ToString();
            lblSuspensionBR.Text = gameInfo.Susp_pos_br.ToString();

            lblSuspVelFL.Text = gameInfo.Susp_vel_fl.ToString();
            lblSuspVelFR.Text = gameInfo.Susp_vel_fr.ToString();
            lblSuspVelBL.Text = gameInfo.Susp_vel_bl.ToString();
            lblSuspVelBR.Text = gameInfo.Susp_vel_br.ToString();

            lblWheelSpFL.Text = gameInfo.Wheel_speed_fl.ToString();
            lblWheelSpFR.Text = gameInfo.Wheel_speed_fr.ToString();
            lblWheelSpBL.Text = gameInfo.Wheel_speed_bl.ToString();
            lblWheelSpBR.Text = gameInfo.Wheel_speed_br.ToString();

            lblBrakeTempFL.Text = gameInfo.Brakes_temp_fl.ToString();
            lblBrakeTempFR.Text = gameInfo.Brakes_temp_fr.ToString();
            lblBrakeTempBL.Text = gameInfo.Brakes_temp_bl.ToString();
            lblBrakeTempBR.Text = gameInfo.Brakes_temp_br.ToString();

        }


    }
}
