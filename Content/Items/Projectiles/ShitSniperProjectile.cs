using RandomStuffByMasi.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace RandomStuffByMasi.Content.Items.Projectiles
{
	class ShitSniperProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.width = 16;
			Projectile.height = 16;
			Projectile.aiStyle = 1;
			Projectile.friendly = true;
			Projectile.ignoreWater = true;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.damage = 15;
			Projectile.maxPenetrate = 2;
			Projectile.tileCollide = false;
		}
	}
}
