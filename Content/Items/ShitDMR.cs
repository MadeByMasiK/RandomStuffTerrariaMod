using RandomStuffByMasi.Content.Items.Materials;
using RandomStuffByMasi.Content.Items.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace RandomStuffByMasi.Content.Items
{
    public class ShitDMR : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3; // How many items need for research in Journey Mode
        }

        public override void SetDefaults()
        {
            // Visual properties
            Item.width = 56; // Width of an item sprite
            Item.height = 18; // Height of an item sprite

            // Combat properties
            Item.damage = 60;
            Item.DamageType = DamageClass.Ranged; // What type of damage item is deals, Melee, Ranged, Magic, Summon, Generic (takes bonuses from all damage multipliers), Default (doesn't take bonuses from any damage multipliers)
            // useTime and useAnimation often use the same value, but we'll see examples where they don't use the same values
            Item.useTime = 15; // How long the swing lasts in ticks (60 ticks = 1 second)
            Item.useAnimation = 15; // How long the swing animation lasts in ticks (60 ticks = 1 second)
            Item.knockBack = 9f; // How far the sword punches enemies, 20 is maximal value
            Item.autoReuse = false; // Can the item auto swing by holding the attack button

            // Gun properties
            Item.noMelee = true;
            Item.shoot = ModContent.ProjectileType<ShitSniperProjectile>();
            Item.shootSpeed = 16f;

            // Other properties
            Item.maxStack = 1; // How many items can be in one inventory slot
            Item.value = 60; // Item sell price in copper coins
            Item.rare = ItemRarityID.White; // The color of item's name in game. Check https://terraria.wiki.gg/wiki/Rarity
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item16;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<ShitSniper>(1);
            recipe.AddIngredient(ItemID.WhoopieCushion, 5);
            recipe.AddIngredient(ItemID.StoneBlock, 150);
            recipe.AddTile(TileID.Anvils); // Crafting station we need for craft, WorkBenches, Anvils etc. You can find them here - https://terraria.wiki.gg/wiki/Tile_IDs
            recipe.Register();
        }
    }
}
