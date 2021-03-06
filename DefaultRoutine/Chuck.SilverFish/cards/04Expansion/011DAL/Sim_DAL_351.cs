namespace Chuck.SilverFish.cards._04Expansion._011DAL
{
    /// <summary>
    /// Blessing of the Ancients
    /// 远古祝福
	///</summary>
    class Sim_DAL_351 : TwinSpell
    {
        /// <summary>
        /// Twinspell Give your minions +1/+1.
        /// 双生法术 使你的所有随从获得+1/+1。
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetBuffed(ownplay, 1, 1);

            TriggerTwinSpell(p, ownplay);
        }
    }

    class Sim_DAL_351ts : Sim_DAL_351
    {

    }
}