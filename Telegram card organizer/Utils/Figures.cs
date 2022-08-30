using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram_card_organizer.Utils
{
    #region Figures

    public static class Figures
    {
        public static string[] List => GenerateFigures(); 

        private static string[] GenerateFigures()
        {
            List<string> cards = new List<string>(678);

            for (int i = 0; i <= 29; i++)
                cards.Add($"FWC {i}");

            string[] teams = { "QAT", "ECU", "SEN", "NED", "ENG", "IRN", "USA", "WAL",
                           "ARG", "KSA", "MEX", "POL", "FRA", "AUS", "DEN", "TUN",
                           "ESP", "CRC", "GER", "JPN", "BEL", "CAN", "MAR", "CRO",
                           "BRA", "SRB", "SUI", "CMR", "POR", "GHA", "URU", "KOR" };

            foreach (var team in teams)
            {
                for (int i = 1; i <= 20; i++)
                    cards.Add($"{team} {i}");
            }

            for (int i = 1; i <= 8; i++)
                cards.Add($"C{i}");

            return cards.ToArray();
        }
    }

    #endregion
}
