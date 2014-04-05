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
			
		static Random random;
		static readonly string[] grassModels = {
			"GrassBundle1",
			"GrassBundle2",
			"GrassBundle3",
			"GrassBundle4",
			"GrassDoubleBlade1",
			"GrassDoubleBlade2",
			"GrassDoubleBlade3",
			"GrassDoubleBlade4",
			"GrassSingleBlade1",
			"GrassSingleBlade2"
		};
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.tag("grass");
			if( random == null )
				random = new Random();
			
			ModelComponent m = ent.attachComponent(new ModelComponent(string.Format("/Application/assets/{0}.mdx", grassModels[random.Next(0, grassModels.Length-1)])));
			m.scale = new Vector3(2, 2, 2);
		}
	}
}
