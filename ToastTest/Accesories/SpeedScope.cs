using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToastTest.Accesories
{
	public class SpeedScope : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The best scope that you will ever see");
			DisplayName.SetDefault("Speed Scope");
		}

		public override void SetDefaults()
		{
			Item.value = 1000;
			Item.width = 20;
			Item.height = 20;
			Item.rare = 1;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed += 1f;
			player.accRunSpeed += 1f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}