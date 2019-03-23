using System;
using SQLite;

namespace BridgeScoringHelper.Db
{
    public class Tournament
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime StartUTC { get; set; }
    }
}
