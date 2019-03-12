public class Contract {
	public int Level { get; set; }
    public Suit Suit { get; set; }
    public bool Doubled { get; set; }
    public bool ReDoubled { get; set; }
    public Direction Player { get; set; }
    public int Tricks { get; set; }
    public Card Lead { get; set; }

    public Contract() {
	}

	public Contract(int level, Suit suit, bool doubled, bool redoubled,
			Direction player, int tricks) {
		Level = level;
		Suit = suit;
		Doubled = doubled;
		ReDoubled = redoubled;
		Player = player;
		Tricks = tricks;
	}

	public int OverTricks() {
		return Tricks - (Level + 6);
	}

	public bool ContractMade() {
		return OverTricks() >= 0;
	}

	public bool IsSmallSlam() {
		return Level == 6;
	}

	public bool IsGrandSlam() {
		return Level == 7;
	}
}
