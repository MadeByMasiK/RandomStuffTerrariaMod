using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace RandomStuffByMasi.Content.Items.Materials
{
	public class Rubber : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100; // How many items need for research in Journey Mode
        }

        public override void SetDefaults()
        {
            Item.width = 22; // Width of an item sprite
            Item.height = 20; // Height of an item sprite
            Item.maxStack = 9999; // How many items can be in one inventory slot
            Item.value = 30; // Item sell price in copper coins
            Item.rare = ItemRarityID.White; // The color of item's name in game. Check https://terraria.wiki.gg/wiki/Rarity
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Gel, 5);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.Anvils); // Crafting station we need for craft, WorkBenches, Anvils etc. You can find them here - https://terraria.wiki.gg/wiki/Tile_IDs
            recipe.Register();
        }
    }
}