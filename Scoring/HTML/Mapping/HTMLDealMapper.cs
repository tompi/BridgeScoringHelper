using System.Collections.Generic;
using System.Text;

public static class HTMLDealMapper
{

    public static void AppendCSSIncludes(StringBuilder html)
    {
        html.Append("<style type=\"text/css\">\n" + DealCSS + "</style>");
    }

    public static void AppendDeal(StringBuilder html, Deal deal,
            Direction dealer, Vulnerability vulnerability)
    {
        if (deal == null)
        {
            return;
        }
        html.Append("<div class=\"diagram\">");
        html.Append("<div class=\"header\">");
        html.Append("<div>Dealer: "
                + HTMLDirectionMapper.GetstringFromDirection(dealer) + "</div>");
        html.Append("<div>Vuln: "
                + HTMLVulnerabilityMapper.GetstringFromVulnerability(vulnerability)
                + "</div>");
        html.Append("</div>");

        AppendHand(html, deal.North, "north", "North");
        AppendHand(html, deal.West, "west", "West");
        AppendHand(html, deal.East, "east", "East");
        AppendHand(html, deal.South, "south", "South");

        html.Append("</div>");

    }

    private static void AppendHand(StringBuilder html, Hand hand,
            string cssClass, string handName)
    {
        html.Append("<div class=\"hand " + cssClass + "\">");
        html.Append("<div class=\"seatname\">" + handName + "</div>");

        AppendSuit(html, Suit.Spades, hand);
        AppendSuit(html, Suit.Hearts, hand);
        AppendSuit(html, Suit.Diamonds, hand);
        AppendSuit(html, Suit.Clubs, hand);

        html.Append("</div>");
    }

    private static void AppendSuit(StringBuilder html, Suit suit, Hand hand)
    {
        html.Append("<div class=\"holding\">");
        html.Append(HTMLSuitMapper.GetstringFromSuit(suit));

        if (hand != null)
        {
            List<Card> cards = hand.GetCardsWithinSuit(suit);
            if (cards != null)
            {
                foreach (Card c in cards)
                {
                    html.Append(' ');
                    html.Append(PBNDenominationMapper
                            .GetCharFromDenomination(c.Denomination));
                }
            }
        }
        html.Append("</div>");
    }

    private static string DealCSS = ".diagram .header {\n"
            + "    font-size: smaller;\n" + "    margin-left: 0.25em;\n"
            + "    margin-right: 0.25em;\n" + "    margin-bottom: 0;\n"
            + "    margin-top: auto;\n" + "    padding: 0.25em;\n"
            + "    border: 0.1em outset;\n" + "    width: 6em;\n"
            + "    float: left;\n" + "    background: #FFFFFF;\n" + "}\n" +

            ".diagram {\n" + "    width: 23em;\n" + "}\n" +

            ".diagram  .hand {\n" + "    width: 8em;\n" + "}\n" +

            ".diagram  .south , .diagram  .north {\n"
            + "    margin-left: 7em; \n" + "}\n" +

            ".diagram .north {\n" + "    padding-bottom: 1ex;\n" + "}\n" +

            ".diagram  .south {\n" + "    clear: both;\n"
            + "    padding-top: 1ex;\n" + "}\n" +

            ".diagram  .west {\n" + "    float: left;\n" + "    clear: left;\n"
            + "}\n" +

            ".diagram  .east {\n" + "    float:right;\n" + "}\n" +

            ".red {\n" + "    color: red;\n" + "}\n" +

            ".hand .seatname {\n" + "    margin-left: 1em;\n"
            + "    font-size: smaller;\n" + "    font-style: italic;\n" + "}\n";
}
