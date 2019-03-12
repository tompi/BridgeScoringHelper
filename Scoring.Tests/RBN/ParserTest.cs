using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Scoring.Tests.Score
{
    public class ParserTest
    {
        RBNArticle _article;

        public ParserTest()
        {
            var _parser = new RBNParser();

            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                                .Single(str => str.EndsWith("Test1.rbn"));
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                _article = _parser.Parse(reader);
            }
        }

        [Fact]
        public void testAuthorIsRichardPavelcek()
        {
            Assert.Equal("Richard Pavlicek", _article.Author);
        }

        [Fact]
        public void testContractIs5HXN()
        {
            Contract contract = null;
            foreach (RBNLine line in _article.Lines)
            {
                if (line.GetRBNLineType() == RBNLineType.ContractAndDeclarer)
                {
                    contract = ((RBNContractAndDeclarer)line).Contract;
                }
            }
            Assert.Equal(Direction.North, contract.Player);
            Assert.Equal(5, contract.Level);
            Assert.Equal(Suit.Hearts, contract.Suit);
            Assert.Equal(true, contract.Doubled);
            Assert.Equal(false, contract.ReDoubled);
        }

        [Fact]
        public void testAuction()
        {
            Auction auction = null;
            RBNHands hands = null;
            foreach (RBNLine line in _article.Lines)
            {
                if (line.GetRBNLineType() == RBNLineType.Auction)
                {
                    auction = ((RBNAuction)line).Auction;
                }
                else if (line.GetRBNLineType() == RBNLineType.Hands)
                {
                    hands = (RBNHands)line;
                }
            }
            Assert.Equal(Direction.West, auction.Dealer);
            Assert.Equal(Vulnerability.None, hands.Vulnerability);
            Assert.Equal(9, auction.Bids.Count);
            Assert.Equal(true, auction.Bids[0].Conventional);
            Assert.Equal(BidQuality.Good, auction.Bids[1].Quality);
            Assert.Equal(1, auction.Bids[3].Explanation);
            Assert.Equal(Suit.Hearts, auction.Bids[7].Suit);
            Assert.Equal(BidQuality.VeryPoor, auction.Bids[7].Quality);
            Assert.Equal(true, auction.Bids[8].Double);
            Assert.Equal(2, auction.Explanations.Count);

        }
    }
}
