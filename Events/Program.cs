using System;

// Declar Delegate
public delegate void OnBoardF1TeamHandler(object sender, EventArgs e);

namespace Events
{
    public class F1Event
    {
        //Declar Events
        public event OnBoardF1TeamHandler OnBoardTeamEvent;

        //Method
        public void OnBoardF1TeamEvent()
        {
            if (OnBoardTeamEvent != null)
                OnBoardTeamEvent(this, EventArgs.Empty);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] teams = { "Mercides", "Redbull", "Alpine", "Ferrari" };

            F1Event f1 = new F1Event();
            f1.OnBoardTeamEvent += new OnBoardF1TeamHandler(callback);

            Random random = new Random();

            Console.WriteLine("Resualt forcast team win");

            for (int i = 1; i <= 5; i++)
            {
                int rd = random.Next(teams.Length);

                Console.WriteLine("Grandprix " + i);

                if (teams[rd] == "Redbull")
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

   
}
