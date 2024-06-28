using RandomStuffByMasi.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace RandomStuffByMasi.Content.Items.Projectiles
{
    class SupremeRubberSwordProjectile : ModProjectile
    {
		public override void SetDefaults()
		{
			Projectile.width = 22;
			Projectile.height = 20;
			Projectile.aiStyle = 27; // Terra Beam
			Projectile.friendly = true;
			Projectile.ignoreWater = true;
			Projectile.DamageType = DamageClass.Melee;
			Projectile.damage = 200;
			Projectile.maxPenetrate = 5;
		}
	}
}
