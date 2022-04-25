﻿using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPLatforms();
        Platform GetPlatformById(int Id);
        void CreatePlatform(Platform plat);
    }
}
