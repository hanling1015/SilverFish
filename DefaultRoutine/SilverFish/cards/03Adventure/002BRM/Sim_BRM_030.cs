using HREngine.Bots;

namespace SilverFish.cards._03Adventure._002BRM
{
	class Sim_BRM_030 : SimTemplate //* Nefarian
	{
		// Battlecry: Add 2 random spells to your hand (from your opponent's class).
		
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            TAG_CLASS opponentHeroClass = (m.own) ? p.enemyHeroStartClass : p.ownHeroStartClass;

            switch (opponentHeroClass)
            {
                case TAG_CLASS.WARRIOR:
					p.drawACard(CardDB.CardName.shieldblock, m.own, true);
					p.drawACard(CardDB.CardName.shieldblock, m.own, true);
					break;
                case TAG_CLASS.WARLOCK:
					p.drawACard(CardDB.CardName.baneofdoom, m.own, true);
					p.drawACard(CardDB.CardName.baneofdoom, m.own, true);
                    break;
                case TAG_CLASS.ROGUE:
					p.drawACard(CardDB.CardName.sprint, m.own, true);
					p.drawACard(CardDB.CardName.sprint, m.own, true);
					break;
                case TAG_CLASS.SHAMAN:
					p.drawACard(CardDB.CardName.farsight, m.own, true);
					p.drawACard(CardDB.CardName.farsight, m.own, true);
					break;
                case TAG_CLASS.PRIEST:
					p.drawACard(CardDB.CardName.thoughtsteal, m.own, true);
					p.drawACard(CardDB.CardName.thoughtsteal, m.own, true);
					break;
                case TAG_CLASS.PALADIN:
					p.drawACard(CardDB.CardName.hammerofwrath, m.own, true);
					p.drawACard(CardDB.CardName.hammerofwrath, m.own, true);
					break;
                case TAG_CLASS.MAGE:
					p.drawACard(CardDB.CardName.frostnova, m.own, true);
					p.drawACard(CardDB.CardName.frostnova, m.own, true);
					break;
                case TAG_CLASS.HUNTER:
					p.drawACard(CardDB.CardName.cobrashot, m.own, true);
					p.drawACard(CardDB.CardName.cobrashot, m.own, true);
					break;
                case TAG_CLASS.DRUID:
					p.drawACard(CardDB.CardName.wildgrowth, m.own, true);
					p.drawACard(CardDB.CardName.wildgrowth, m.own, true);
                    break;
				//default:
			}
		}
	}
}