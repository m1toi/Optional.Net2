﻿using GameShop.Database.Repositories;

namespace GameShop.Core.Services
{
    public class DeveloperService: IDeveloperService
    {
        private readonly IDeveloperRepository _gameDeveloperRepository;

        public DeveloperService(IDeveloperRepository gameDeveloperRepository)
        {
            this._gameDeveloperRepository = gameDeveloperRepository;
        }

    }
}
