// ---------------------------------------------------------
// Dirty Rally 2 Telemetry structure
// ---------------------------------------------------------
// Created by BuiltClever for our Telemetry Rally YouTube series at  https://www.youtube.com/@builtclever
// Video featureing this code: https://youtu.be/y54JsC7V1no 
// Video to set up config file in DR2: https://www.youtube.com/watch?v=Scy-xjmJ-kU
// Video with Telemetry properties in full detail: https://www.youtube.com/watch?v=c9YiPMefTNY&pp=0gcJCckJAYcqIYzv
// Web Site: http://www.builtClever.com
// ---------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RaceDataYouTube
{
    
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode, Pack = 1, Size = 264)]
    public struct TelemetryData
    {
        // Total Time [seconds] (Starts during the count down is rally stage and rally cross!!!)
        // Rally: Time Since start of Race, Starts at very beginning including for count down!!!
        // Rally cross: Time Since start of Race, Starts at very beginning including line up and count down!!! would need to calculate actual total race time manually (eg laptime > 0 get time to offset)
        [MarshalAs(UnmanagedType.R4), FieldOffset(0)]
        public Single TotalTime;

        // LapTime [seconds]
        // Rally: Total Time (starts after go, continues counting across stages)
        // Rally cross: Time since start of Lap (resets after each lap)
        [MarshalAs(UnmanagedType.R4), FieldOffset(4)]
        public Single LapTime;

        // Distance [meters]
        // Rally: Distance travelled since start of Race (continues across stages)
        // Rally cross: Distance travelled since start of Lap (resets after each lap)
        [MarshalAs(UnmanagedType.R4), FieldOffset(8)]
        public Single Distance;

        // PercentComplete [0 to 1]
        // Rally: Percent travelled through the race
        // Rally cross: Percent travelled through the Lap (resets after each Lap)
        [MarshalAs(UnmanagedType.R4), FieldOffset(12)]
        public Single PercentComplete; // this is the percentage of how far through the race you are (0 to 1)

        // ---------------------------------------------------------------------
        // World space positions [meters]
        // this is the car position on the map relative to the map
        [MarshalAs(UnmanagedType.R4), FieldOffset(16)]
        public Single X; // (Horizontal left - right)
        [MarshalAs(UnmanagedType.R4), FieldOffset(20)]
        public Single Y; // (vertical up - down)
        [MarshalAs(UnmanagedType.R4), FieldOffset(24)]
        public Single Z; // (depth forward - backward)
                            // ---------------------------------------------------------------------

        // Speed - Velocity (Speed [meters per second]) * 3.6 for kilometres per hour, * 2.2369 = miles per hour
        [MarshalAs(UnmanagedType.R4), FieldOffset(28)]
        public Single Speed;

        // ---------------------------------------------------------------------
        // Velocity in world space [meters per second]
        // the speed at which the car is moving along each axis
        [MarshalAs(UnmanagedType.R4), FieldOffset(32)]
        public Single Xv; // (Horizontal left - right)
        [MarshalAs(UnmanagedType.R4), FieldOffset(36)]
        public Single Yv; // (vertical up - down)
        [MarshalAs(UnmanagedType.R4), FieldOffset(40)]
        public Single Zv; // (depth forward - backward)
                            // ---------------------------------------------------------------------

        // ---------------------------------------------------------------------
        // World space right direction [decimal 0 to 1] (normalised)
        // Represents the car's rightward direction relative to the world space positions X,Y,Z
        // helps with determine lateral movement and orientation.
        [MarshalAs(UnmanagedType.R4), FieldOffset(44)]
        public Single Xr;
        [MarshalAs(UnmanagedType.R4), FieldOffset(48)]
        public Single Yr;
        [MarshalAs(UnmanagedType.R4), FieldOffset(52)]
        public Single Zr;
        // ---------------------------------------------------------------------

        // ---------------------------------------------------------------------
        // World space forward direction [decimal 0 to 1] (normalised)
        // Represents the car's forward direction relative to the world space positions X,Y,Z
        // helps with speed, heading, and yaw-related calculations.
        [MarshalAs(UnmanagedType.R4), FieldOffset(56)]
        public Single Xd;
        [MarshalAs(UnmanagedType.R4), FieldOffset(60)]
        public Single Yd;
        [MarshalAs(UnmanagedType.R4), FieldOffset(64)]
        public Single Zd;
        // ---------------------------------------------------------------------

        // ---------------------------------------------------------------------
        // Suspension position for each wheel [Scale 0 to 1000]
        // ---------------------------------------------------------------------
        [MarshalAs(UnmanagedType.R4), FieldOffset(68)]
        public Single Susp_pos_bl; // Position of Suspension Rear Left
        [MarshalAs(UnmanagedType.R4), FieldOffset(72)]
        public Single Susp_pos_br; // Position of Suspension Rear Right
        [MarshalAs(UnmanagedType.R4), FieldOffset(76)]
        public Single Susp_pos_fl;// Position of Suspension Front Left
        [MarshalAs(UnmanagedType.R4), FieldOffset(80)]
        public Single Susp_pos_fr; // Position of Suspension Front Right
                                    // ---------------------------------------------------------------------

        // ---------------------------------------------------------------------
        // Velocity of Suspension [meters per second]
        // ---------------------------------------------------------------------
        [MarshalAs(UnmanagedType.R4), FieldOffset(84)]
        public Single Susp_vel_bl; // Velocity of Suspension Rear Left
        [MarshalAs(UnmanagedType.R4), FieldOffset(88)]
        public Single Susp_vel_br;// Velocity of Suspension Rear Right
        [MarshalAs(UnmanagedType.R4), FieldOffset(92)]
        public Single Susp_vel_fl;// Velocity of Suspension Front Left
        [MarshalAs(UnmanagedType.R4), FieldOffset(96)]
        public Single Susp_vel_fr;// Velocity of Suspension Front Right
                                    // ---------------------------------------------------------------------


        // ---------------------------------------------------------------------
        // Velocity of Wheels [meters per second]
        // ---------------------------------------------------------------------
        [MarshalAs(UnmanagedType.R4), FieldOffset(100)]
        public Single Wheel_speed_bl; // Velocity of Wheel Rear Left
        [MarshalAs(UnmanagedType.R4), FieldOffset(104)]
        public Single Wheel_speed_br; // Velocity of Wheel Rear Right
        [MarshalAs(UnmanagedType.R4), FieldOffset(108)]
        public Single Wheel_speed_fl; // Velocity of Wheel Front Left
        [MarshalAs(UnmanagedType.R4), FieldOffset(112)]
        public Single Wheel_speed_fr; // Velocity of Wheel Front Right
                                        // ---------------------------------------------------------------------

        // Throttle Position [0 (off) to 1 (full)]
        [MarshalAs(UnmanagedType.R4), FieldOffset(116)]
        public Single Throttle;

        // Steering wheel position [-1 (full left) to 1 (full right)]
        [MarshalAs(UnmanagedType.R4), FieldOffset(120)]
        public Single Steer;

        // Brake Position [0 (off) to 1 (full)]
        [MarshalAs(UnmanagedType.R4), FieldOffset(124)]
        public Single Brake;

        // Clutch Position [0 (off) to 1 (full)]
        [MarshalAs(UnmanagedType.R4), FieldOffset(128)]
        public Single Clutch;

        // Gear [0 = Neutral, 10 = Reverse, others are the gear]
        [MarshalAs(UnmanagedType.R4), FieldOffset(132)]
        public Single Gear;

        // ---------------------------------------------------------------------
        // G-Forces - where 1g is equivalent to Earth's gravitational acceleration (9.81 m/s²)
        [MarshalAs(UnmanagedType.R4), FieldOffset(136)]
        public Single Gforce_lat; // G-Force Lateral [G-forces (g)]
        [MarshalAs(UnmanagedType.R4), FieldOffset(140)]
        public Single Gforce_lon; // G-Force Longitudinal [G-forces (g)]
                                    // ---------------------------------------------------------------------

        // Lap_RX: [number]
        // Rally: [Not used always 0]
        // Rally cross: The current Lap number (0 based)
        [MarshalAs(UnmanagedType.R4), FieldOffset(144)]
        public Single Lap_RX;

        // Engine Rate [0-1000] (divide by 100 to get RPMs [0 – 10])
        [MarshalAs(UnmanagedType.R4), FieldOffset(148)]
        public Single EngineRate;

        // [NOT USED always 1] SLI Pro support (Sim Racing LED displays specifically the SLI-Pro hardware)
        //[MarshalAs(UnmanagedType.R4), FieldOffset(152)]
        //public Single Sli_pro_native_support; 

        // Current Position [number]
        // Rally: Normally 1, if behind ghost car = 2
        // Rally cross: current position in the race
        [MarshalAs(UnmanagedType.R4), FieldOffset(156)]
        public Single CarPosition_RX;

        // [NOT USED always 0] kers energy left (Kinetic Energy Recovery System (KERS), which is used in motorsports and some electric vehicles to recover energy during braking)
        //[MarshalAs(UnmanagedType.R4), FieldOffset(160)]
        //public Single Kers_level; 

        // [NOT USED always 0] kers maximum energy (the maximum amount of energy that the Kinetic Energy Recovery System (KERS) can store or deploy at any given time.)
        //[MarshalAs(UnmanagedType.R4), FieldOffset(164)]
        //public Single Kers_max_level; 

        // [NOT USED always 0] (Drag Reduction System) 0 off, 1 On (When activated, the rear wing flap opens, reducing drag and increasing straight-line speed.)
        //[MarshalAs(UnmanagedType.R4), FieldOffset(168)]
        //public Single Drs;

        // [NOT USED always 0] Traction control 0 (off) - 2 (high) 
        //[MarshalAs(UnmanagedType.R4), FieldOffset(172)]
        //public Single Traction_control; 

        // [NOT USED always 0] Anti Lock Brakes 0 (off) - 1 (on)
        //[MarshalAs(UnmanagedType.R4), FieldOffset(176)]
        //public Single Anti_lock_brakes; 

        // [NOT USED always 0] current fuel mass 
        //[MarshalAs(UnmanagedType.R4), FieldOffset(180)]
        //public Single Fuel_in_tank; 

        // [NOT USED always 0] fuel capacity 
        //[MarshalAs(UnmanagedType.R4), FieldOffset(184)]
        //public Single Fuel_capacity;

        // [NOT USED always 0] in the pits(0 = none, 1 = pitting, 2 = in pit area)
        //[MarshalAs(UnmanagedType.R4), FieldOffset(188)]
        //public Single In_pits; 

        // Sector [number]
        // Rally: current stage in the track (0 based)
        // Rally cross: current sector in the Lap (0 based)
        [MarshalAs(UnmanagedType.R4), FieldOffset(192)]
        public Single Sector; // Stage in the rally (0 based) 

        //// Sector1_time [seconds]
        //// NOTE: removed as can't get all sector times, better off calculating based on "Sector" changes and current "LapTime" time
        //// Rally: 0 at start of race, stage 1 time once stage 1 finished (NOTE: no stage 3,4,5,- times)
        //// Rally cross: 0 at start of race, sector 1 time once sector 1 finished (NOTE: no sector 3,4,5,- times)
        //[MarshalAs(UnmanagedType.R4), FieldOffset(196)]
        //public Single Sector1_time;

        //// Sector2_time [seconds]
        //// NOTE: removed as can't get all sector times, better off calculating based on "Sector" changes and current "LapTime" time
        //// Rally: 0 at start of race, stage 21 time once stage 2 finished (NOTE: no stage 3,4,5,- times)
        //// Rally cross: 0 at start of race, sector 2 time once sector 2finished (NOTE: no sector 3,4,5,- times)
        //[MarshalAs(UnmanagedType.R4), FieldOffset(200)]
        //public Single Sector2_time;

        // ---------------------------------------------------------------------
        // Brake Temp [Degrees Celsius]
        // ---------------------------------------------------------------------
        [MarshalAs(UnmanagedType.R4), FieldOffset(204)]
        public Single Brakes_temp_bl; // Brake Temperature Rear Left in C
        [MarshalAs(UnmanagedType.R4), FieldOffset(208)]
        public Single Brakes_temp_br; // Brake Temperature Rear Right in C 
        [MarshalAs(UnmanagedType.R4), FieldOffset(212)]
        public Single Brakes_temp_fl; // Brake Temperature Front Left in C
        [MarshalAs(UnmanagedType.R4), FieldOffset(216)]
        public Single Brakes_temp_fr; // Brake Temperature Front Right in C 
                                        // ---------------------------------------------------------------------

        // [NOT USED always 0] track size meters
        //[MarshalAs(UnmanagedType.R4), FieldOffset(220)]
        //public Single Track_size; 

        // [NOT USED always 0] last lap time 
        //[MarshalAs(UnmanagedType.R4), FieldOffset(224)]
        //public Single Last_lap_time; 

        // [NOT USED always 0] cars max RPM, at which point the rev limiter will kick in 
        //[MarshalAs(UnmanagedType.R4), FieldOffset(228)]
        //public Single Max_rpm; //

        // [NOT USED always 0] cars idle RPM 
        //[MarshalAs(UnmanagedType.R4), FieldOffset(232)]
        //public Single Idle_rpm; 

        // CurrentLap_RX [number]
        // Rally: [NOT USED always 0]
        // Rally cross: current Lap number (0 based)
        // NOTE: removed as is the same as Lap_RX
        //[MarshalAs(UnmanagedType.R4), FieldOffset(236)]
        //public Single CurrentLap_RX;

        // TotalLaps_RX [number]
        // Rally: [NOT USED always 1]
        // Rally cross: Total number of laps in the race
        [MarshalAs(UnmanagedType.R4), FieldOffset(240)]
        public Single TotalLaps_RX;

        // Track ID [decimal] ID of the current track.
        [MarshalAs(UnmanagedType.R4), FieldOffset(244)]
        public Single TrackID;

        // LastLapTimeRX [number]
        // Rally: [NOT USED always 0]
        // Rally cross: the time of your last lap, 0 when on first lap
        [MarshalAs(UnmanagedType.R4), FieldOffset(248)]
        public Single LastLapTimeRX;

        //Vehicle ID of the current car[decimal] (used with CarID and maxGears to identify car)
        [MarshalAs(UnmanagedType.R4), FieldOffset(252)]
        public Single VehicleID;

        // Car ID of the current car [decimal] (used with Vehicle ID and MaxGears to identify the car)
        // (NOTE: this is actually idle RPMs (most times but not always) ??? can match some ambiguous cars by idle RPMs read in game not this)
        [MarshalAs(UnmanagedType.R4), FieldOffset(256)]
        public Single CarID;

        // Max Gear of car [number] (4 speed, 5 speed, 6 speed, etc)
        [MarshalAs(UnmanagedType.R4), FieldOffset(260)]
        public Single MaxGearNumber;

    }

}
