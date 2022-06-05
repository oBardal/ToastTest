using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToastTest.Items
{
	public class WoodStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Cheap and gooood");
			DisplayName.SetDefault("Wood Staff");
			Item.staff[Item.type] = true;
		}

		public override void SetDefaults()
		{
			Item.damage = 50;
			Item.mana = 2;
			Item.DamageType = DamageClass.Magic;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.knockBack = 7;
			Item.value = 10000;
			Item.rare = 1;
			Item.UseSound = SoundID.Item8;
			Item.autoReuse = false;
			Item.shoot = 123;
			Item.shootSpeed = 6f;
			Item.noMelee = true;
		}


		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}