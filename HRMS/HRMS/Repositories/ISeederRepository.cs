﻿using HRMS.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Repositories
{
    public interface ISeederRepository
    {
        bool CheckifEmpty();
        bool CheckPredictions();
        List<DailyRoomRates> GetLatestRoomRates(int roomid, DateTime? latest = null);
        List<DailyOccupancyRoomType> GetLatestRoomTypeOccupancy(int roomid, DateTime? latest = null);
        List<DailyPredictionModel> GetPredictions();
        void AddPredictions(List<DailyPredictionModel> list);
        void SeedRoomRates(string json);
        void SeedOccupancy(string json);
        void SeedRoomTypeOccupancy(string json);
    }
}
