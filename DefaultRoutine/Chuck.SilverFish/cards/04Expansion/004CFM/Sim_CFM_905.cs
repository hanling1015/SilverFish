using System.Collections.Generic;
using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._004CFM
{
	class Sim_CFM_905 : SimTemplate //* Small-Time Recruits
	{
		// Draw three 1-Cost minions from your deck.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                CardDB.Card c;
                int count = 0;
                foreach (var cid in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cid.Key);
                    if (c.cost == 1)
                    {
                        for (int i = 0; i < cid.Value; i++)
                        {
                            p.drawACard(c.name, true);
                            count++;
                            if (count > 2) break;
                        }
						if (count > 2) break;
                    }
                }
            }
        }
    }
}