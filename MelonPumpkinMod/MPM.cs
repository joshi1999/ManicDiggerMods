/*
 * Author: joshi1999
 */
 
 //todo: add textures

 //V.1.0
 
using System;

namespace ManicDigger.Mods
{
	public class MelonPumkinMod : IMod
	{
		public void PreStart(ModManager m)
		{
		}
		public void Start(ModManager manager)
		{
			m = manager;
			SoundSet sounds = new SoundSet()
            {
                Walk = new string[] { "walk1", "walk2", "walk3", "walk4" },
                Break = new string[] { "destruct" },
                Build = new string[] { "build" },
                Clone = new string[] { "clone" },
            };

			m.SetBlockType(EnteryourID, "Melon", new BlockType()
			{
			    AllTextures = "Melon",
				WalkableType = WalkableType.Solid,
				DrawType = DrawType.Transparent, 
				IsUsable = true,
				Sounds = sounds,
			});
			m.SetBlockType(EnteryourID, "Pumpkin", new BlockType()
			{
			    AllTextures = "Pumpkin",
			    WalkableType = WalkableType.Solid,
			    DrawType = DrawType.Solid,
			    IsUsable = true,
			    Sounds = sounds,
			});
			m.SetBlockType(EnteryourID, "MelonSeed", new BlockType()
			{
			    AllTextures = "MelonSeed",
				WalkableType = WalkableType.Empty,
				DrawType = DrawType.Plant,
				Sounds = sounds,
			});
			m.SetBlockType(EnteryourID, "MelonSeed2", new BlockType()
			{
				AllTextures = "MelonSeed2",
				WalkableType = WalkableType.Empty,
				DrawType = DrawType.Plant,
				Sounds = sounds,
			});
			m.SetBlockType(EnteryourID, "MelonSeed3", new BlockType()
			{
				AllTextures = "MelonSeed3",
				WalkableType = WalkableType.Empty,
				DrawType = DrawType.Plant,
				Sounds = sounds,
			});
			m.SetBlockType(EnteryourID, "MelonSeed4", new BlockType()
			{
				AllTextures = "MelonSeed4",
				WalkableType = WalkableType.Empty,
				DrawType = DrawType.Plant,
				Sounds = sounds,
			});
			m.SetBlockType(EnteryourID, "PumpkinSeed", new BlockType()
			{
				AllTextures = "PumpkinSeed",
				WalkableType = WalkableType.Empty,
				DrawType = DrawType.Plant,
				Sounds = sounds,
			});
			m.SetBlockType(EnteryourID, "PumpkinSeed2", new BlockType()
			{
				AllTextures = "PumpkinSeed2",
				WalkableType = WalkableType.Empty,
				DrawType = DrawType.Plant,
				Sounds = sounds,
			});
			m.SetBlockType(EnteryourID, "PumpkinSeed3", new BlockType()
			{
				AllTextures = "PumpkinSeed3",
				WalkableType = WalkableType.Empty,
				DrawType = DrawType.Plant,
				Sounds = sounds,
			});
			m.SetBlockType(EnteryourID, "PumpkinSeed4", new BlockType()
			{
				AllTextures = "PumpkinSeed4",
				WalkableType = WalkableType.Empty,
				DrawType = DrawType.Plant,
				Sounds = sounds,
			});
			
			m.AddToCreativeInventory("Melon");
			m.AddToCreativeInventory("Pumpkin");
			m.AddToCreativeInventory("MelonSeed");
			m.AddToCreativeInventory("PumpkinSeed");
			
			m.AddCraftingRecipe("MelonSeed", 2, "Melon", 1);
			m.AddCraftingRecipe("PumpkinSeed", 2, "Pumpkin", 1);
			
			Melon = m.GetBlockId("Melon");
			Pumpkin = m.GetBlockId("Pumpkin");
			MelonSeed = m.GetBlockId("MelonSeed");
			MelonSeed2 = m.GetBlockId("MelonSeed2");
			MelonSeed3 = m.GetBlockId("MelonSeed3");
			MelonSeed4 = m.GetBlockId("MelonSeed4");
			PumpkinSeed = m.GetBlockId("PumpkinSeed");
			PumpkinSeed2 = m.GetBlockId("PumpkinSeed2");
			PumpkinSeed3 = m.GetBlockId("PumpkinSeed3");
			PumpkinSeed4 = m.GetBlockId("PumpkinSeed4");
			DirtForFarming = m.GetBlockId("DirtForFarming");
			
			m.RegisterOnBlockUpdate(BlockTickGrowMelonsAndPumpkinsCycle);
		}
		ModManager m;
		int Melon;
		int Pumpkin;
		int MelonSeed;
		int MelonSeed2;
		int MelonSeed3;
		int MelonSeed4;
		int PumpkinSeed;
		int PumpkinSeed2;
		int PumpkinSeed3;
		int PumpkinSeed4;
		int DirtForFarming;
		
