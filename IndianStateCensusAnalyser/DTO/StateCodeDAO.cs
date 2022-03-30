﻿using System;

namespace IndianStateCensusAnalyser.POCO
{
    public class StateCodeDAO
    {
        public int serialNumber;
        public string stateName;
        public int pin;
        public string stateCode;
    }
    public CensusDataDAO(string v1, string v2, string v3, string v4)
    {
        this.serialNumber = Convert.ToInt32(v1);
        this.stateName = v2;
        this.pin = Convert.ToInt32(v3);
        this.stateCode = v4;
    }
}
