using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToastTest.Items
{
	public class TestingSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Very Light");
			DisplayName.SetDefault("Feather Sword");
		}

		public override void SetDefaults()
		{
			Item.damage = 170;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = 1;
			Item.knockBack = 15;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
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