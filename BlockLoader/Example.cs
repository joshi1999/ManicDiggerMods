using System;
using System.Collections.Generic;
using System.Text;
 
namespace ManicDigger.Mods
{
    public class Example : IMod
    {
        public void PreStart(ModManager m)
        {
            m.RequireMod("BlockLoader");
        }
        public void Start(ModManager m)
        {
		    this.m = m;
            bl = new BlockLoader(); //Makes the BlockLoader ready for this mod
		    SoundSet sounds = new SoundSet()
            {
                Walk = new string[] { "walk1", "walk2", "walk3", "walk4" },
                Break = new string[] { "destruct" },
                Build = new string[] { "build" },
                Clone = new string[] { "clone" },
            };

		    m.SetBlockType(bl.getId("ExampleBlock"),"ExampleBlock",new BlockType()
		    {
			    TextureIdFront = "Empty",
                TextureIdLeft = "Empty",
                TextureIdRight = "Empty",
                TextureIdBack = "Empty",
                TextureIdBottom = "Empty",
			    TextureIdTop = "Example",
			    TextureIdForInventory = "Example",
			    WalkableType = WalkableType.Solid,
			    DrawType = DrawType.Transparent, 
			    IsTool = true,
			    Sounds = sounds,
		    });
		    ExampleBlock = m.GetBlockId("ExampleBlock");
       	}
		ModManager m;
        BlockLoader bl; //Is the instance of the BlockLoader for your mod
		int ExampleBlock;
	}
}
