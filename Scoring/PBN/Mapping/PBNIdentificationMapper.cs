using System.Text;
using Scoring.Game;
using Scoring.PBN.Game;

namespace Scoring.PBN.Mapping
{
    public static class PBNIdentificationMapper
    {

        /*
        public static Identification GetIdentificationFromStream(
                InputStream identification) {
            // TODO
            return null;
        }
        */

        public static void AppendIdentification(StringBuilder pbn,
                PBNIdentification identification)
        {
            if (identification == null)
            {
                return;
            }
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Event,
                    identification.Event);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Site, identification.Site);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Date, identification.Date);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Board,
                    identification.Board);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.West, identification.West);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.North,
                    identification.North);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.East, identification.East);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.South,
                    identification.South);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Dealer,
                    identification.Dealer);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Vulnerable,
                    identification.Vulnerable);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Deal,
                    identification.Deal != null ? identification.Deal : new Deal());
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Scoring,
                    identification.Scoring);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Declarer,
                    identification.Declarer);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Contract,
                    identification.Contract);
            PBNTagMapper.AppendTag(pbn, PBNIdentification.Tags.Result,
                    identification.Result);
        }
    }
}