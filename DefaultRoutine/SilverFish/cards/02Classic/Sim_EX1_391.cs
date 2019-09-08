using HREngine.Bots;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_391 : SimTemplate //slam
	{

//    fügt einem diener $2 schaden zu. zieht eine karte, wenn er überlebt.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            if (target.HealthPoints > dmg || target.immune || target.divineshild)
            {
                //this.owncarddraw++;
                p.drawACard(CardDB.CardName.unknown, ownplay);
            }
            p.minionGetDamageOrHeal(target, dmg);
            
		}

	}
}