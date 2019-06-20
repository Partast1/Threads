using System;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wizard w = new Wizard();
            Knight WhiteKnight = new Knight(30);
            //Knight BlackKnight = new Knight(30);
            Wizard RedWizzard = new Wizard();
            Fight(WhiteKnight, BlackKnight);

            Console.ReadLine();
        }
        public static IFighter Fight(IFighter f1, IFighter f2)
        {

            while ((!f1.HasEscaped() && !f2.HasEscaped()) && ((f1.DefenseLeft > 0) && (f2.DefenseLeft > 0)))
            {

                // Første fighter henter attack
                int attack = f1.Attack();
                Console.WriteLine("Whiteknight attacks for {0}", attack);
                // Anden fighter skal forsvare sig
                f2.Defend(attack);
                Console.WriteLine("BlackKnight HP {0}", f2.DefenseLeft);
                // Anden fighter henter attack
                attack = f2.Attack();
                Console.WriteLine("BlackKnight attacks for {0}", attack);

                // Første fighter skal forsvare sig
                f1.Defend(attack);
                Console.WriteLine("Whiteknight HP {0}", f1.DefenseLeft);


            }
            if (f1.HasEscaped())
            {
                Console.WriteLine("WhiteKnight cowardly fled from combat");
            }
            else if (f2.HasEscaped())
            {
                Console.WriteLine("BlackKnight cowardly fled from combat");

            }
            else if (f1.DefenseLeft <= 0)
            {
                Console.WriteLine("WhiteKnight was slain in combat");
            }
            else if (f1.DefenseLeft <= 0)
            {
                Console.WriteLine("BlackKnight was slain in combat");
            }

            IFighter winner = null;

            // kampen er afsluttet
            if ((f1.DefenseLeft > 0) && (!f1.HasEscaped()))
            {
                winner = f1;
                Console.WriteLine("Whiteknight wins");
            }

            if ((f2.DefenseLeft > 0) && (!f2.HasEscaped()))
            {
                winner = f2;

                Console.WriteLine("Whiteknight wins");

            }

            // Hvis der returneres null, så har kampen været jævnbyrdig
            return winner;

        }
    }
}
