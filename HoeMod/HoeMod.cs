/* Hello,
 * its my first mod i upload i hope you like it:) 
 */
/**
 * Author: Dominik John(joshi1999)
 */

//V.1.0



using System;
using System.Collections.Generic;
using System.Text;
 
namespace ManicDigger.Mods
{
    public class HoeMod : IMod
    {
        public void PreStart(ModManager m)
        {
        }
        public void Start(ModManager m)
        {
			this.m = m;
			 SoundSet sounds = new SoundSet()
            {
                Walk = new string[] { "walk1", "walk2", "walk3", "walk4" },
                Break = new string[] { "destruct" },
                Build = new string[] { "build" },
                Clone = new string[] { "clone" },
            };

			m.SetBlockType(EnteryourID,"Hoe",new BlockType()
			{
				TextureIdFront = "Empty",
                TextureIdLeft = "Empty",
                TextureIdRight = "Empty",
                TextureIdBack = "Empty",
                TextureIdBottom = "Empty",
				TextureIdTop = "Hoe",
				TextureIdForInventory = "Hoe",
				WalkableType = WalkableType.Solid,
				DrawType = DrawType.Transparent, 
				IsTool = true,
				Sounds = sounds,
			});
			m.RegisterOnBlockUseWithTool(BlockUseWithTool);
			m.AddToCreativeInventory("Sense");
			m.AddCraftingRecipe2("Sense",1,"IronBlock",2,"TreeTrunk", 1);
			Crops1 = m.GetBlockId("Crops1");
			Crops4 = m.GetBlockId("Crops4");
			Sense = m.GetBlockId("Sense");
            carrots_0 = m.GetBlockId("carrots_0");
            carrots = m.GetBlockId("carrots");
            potatoes_0 = m.GetBlockId("potatoes_0");
            potatoes = m.GetBlockId("potatoes");
            cotton_0 = m.GetBlockId("cotton_0");
            cotton = m.GetBlockId("cotton");
        }
		ModManager m;
		int Sense;
		int Crops1;
		int Crops4;
        int carrots_0;
        int carrots;
        int potatoes_0;
        int potatoes;
        int cotton_0;
        int cotton;


        void BlockUseWithTool (int player, int x, int y, int z, int tool)
		{
            if (tool == Sense)
            {
                if (m.GetBlock(x, y, z) == Crops4)
                {
                    m.SetBlock(x, y, z, Crops1);
                    m.GrabBlock(player, Crops4);
                    m.NotifyInventory(player);
                }
                if (m.GetBlock(x, y, z) == carrots)
                {
                    m.SetBlock(x, y, z, carrots_0);
                    m.GrabBlock(player, carrots);
                    m.NotifyInventory(player);
                }
                if (m.GetBlock(x, y, z) == potatoes)
                {
                    m.SetBlock(x, y, z, potatoes_0);
                    m.GrabBlock(player, potatoes);
                    m.NotifyInventory(player);
                }
                if (m.GetBlock(x, y, z) == cotton)
                {
                    m.SetBlock(x, y, z, cotton_0);
                    m.GrabBlock(player, cotton);
                    m.NotifyInventory(player);
                }
            }
		}
	}
}
