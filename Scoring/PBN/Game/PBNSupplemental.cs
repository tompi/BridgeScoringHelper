using System;

namespace Scoring.PBN.Game
{
    public class PBNSupplemental
    {
        /**
         * Describes the type of competition. Examples tag values are: "Cavendish",
         * "Chicago", "Individuals", "Pairs", "Rubber", "Teams".
         */
        public string Competition;

        /**
         * Identifies a deal by a unique value. No two PBN deals should have the
         * same tag value for DealId.
         */
        public string DealId;

        /**
         * The purpose of this tag is to give arbitrary game description. It can be
         * used when no other tag is suited.
         */
        public string Description;

        /**
         * This tag indicates if French scoring is used, default is 'No'.
         */
        public bool FrenchMP = false;

        /**
         * This tag indicates how the cards have been generated. It is intended for
         * bridge computer programs and especially hand generators. The tag value
         * may include the name of the program and possibly a seed value.
         */
        public string Generator;

        /**
         * This tag indicates the directions of the hands that should be hidden by a
         * viewer after the PBN game has been loaded. The idea is to reveal the
         * hands on user request, after the user has solved some task using only the
         * visible cards. The tag value is a sequence of characters representing the
         * directions to be hidden. The possible characters are: W (West), N
         * (North), E (East), and S (South). For example: [Hidden "WE"] means, that
         * initially the cards of E/W must be hidden.
         */
        public string Hidden;

        /**
         * This tag can be used in a teams bridge tournament. The only two possible
         * tag values are: "Open" and "Closed".
         */
        public string Room;

        /**
         * This takes a string that describes the reason for the conclusion of the
         * game. While the Result tag gives the result of the game, it does not
         * provide any extra information and so the Termination tag is defined for
         * this purpose. Examples are: "abandoned" abandoned game. "adjudication"
         * result due to third party adjudication process "death" losing player
         * called to greater things, one hopes "emergency" game concluded due to
         * unforeseen circumstances "normal" game terminated in a normal fashion
         * "rules infraction" administrative forfeit due to losing player's failure
         * to observe either the Laws of Bridge or the event regulations
         * "time forfeit" loss due to losing player's failure to meet time control
         * requirements "unterminated" game not terminated
         */
        public string Termination;

        /**
         * This tag gives the number of points of the game based on the trick score
         */
        public string Score;

        /**
         * This tag gives the score in International MatchPoints based on the
         * difference between score points
         */
        public string ScoreIMP;

        /**
         * This tag gives the MatchPoints based on the ranking of score points
         */
        public string ScoreMP;

        /**
         * This tag gives the percentage score.
         */
        public string ScorePercentage;

        /**
         * This tag gives the game's score for Rubber bridge or Chicago bridge
         * <non-negative integer>/<non-negative integer> where the integer before
         * "/" is the score above-the-line (bonus points or premium points), and the
         * integer after "/" is the score below-the-line (trick points)
         */
        public string ScoreRubber;

        /**
         * This tag gives the scores above-the-line (bonus points or premium points)
         * and the scores below-the-line (trick points) for both sides at the
         * beginning of a deal in a rubber match. The syntax of the tag is:
         * 
         * [ScoreRubberHistory "NS <HistoryScore> EW <HistoryScore>"]
         * 
         * Each <HistoryScore> consists of 3, 4 or 5 score units (being non-negative
         * integers), depending on the number of finished rubber games in the
         * current rubber. The syntax of <HistoryScore> is:
         * 
         * <above_previous> <above_current>/<below-1> <below-2> <below-3>
         * 
         * where <above_previous> all above-the-line points in previous rubbers (if
         * any) <above_current> all above-the-line points in the current rubber
         * <below-n> the below-the-line points, either at begin of the current deal
         * in game 'n' or at the end of finished game 'n'
         * 
         * During the first game, the values for <below-2> and <below-3> are
         * omitted. During the second game, the values for <below-3> are omitted.
         * The slash "/" separates the scores above-the-line from the scores
         * below-the-line just as in tag ScoreRubber. Note that the number of games
         * won defines the vulnerability. This must be consistent with the
         * Vulnerable tag (if present).
         */
        public string ScoreRubberHistory;

