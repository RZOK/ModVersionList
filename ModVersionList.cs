using Terraria.ModLoader;
using Terraria;

namespace ModVersionList
{
	public class ModVersionList : Mod
	{
        public override void Load()
        {
            foreach (Mod Item in ModLoader.Mods)
            {
                if (Item.Name != "ModLoader")
                {
                    Main.versionNumber = Main.versionNumber + "\n" + Item.Name + " v" + Item.Version;
                }
            }
        }
        public override void Unload()
        {
            Main.versionNumber = "v1.3.5.3";
        }
    }
}