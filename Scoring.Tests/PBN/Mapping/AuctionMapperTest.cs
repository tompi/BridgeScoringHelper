using System.Text;
using Scoring.Game;
using Scoring.PBN.Game;
using Scoring.PBN.Mapping;
using Xunit;

namespace Scoring.Tests.PBN.Mapping
{

    public class AuctionMapperTest
    {
        PBNAuction _auction;

        public AuctionMapperTest()
        {
            _auction = new PBNAuction();
            _auction.Auction = new Auction(Direction.North);
            Bid b = new Bid();
            b.Pass = true;
            _auction.Auction.Bids.Add(b);
            b = new Bid();
            b.Level = 2;
            b.Suit = Suit.Hearts;
            b.Explanation = 1;
            _auction.Auction.Bids.Add(b);
            b = new Bid();
            b.Pass = true;
            _auction.Auction.Bids.Add(b);
            b = new Bid();
            b.Level = 2;
            b.Suit = Suit.Notrump;
            b.Explanation = 2;
            _auction.Auction.Bids.Add(b);
            b = new Bid();
            b.Pass = true;
            _auction.Auction.Bids.Add(b);
            b = new Bid();
            b.Level = 3;
            b.Suit = Suit.Diamonds;
            b.Explanation = 3;
            _auction.Auction.Bids.Add(b);
            b = new Bid();
            b.Pass = true;
            _auction.Auction.Bids.Add(b);
            b = new Bid();
            b.Level = 4;
            b.Suit = Suit.Hearts;
            _auction.Auction.Bids.Add(b);
            b = new Bid();
            b.Pass = true;
            _auction.Auction.Bids.Add(b);
            b = new Bid();
            b.Pass = true;
            _auction.Auction.Bids.Add(b);
            b = new Bid();
            b.Pass = true;
            _auction.Auction.Bids.Add(b);
            _auction.Auction.Explanations.Add("Weak");
            _auction.Auction.Explanations.Add("Asking");
            _auction.Auction.Explanations.Add("Strong with diamonds");
        }

        [Fact]
        public void testAuctionMapping()
        {
            StringBuilder sb = new StringBuilder();
            PBNAuctionMapper.AppendAuction(sb, _auction);
            var result = sb.ToString();

            Assert.Equal("[Auction \"N\"]\n" + "Pass 2H =1= Pass 2NT =2=\n"
                    + "Pass 3D =3= Pass 4H\n" + "Pass Pass Pass\n"
                    + "[Note \"1:Weak\"]\n" + "[Note \"2:Asking\"]\n"
                    + "[Note \"3:Strong with diamonds\"]\n", result);
        }

    }
}