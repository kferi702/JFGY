﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forma1.Service;

namespace Forma1.Controller
{
    public class Forma1Controller
    {
        private TeamService service;

        public Forma1Controller()
        {
            service = new TeamService();
        }

        public void initializeTestData()
        {
            service.provideTestData();
        }
    }
}
