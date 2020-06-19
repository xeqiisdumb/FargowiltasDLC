using Terraria.ID;
using Terraria.ModLoader;
using FargowiltasSouls;
using Fargowiltas;
using FargowiltasDLC;

namespace FargowiltasDLC.Items.Weapons
{
	public class GrabGun : ModItem
	{

	        public override string Texture => "Terraria/Item_1156";
	    
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("GrabGun"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("You think you're safe?");
		}

		public override void SetDefaults() 
		{
		        item.CloneDefaults(ItemID.PiranhaGun);
			item.damage = 600;
			item.knockBack = 0;
			item.value = 100000;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("Grab");
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PiranhaGun, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
