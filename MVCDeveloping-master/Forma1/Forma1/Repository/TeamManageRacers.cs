﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    public partial class Team : ITeamManageRacers
    {
        /// <summary>
        /// Új versenyző felvitele
        /// </summary>
        /// <param name="r">Új versenyző</param>
        /// <exception cref="Exception">Két ugyanolyan versenyző nem adható a listához</exception>
        public void createRacer(Racer r)
        {

        }

        /// <summary>
        /// Töröl meglévő versenyzőt
        /// </summary>
        /// <param name="name">Törlendő versenyző neve</param>
        /// <exception cref="Exception">A versenyző a csapatnak nem része, nem lehet törölni</exception>
        /// <param name="newRacer"></param>
        public void deleteRacer(string name, Racer newRacer)
        {

        }

        /// <summary>
        /// Módosít meglévő versenyzőt
        /// </summary>
        /// <param name="name">Módosítandó versenyző</param>
        /// <exception cref="Exception">A módosítandó versenyzőt nem találjuk, nem lehet módosítani</exception>
        public void updateRacer(string name)
        {

        }
    }
}