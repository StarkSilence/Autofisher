using Terraria;
using Terraria.ModLoader;

namespace Autofisher
{
    class AutofisherItem : GlobalItem
    {
        public override void CaughtFishStack(int type, ref int stack)
        {
            AutofisherPlayer.UseItemNextUpdate = true;

            base.CaughtFishStack(type, ref stack);
        }
    }
}