        /**
         * This tag gives the optimum number of points of a deal based on the trick
         * score of the optimum result, with open cards (double dummy). This result
         * is computed by comparing all possible (doubled) contracts, including all
         * passes. The number of tricks for a certain contract - and hence the
         * corresponding score - may be derived from the OptimumResultTable. The
         * optimum score can be given in 4 possible formats: "EW <score>" score of
         * EW "NS <score>" score of NS "EW <score> NS <score>" score of EW resp. NS
         * "NS <score> EW <score>" score of NS resp. EW where <score> is the integer
         * number of points. Note that the NS <score> is opposite to the EW <score>.
         * For example, if NS can make 3NT with 10 tricks and 5D with 11 tricks with
         * scores of 630 respectively 600 and EW can play 5C doubled for a score of
         * -500 then NS's optimum score is 600.
         */
        public string OptimumScore;

        /*
         * These tags describe the bidding system for each side
         */
        public string BidSystemEW;
        /*
         * These tags describe the bidding system for each side
         */
        public string BidSystemNS;
        /**
         * These tags describe the partnerships East/West and North/South. Suitable
         * tag values are the names of the players, when it is unknown who is
         * sitting North, East, South, West. Other suitable tag values are the
         * values of the PairId_NS and PairId_EW columns from the ScoreTables, or
         * the values of the PairId column from the TotalScoreTable
         */
        public string PairEW;
        /**
         * These tags describe the partnerships East/West and North/South. Suitable
         * tag values are the names of the players, when it is unknown who is
         * sitting North, East, South, West. Other suitable tag values are the
         * values of the PairId_NS and PairId_EW columns from the ScoreTables, or
         * the values of the PairId column from the TotalScoreTable
         */
        public string PairNS;
        /**
         * These tags are the e-mail or network addresses of the players.
         */
        public string WestNA;
        /**
         * These tags are the e-mail or network addresses of the players.
         */
        public string NorthNA;
        /**
         * These tags are the e-mail or network addresses of the players.
         */
        public string EastNA;
        /**
         * These tags are the e-mail or network addresses of the players.
         */
        public string SouthNA;
        /**
         * These tags describe the player types. Two typical example tag values are:
         * "human" a human player "program" an algorithmic (computer) player
         */
        public string WestType;
        /**
         * These tags describe the player types. Two typical example tag values are:
         * "human" a human player "program" an algorithmic (computer) player
         */
        public string NorthType;
        /**
         * These tags describe the player types. Two typical example tag values are:
         * "human" a human player "program" an algorithmic (computer) player
         */
        public string EastType;
        /**
         * These tags describe the player types. Two typical example tag values are:
         * "human" a human player "program" an algorithmic (computer) player
         */
        public string SouthType;
        /**
         * This tag describes the starting date of the event. The used format is the
         * same as for the DateTime tag.
         */
        public DateTime EventDate;
        /**
         * This tag gives the name of the sponsor of the event.
         */
        public string EventSponsor;
        /**
         * This tag gives the name of the home team.
         */
        public string HomeTeam;
        /**
         * The Round tag value gives the playing round for the game. The round
         * indicator consists of letter characters, digit characters and the
         * underscore. Some organizers employ unusual round designations and have
         * multipart playing rounds and sometimes even have conditional rounds. In
         * these cases, a multipart round identifier can be made from a sequence of
         * round indicators separated by periods. The leftmost indicator represents
         * the most significant playing round, and succeeding indicators represent
         * playing rounds in descending hierarchical order.
         */
        public string Round;
        /**
         * This tag is used for the playing section of a tournament. Examples are
         * "Open", "Ladies" or "Reserve".
         */
        public string Section;
        /**
         * This tag is used for the stage of a multistage event. Examples are
         * "Preliminary" or "Semifinal".
         */
        public string Stage;
        /**
         * This tag identifies the table in a tournament. The tag value will
         * normally be a positive integer.
         */
        public string Table;
        /**
         * This tag gives the name of the visiting team.
         */
        public string VisitTeam;
        /**
         * This uses a time-of-day value in the form "HH:MM:SS"; similar to the Date
         * tag except that it denotes the local clock time (hours, minutes, and
         * seconds) of the start of the game. Note that colons, not periods, are
         * used for field separators for the Time tag value. The value is taken from
         * the local time corresponding to the location given in the Site tag pair.
         */
        public DateTime Time;
        /**
         * This tag is similar to the DateTime tag except that the date is given
         * according to the Universal Coordinated Time standard.
         */
        public DateTime UTCDate;
        /**
         * This tag is similar to the Time tag except that the time is given
         * according to the Universal Coordinated Time standard.
         */
        public DateTime UTCTime;
        /**
         * This tag indicates how many games must be played within a certain time
         * limit. The tag value has the syntax: "<NrGames>/<NrMinutes>" This means
         * that the number of games, given by <NrGames>, must be finished before a
         * time in minutes, given by <NrMinutes>. For example: [TimeControl "4/30"]
         * means, that 4 games must be finished in half an hour. When there is no
         * time limit at all, then use "" as tag value.
         */
        public string TimeControl;
        /**
         * This tag is used to limit the time for making a single call. The tag
         * value is defined in number of seconds. This tag can typically be applied
         * for computer programs.
         */
        public string TimeCall;
        /**
         * This tag is used to limit the time for playing a single card. The tag
         * value is defined in number of seconds. This tag can typically be applied
         * for computer programs.
         */
        public string TimeCard;
        /**
         * This tag identifies the annotator or annotators of the game.
         */
        public string Annotator;
        /**
         * This tag is the e-mail or network addresses of the annotator.
         */
        public string AnnotatorNA;
        /**
         * The intention of this tag is to fill in a particular application
         * (especially a computer program). It can be used as an anchor for
         * Application specific data, that are added immediately after this tag in
         * comments.
         */
        public string Application;
        /**
         * This tag gives the playing mode of the game. Examples are: "EM"
         * electronic mail "IBS" Internet Bridge Server "OKB" OK Bridge "TABLE"
         * normal table "TC" general telecommunication
         */
        public string Mode;

