using System;
using Xamarin.Forms;

namespace BridgeScoringHelper.Style
{
    public static class Colors
    {
        public static class Suits
        {
            public static Color Spade = Color.FromHex("3745ff");
            public static Color Heart = Color.FromHex("d72b21");
            public static Color Diamond = Color.FromHex("ef6c1a");
            public static Color Club = Color.FromHex("28552a");
            public static Color NoTrump = Color.FromHex("000000");

            public static Color SpadeBackground = Color.FromHex("c3cceb");
            public static Color HeartBackground = Color.FromHex("ffe2e8");
            public static Color DiamondBackground = Color.FromHex("ffe5d0");
            public static Color ClubBackground = Color.FromHex("d4ded5");
            public static Color NoTrumpBackground = Color.FromHex("cfcfca");
        }

        public static class Bidding
        {
            public static Color Pass = Color.FromHex("00923C");
            public static Color PassSelected = Color.FromHex("00bb4d");
            public static Color Doubled = Color.FromHex("bf0c08");
            public static Color DoubledSelected = Color.FromHex("ff504c");
            public static Color ReDoubled = Color.FromHex("0e1a8a");
            public static Color ReDoubledSelected = Color.FromHex("1d1bff");

            public static Color NoTrump = Color.FromHex("000000");
            public static Color NoTrumpBackground = Color.FromHex("cfcfca");
        }
    }
}
