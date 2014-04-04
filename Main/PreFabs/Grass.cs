using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
using Sce.PlayStation.HighLevel.Physics2D;
namespace Main
{
	public class Grass
	{
		public Grass ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.tag("grass");
			Random random = new Random();
			/*ent.attachComponent(new Core.SimpleController(() => {
				List<Entity> targets = SceneManager.Instance.FindEntitiesByTag("grass").ToList();
				foreach(var obj in targets)
					{
						int randomNumber = random.Next(0, 10);
			        	if(randomNumber == 1)
						{
							ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/GrassBundle1.mdx"));
							m.scale = new Vector3(2 , 2, 2);
						}
						if(randomNumber == 2)
						{
							ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/GrassBundle2.mdx"));
							m.scale = new Vector3(2 , 2, 2);
						}
						if(randomNumber == 3)
						{
							ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/GrassBundle3.mdx"));
							m.scale = new Vector3(2 , 2, 2);
						}
						if(randomNumber == 4)
						{
							ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/GrassBundle4.mdx"));
							m.scale = new Vector3(2 , 2, 2);
						}
						if(randomNumber == 5)
						{
							ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/GrassDoubleBlade1.mdx"));
							m.scale = new Vector3(2 , 2, 2);
						}
						if(randomNumber == 6)
						{
							ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/GrassDoubleBlade2.mdx"));
							m.scale = new Vector3(2 , 2, 2);
						}
						if(randomNumber == 7)
						{
							ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/GrassDoubleBlade3.mdx"));
							m.scale = new Vector3(2 , 2, 2);
						}
						if(randomNumber == 8)
						{
							ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/GrassDoubleBlade4.mdx"));
							m.scale = new Vector3(2 , 2, 2);
						}
						if(randomNumber == 9)
						{
							ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/GrassSingleBlade1.mdx"));
							m.scale = new Vector3(2 , 2, 2);
						}
						if(randomNumber == 10)
						{
							ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/GrassSingleBlade2.mdx"));
							m.scale = new Vector3(2 , 2, 2);
						}
					
					}
			})); */
		}
	}
}
