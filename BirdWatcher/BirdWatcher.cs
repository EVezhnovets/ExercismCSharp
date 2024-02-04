namespace BirdWatcher
{
    public class BirdWatcher
    {
        class BirdCount
        {
            private int[] birdsPerDay;
            public static int[] BirdsPerDay { get; set; } = { 0, 2, 5, 3, 7, 8, 4 };
            public BirdCount(int[] birdsPerDay) => this.birdsPerDay = birdsPerDay;

            public static int[] LastWeek() => BirdsPerDay;

            public int Today() => birdsPerDay[^1];

            public void IncrementTodaysCount() => ++birdsPerDay[birdsPerDay.Length - 1];

            public bool HasDayWithoutBirds()
            {
                bool bo = default;
                foreach (var item in birdsPerDay)
                {
                    if (item == 0)
                    {
                        bo = true;
                    }
                }
                return bo;
            }

            public int CountForFirstDays(int numberOfDays)
            {
                int sum = 0;
                for (int i = 0; i < numberOfDays; i++)
                {
                    sum += birdsPerDay[i];
                }
                return sum;
            }

            public int BusyDays()
            {
                var counter = 0;
                foreach (var item in birdsPerDay)
                {
                    if (item >= 5)
                    {
                        counter++;
                    }
                }
                return counter;
            }
        }
    }
}