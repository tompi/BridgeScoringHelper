using System.Text;
using Scoring.PBN.Game;

namespace Scoring.PBN.Mapping
{
    public static class PBNSupplementalMapper
    {

        /*
        public static PBNSupplemental GetPBNSupplementalFromStream(
                InputStream identification)
        {
            // TODO
            return null;
        }
        */

        public static void AppendSupplemental(StringBuilder pbn,
                PBNSupplemental supplemental)
        {
            if (supplemental == null)
            {
                return;
            }
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Competition,
                    supplemental.Competition);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.DealId, supplemental.DealId);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Description,
                    supplemental.Description);
            if (supplemental.FrenchMP)
            {
                PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.FrenchMP,
                        supplemental.FrenchMP);
            }
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Generator,
                    supplemental.Generator);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Hidden, supplemental.Hidden);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Room, supplemental.Room);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Termination,
                    supplemental.Termination);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Score, supplemental.Score);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.ScoreIMP,
                    supplemental.ScoreIMP);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.ScoreMP,
                    supplemental.ScoreMP);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.ScorePercentage,
                    supplemental.ScorePercentage);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.ScoreRubber,
                    supplemental.ScoreRubber);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.ScoreRubberHistory,
                    supplemental.ScoreRubberHistory);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.OptimumScore,
                    supplemental.OptimumScore);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.BidSystemEW,
                    supplemental.BidSystemEW);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.BidSystemNS,
                    supplemental.BidSystemNS);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.PairEW, supplemental.PairEW);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.PairNS, supplemental.PairNS);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.WestNA, supplemental.WestNA);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.NorthNA,
                    supplemental.NorthNA);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.EastNA, supplemental.EastNA);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.SouthNA,
                    supplemental.SouthNA);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.WestType,
                    supplemental.WestType);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.NorthType,
                    supplemental.NorthType);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.EastType,
                    supplemental.EastType);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.SouthType,
                    supplemental.SouthType);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.EventDate,
                    supplemental.EventDate);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.EventSponsor,
                    supplemental.EventSponsor);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.HomeTeam,
                    supplemental.HomeTeam);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Round, supplemental.Round);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Section,
                    supplemental.Section);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Stage, supplemental.Stage);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Table, supplemental.Table);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.VisitTeam,
                    supplemental.VisitTeam);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Time, supplemental.Time,
                    true);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.UTCDate,
                    supplemental.UTCDate);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.UTCTime,
                    supplemental.UTCTime, true);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.TimeControl,
                    supplemental.TimeControl);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.TimeCall,
                    supplemental.TimeCall);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.TimeCard,
                    supplemental.TimeCard);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Annotator,
                    supplemental.Annotator);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.AnnotatorNA,
                    supplemental.AnnotatorNA);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Application,
                    supplemental.Application);
            PBNTagMapper.AppendTag(pbn, PBNSupplemental.Tags.Mode, supplemental.Mode);
        }
    }
}