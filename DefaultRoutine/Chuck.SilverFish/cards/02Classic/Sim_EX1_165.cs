using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._02Classic
{
    class Sim_EX1_165 : SimTemplate  //* Druid of the Claw
    {
        // Choose One - Charge; or +2 Health and Taunt.

        CardDB.Card cat = CardDB.Instance.getCardDataFromID(CardIdEnum.EX1_165t1);
        CardDB.Card bear = CardDB.Instance.getCardDataFromID(CardIdEnum.EX1_165t2);
        CardDB.Card bearcat = CardDB.Instance.getCardDataFromID(CardIdEnum.OG_044a);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.ownFandralStaghelm > 0)
            {
                p.minionTransform(own, bearcat);
            }
            else
            {
                if (choice == 1)
                {
                    p.minionTransform(own, cat);
                }
                if (choice == 2)
                {
                    p.minionTransform(own, bear);
                }
            }
		}
	}
}