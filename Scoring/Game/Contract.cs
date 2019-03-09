public class Contract {
	public int Level { get; }
    public Suit Suit { get; }
    public bool Doubled { get; }
    public bool ReDoubled { get; }
    public Direction Player { get; }
    public int Tricks { get; }
    public Card Lead { get; }

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
