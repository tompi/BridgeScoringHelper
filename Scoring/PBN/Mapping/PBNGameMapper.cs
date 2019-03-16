using System.Text;
using Scoring.Game;
using Scoring.PBN.Game;

namespace Scoring.PBN.Mapping
{
    public static class PBNGameMapper
    {

        /*
        public static Game GetGameFromStream(InputStream identification) {
            // TODO
            return null;
        }
        */

        public static void AppendGame(StringBuilder pbn, PBNGame game)
        {
            if (game == null)
            {
                return;
            }
            // Each game should start with empty line:
            pbn.Append('\n');
            PBNIdentificationMapper.AppendIdentification(pbn, game.Identification);
            if (game.Auction == null)
            {
                game.Auction = new PBNAuction
                {
                    Auction = new Auction(
                        game.Identification.Dealer)
                };
            }
            PBNAuctionMapper.AppendAuction(pbn, game.Auction);
            // TODO: PlayMapper
            PBNSupplementalMapper.AppendSupplemental(pbn, game.Supplemental);
        }
    }
}