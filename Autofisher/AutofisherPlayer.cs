using Terraria;
using Terraria.ModLoader;

namespace Autofisher
{
    class AutofisherPlayer : ModPlayer
    {
        public static bool UseItemNextUpdate = false;

        public override void PreUpdate()
        {
            if (UseItemNextUpdate)
            {
                if (player.HeldItem.fishingPole > 0)
                {
                    UseHeldItem();
                }

                UseItemNextUpdate = false;
            }

            base.PreUpdate();
        }

        public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
        {
            if (!junk)
                UseItemNextUpdate = true;

            base.CatchFish(fishingRod, bait, power, liquidType, poolSize, worldLayer, questFish, ref caughtType, ref junk);
        }

        private void UseHeldItem()
        {
            player.controlUseItem = true;
            player.ItemCheck(Main.myPlayer);
        }
    }
}
