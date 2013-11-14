using System;
using Core;
using System.Collections;
using System.Collections.Generic;

namespace Main
{
	public class Torii
	{
		public Torii ()
		{
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.attachComponent(new SpriteComponent("/Application/Assets/Torii Gate ph.png"));
		}
	}
}

