﻿using HamsterWarz.Entities.Helper;
using HamsterWarz.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWarz.Client.Services
{
    public interface IHttpServiceProvider
    {
        Task<IEnumerable<Hamster>> GetAllHamstersAsync();
        Task<IEnumerable<Hamster>> GetRandomCompetitors();
        Task VoteHamster(IEnumerable<Hamster> hamster, int id);
        Task<IEnumerable<Hamster>> GetTopFiveCompetitors();
        Task<IEnumerable<Hamster>> GetBottomFiveCompetitors();
        Task RegisterMatchData(IEnumerable<Hamster> hamster, int id);
        Task<IEnumerable<Hamster>> GetHamsterMatchData(int id);
        Task<IEnumerable<TransfObjMatchWinrz>> GetAllRegisteredMatches();
    }
}