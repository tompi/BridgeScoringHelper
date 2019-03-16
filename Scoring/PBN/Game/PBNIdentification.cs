using System;
using Scoring.Game;

namespace Scoring.PBN.Game
{
    public class PBNIdentification
    {

        public PBNIdentification()
        {
            Board = -1;
        }

        /**
         * The name of the tournament or match
         */
        public string Event;

        /**
         * the location of the event
         */
        public string Site;

        /**
         * The starting date of the game
         */
        public DateTime Date;

        /**
         * The board number
         */
        public int Board;

        /**
         * The west player
         */
        public string West;

        /**
         * The north player
         */
        public string North;

        /**
         * The east player
         */
        public string East;

        /**
         * The south player
         */
        public string South;

        /**
         * The dealer
         */
        public Direction Dealer;

        /**
         * The situation of vulnerability
         */
        public Vulnerability Vulnerable;

        /**
         * The dealt cards
         */
        public Deal Deal;

        /**
         * The scoring method
         */
        public string Scoring;

        /**
         * The declarer of the contract
         */
        public Direction Declarer;

        /**
         * The contract
         */
        public Contract Contract;

        /**
         * The number of tricks taken by declarer
         */
        public int Result;

        public static class Tags
        {
            public static readonly string Event = "Event";
            public static readonly string Site = "Site";
            public static readonly string Date = "Date";
            public static readonly string Board = "Board";
            public static readonly string West = "West";
            public static readonly string North = "North";
            public static readonly string East = "East";
            public static readonly string South = "South";
            public static readonly string Dealer = "Dealer";
            public static readonly string Vulnerable = "Vulnerable";
            public static readonly string Deal = "Deal";
            public static readonly string Scoring = "Scoring";
            public static readonly string Declarer = "Declarer";
            public static readonly string Contract = "Contract";
            public static readonly string Result = "Result";
        }

        /*
         * private static SimpleDateFormat _simpleDateFormat = new
         * SimpleDateFormat( "yyyy.MM.dd");
         * 
         * private DateTime GetDateFromstring(string value) throws ParseException {
         * return _simpleDateFormat.parse(value); }
         * 
         * private string GetstringFromDate(DateTime value) { return
         * _simpleDateFormat.format(value); }
         */
    }
}