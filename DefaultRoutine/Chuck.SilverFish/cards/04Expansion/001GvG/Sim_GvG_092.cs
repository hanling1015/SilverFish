using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._001GvG
{
    class Sim_GVG_092 : SimTemplate //Gnomish Experimenter
    {

        //  Battlecry: Draw a card. If it's a minion, transform it into a Chicken. 

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardName.unknown, own.own);
        }

    }

}