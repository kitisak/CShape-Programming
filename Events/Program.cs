using System;

public delegate void OnBoardF1TeamHandler(object sender, EventArgs e);

namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] teams = { "Mercides", "Redbull", "Alpine", "Ferrari" };

            F1Event f1 = new F1Event();
            f1.OnBoardF1TeamEvent += new OnBoardF1TeamHandler(callback);

            Random random = new Random();

            Console.WriteLine("Resualt forcast team win");

            for (int i = 1; i <= 5; i++)
            {
                int rd = random.Next(teams.Length);

                Console.WriteLine("Grandprix " i);

                if (teams[rd] == "Redbull" || teams[rd] == "Mercides")
                {
                    f1.OnBoardF1TeamEvent();
                }
            }
        }

        public static void callback(object sender, EventArgs e)
        {
            Console.WriteLine("This F1 teams onboard GrandPrix.");
        }
    }

    public class F1Event
    {
        public event OnBoardF1TeamHandler TeamF1Event;

        public void OnBoardF1TeamEvent() {
            if (TeamF1Event != null)
                TeamF1Event(this, EventArgs.Empty);
        }
    }
}
