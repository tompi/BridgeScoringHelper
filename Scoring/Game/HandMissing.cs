using System;

public static class HandMissing {

	public static Hand GetHandMissing(Hand hand1, Hand hand2, Hand hand3) {
		if (hand1 == null || hand2 == null || hand3 == null) {
			return null;
		}
		if (!hand1.IsComplete() || !hand2.IsComplete() || !hand3.IsComplete()) {
			return null;
		}
		Hand missingHand = new Hand();
		foreach (Suit s in Enum.GetValues(typeof(Suit))) {
			foreach (Denomination d in Enum.GetValues(typeof(Denomination))) {
				if (d != Denomination.Small && d != Denomination.Unknown) {
					Card c = new Card(s, d);
					if (!hand1.Contains(c) && !hand2.Contains(c)
							&& !hand3.Contains(c)) {
						missingHand.Add(c);
					}
				}
			}
		}
		return missingHand;
	}
}
