using HREngine.Bots;

namespace SilverFish.cards._01Basic._02Hunter
{
	class Sim_NEW1_031 : SimTemplate //* animalcompanion
	{
        //Summon a random Beast Companion.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_032);//misha
        
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos = (ownplay)?  p.ownMinions.Count : p.enemyMinions.Count;
            p.CallKid(kid, pos, ownplay, false);
		}

	}
}