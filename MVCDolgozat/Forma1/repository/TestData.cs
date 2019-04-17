using System.Diagnostics;
using Forma1.myexeption;

namespace Forma1.repository
{
    class TestData
    {
        public F1 getTestData()
        {
            F1 f1 = new F1();

            Racer r1 = null;

            try
            {
                r1 = new Racer(1, "Hamilton", 34, 245);
            }
            catch (RacerException e)
            {
                Debug.WriteLine(e.Message);
            }

            Racer r2 = null;
            try
            {
                r2 = new Racer(2, "Raikonen", 39, 45);
            }
            catch (RacerException e)
            {
                Debug.WriteLine(e.Message);
            }

            Racer r3 = null;

            try
            {
                r3 = new Racer(3, "Bottas", 27, 50);
            }
            catch (RacerException e)
            {
                Debug.WriteLine(e.Message);
            }

            Racer r4 = null;
            try
            {
                r4 = new Racer(4, "Vettel", 31, 182);
            }
            catch (RacerException e)
            {
                Debug.WriteLine(e.Message);
            }

            Racer r5 = null;

            try
            {
                r5 = new Racer(5, "Verstappen", 21, 70);
            }
            catch (RacerException e)
            {
                Debug.WriteLine(e.Message);
            }

            Racer r6 = null;
            try
            {
                r6 = new Racer(5, "fittipaldi", 88, 70);
            }
            catch (RacerException e)
            {
                Debug.WriteLine(e.Message);
            }

            Racer r7 = null;

            try
            {
                r7 = new Racer(5, "Verstappen", 21, 70);
            }
            catch (RacerException e)
            {
                Debug.WriteLine(e.Message);
            }


            Racer r8 = null;

            try
            {
                r8 = new Racer(5, "Csaba", 78, 10);
            }
            catch (RacerException e)
            {
                Debug.WriteLine(e.Message);
            }


            Team t1 = null;

            try
            {
                t1 = new Team("Mc Laren");
            }
            catch (TeamException e)
            {
                Debug.WriteLine(e.Message);
            }

            Team t2 = null;
            try
            {
                t2 = new Team("Ferrari");
            }
            catch (TeamException e)
            {
                Debug.WriteLine(e.Message);
            }

            Team t3 = null;
            try
            {
                t3 = new Team("trabant");
            }
            catch (TeamException e)
            {
                Debug.WriteLine(e.Message);
            }

            t1.addRacer(r1);
            t1.addRacer(r3);
            t2.addRacer(r2);
            t2.addRacer(r4);
            t2.addRacer(r5);
            t2.addRacer(r6);
            t2.addRacer(r8);

            f1.add(t1);
            f1.add(t2);


            return f1;
        }
    }
}
