namespace Chuck.SilverFish.cards._02Classic._06Rogue
{
    class Sim_NEW1_014 : SimTemplate //* Master of Disguise
	{
        // Battlecry: Give a friendly minion Stealth until your next turn.

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null)
            {
                target.stealth = true;
                target.conceal = true;
            }
		}
	}
}