		void BlockTickGrowMelonsAndPumpkinsCycle(int x, int y, int z)
		{
			if(m.GetBlock(x, y, z) == DirtForFarming)
			{
				if(m.IsValidPos(x, y, z + 1))
				{
					if(m.GetBlock(x, y, z + 1) == MelonSeed4)
					{
						if((m.GetBlock(x + 1, y, z + 1) != Melon) &&
							(m.GetBlock(x + 1, y, z - 1) != Melon) &&
							(m.GetBlock(x + 1, y + 1, z) != Melon) &&
							(m.GetBlock(x + 1, y - 1, z) != elon))
						{
							if(m.IsValidPos(x + 1, y, z + 1) && m.GetBlock(x + 1, y, z + 1) == 0)
							{
								m.SetBlock(x + 1, y, z + 1, Melon);
							}
							else if(m.IsValidPos(x - 1, y, z + 1) && m.GetBlock(x - 1, y, z + 1) == 0)
							{
								m.SetBlock(x - 1, y, z + 1, Melon);
							}
							else if(m.IsValidPos(x, y + 1, z + 1) && m.GetBlock(x, y + 1, z + 1) == 0)
							{
								m.SetBlock(x, y + 1, z + 1, Melon);
							}
							else if(m.IsValidPos(x, y - 1, z + 1) && m.GetBlock(x, y - 1, z + 1) == 0)
							{
								m.SetBlock(x, y - 1, z + 1, Melon);
							}
						}
					}
				}
				if(m.IsValidPos(x, y, z + 1))
				{
					if(m.GetBlock(x, y, z + 1) == PumpkinSeed4)
					{
						if((m.GetBlock(x + 1, y, z + 1) != Pumpkin) &&
							(m.GetBlock(x + 1, y, z - 1) != Pumpkin) &&
							(m.GetBlock(x + 1, y + 1, z) != Pumpkin) &&
							(m.GetBlock(x + 1, y - 1, z) != Pumpkin))
						{
							if(m.IsValidPos(x + 1, y, z + 1) && m.GetBlock(x + 1, y, z + 1) == 0)
							{
								m.SetBlock(x + 1, y, z + 1, Pumpkin);
							}
							else if(m.IsValidPos(x - 1, y, z + 1) && m.GetBlock(x - 1, y, z + 1) == 0)
							{
								m.SetBlock(x - 1, y, z + 1, Pumpkin);
							}
							else if(m.IsValidPos(x, y + 1, z + 1) && m.GetBlock(x, y + 1, z + 1) == 0)
							{
								m.SetBlock(x, y + 1, z + 1, Pumpkin);
							}
							else if(m.IsValidPos(x, y - 1, z + 1) && m.GetBlock(x, y - 1, z + 1) == 0)
							{
								m.SetBlock(x, y - 1, z + 1, Pumpkin);
							}
						}
					}
				}
				if(m.IsValidPos(x, y, z + 1))
				{
					int blockabove = m.GetBlock(x, y, z + 1);
					if (blockabove == MelonSeed) { blockabove = MelonSeed2; }
					else if (blockabove == MelonSeed2) { blockabove = MelonSeed3; }
					else if (blockabove == MelonSeed3) { blockabove = MelonSeed4; }
					else { return; }
					m.SetBlock(x, y, z + 1, blockabove);
				}
				if(m.IsValidPos(x, y, z + 1))
				{
					int blockabove = m.GetBlock(x, y, z + 1);
					if (blockabove == PumpkinSeed) { blockabove = PumpkinSeed2; }
					else if (blockabove == PumpkinSeed2) { blockabove = PumpkinSeed3; }
					else if (blockabove == PumpkinSeed3) { blockabove = PumpkinSeed4; }
					else { return; }
					m.SetBlock(x, y, z + 1, blockabove);
				}
			}
		}
	}
}

