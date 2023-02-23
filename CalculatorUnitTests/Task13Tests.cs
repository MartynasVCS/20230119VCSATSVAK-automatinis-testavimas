using NUnit.Framework;
using System;

namespace UnitTests
{
    internal class Task13Tests
    {

        /*
         * Užduotis:
         * 
         * Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
         * Testas “žalias” jeigu šiandien trečiadienis 
         * Testas “žalias” jeigu dabar yra 13h 
         * Testas “žalias” jei nuo 1 iki 10 (imtinai) yra 4 lyginiai skaičiai
         * 
         */

        [Test]
        public void CheckIf995DividesBy3()
        {
            int expectedRemainder = 0;

            int actualRemainder = 995 % 3;

            Assert.AreEqual(expectedRemainder, actualRemainder);
        }

        [Test]
        public void TodayIsWednesday()
        {
            DayOfWeek expectedResult = DayOfWeek.Wednesday;

            DayOfWeek actualResult = DateTime.Now.DayOfWeek;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TimeNowIs13h()
        {
            int expectedResult = 13;

            int actualResult = DateTime.Now.Hour;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckIfBetween1And10Are4EvenNumbers()
        {
            int expectedResult = 4;

            int actualResult = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    actualResult++;
                }
            }

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
