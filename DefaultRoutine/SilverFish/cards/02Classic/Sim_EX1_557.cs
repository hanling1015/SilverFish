using HREngine.Bots;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_557 : SimTemplate //natpagle
	{

//    zu beginn eures zuges besteht eine chance von 50%, dass ihr eine zusätzliche karte zieht.
        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.drawACard(CardDB.CardName.unknown, turnStartOfOwner);
            }
        }

	}
}