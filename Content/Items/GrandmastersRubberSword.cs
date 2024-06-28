using RandomStuffByMasi.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace RandomStuffByMasi.Content.Items
{
    public class GrandmastersRubberSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3; // How many items need for research in Journey Mode
        }

        public override void SetDefaults()
        {
            // Visual properties
            Item.width = 40; // Width of an item sprite
            Item.height = 36; // Height of an item sprite
            Item.scale = 1.8f;

            // Combat properties
            Item.damage = 44;
            Item.DamageType = DamageClass.Melee; // What type of damage item is deals, Melee, Ranged, Magic, Summon, Generic (takes bonuses from all damage multipliers), Default (doesn't take bonuses from any damage multipliers)
            // useTime and useAnimation often use the same value, but we'll see examples where they don't use the same values
            Item.useTime = 12; // How long the swing lasts in ticks (60 ticks = 1 second)
            Item.useAnimation = 12; // How long the swing animation lasts in ticks (60 ticks = 1 second)
            Item.knockBack = 10f; // How far the sword punches enemies, 20 is maximal value
            Item.autoReuse = true; // Can the item auto swing by holding the attack button

            // Other properties
            Item.maxStack = 1; // How many items can be in one inventory slot
            Item.value = 3000; // Item sell price in copper coins
            Item.rare = ItemRarityID.Pink; // The color of item's name in game. Check https://terraria.wiki.gg/wiki/Rarity
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<RubberSword>(1);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddIngredient(ItemID.CursedFlame, 25);
            recipe.AddTile(TileID.MythrilAnvil); // Crafting station we need for craft, WorkBenches, Anvils etc. You can find them here - https://terraria.wiki.gg/wiki/Tile_IDs
            recipe.Register();
        }
    }
}
