﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Prediction.DataStructures
{
    public class StdRoomRateData
    {
        public StdRoomRateData(DateTime date, float prev, float amount)
        {
            this.Date = date;
            this.Prev = prev;
            this.Amount = amount;
        }

        public float Next;

        public DateTime Date;

        public float Prev;
        public float Amount;
    }
}
