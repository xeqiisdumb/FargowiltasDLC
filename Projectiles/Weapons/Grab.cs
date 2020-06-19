using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using FargowiltasDLC;

namespace FargowiltasDLC.Projectiles.Weapons
{
	public class Grab : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grab");
		}

		public override void SetDefaults()
	        {
		    projectile.CloneDefaults(ProjectileID.MechanicalPiranha);
		    projectile.width = 61;
		    projectile.height = 54;
		}

		// Additional hooks/methods here.
	}
}