        public static class Tags
        {
            public static readonly string Competition = "Competition";
            public static readonly string DealId = "DealId";
            public static readonly string Description = "Description";
            public static readonly string FrenchMP = "FrenchMP";
            public static readonly string Generator = "Generator";
            public static readonly string Hidden = "Hidden";
            public static readonly string Room = "Room";
            public static readonly string Termination = "Termination";
            public static readonly string Score = "Score";
            public static readonly string ScoreIMP = "ScoreIMP";
            public static readonly string ScoreMP = "ScoreMP";
            public static readonly string ScorePercentage = "ScorePercentage";
            public static readonly string ScoreRubber = "ScoreRubber";
            public static readonly string ScoreRubberHistory = "ScoreRubberHistory";
            public static readonly string OptimumScore = "OptimumScore";
            public static readonly string BidSystemEW = "BidSystemEW";
            public static readonly string BidSystemNS = "BidSystemNS";
            public static readonly string PairEW = "PairEW";
            public static readonly string PairNS = "PairNS";
            public static readonly string WestNA = "WestNA";
            public static readonly string NorthNA = "NorthNA";
            public static readonly string EastNA = "EastNA";
            public static readonly string SouthNA = "SouthNA";
            public static readonly string WestType = "WestType";
            public static readonly string NorthType = "NorthType";
            public static readonly string EastType = "EastType";
            public static readonly string SouthType = "SouthType";
            public static readonly string EventDate = "EventDate";
            public static readonly string EventSponsor = "EventSponsor";
            public static readonly string HomeTeam = "HomeTeam";
            public static readonly string Round = "Round";
            public static readonly string Section = "Section";
            public static readonly string Stage = "Stage";
            public static readonly string Table = "Table";
            public static readonly string VisitTeam = "VisitTeam";
            public static readonly string Time = "Time";
            public static readonly string UTCDate = "UTCDate";
            public static readonly string UTCTime = "UTCTime";
            public static readonly string TimeControl = "TimeControl";
            public static readonly string TimeCall = "TimeCall";
            public static readonly string TimeCard = "TimeCard";
            public static readonly string Annotator = "Annotator";
            public static readonly string AnnotatorNA = "AnnotatorNA";
            public static readonly string Application = "Application";
            public static readonly string Mode = "Mode";

        }
    }
}