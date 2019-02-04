using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forma1.Repository;

namespace Forma1.Service
{
    public class TeamService
    {
        private TestData testData;
        private F1 f1Repository;

        public TeamService()
        {
            testData = new TestData();
            f1Repository = new F1();
        }

        public void provideTestData()
        {
            testData = new TestData();
            f1Repository = testData.getTestData();
        }
    }
}
