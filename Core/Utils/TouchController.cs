using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Input;
using System.Collections;
using System.Collections.Generic;
using Core;

namespace Core
{
	public class TouchController : Core.Controller
	{
		
		public TouchController ()
		{
			Console.WriteLine("Creating TouchController");
		}
		public override void Update ()
		{
			/*
			foreach(	TouchData td in Touch.GetData(	0	)	)
			{
				float interp_x =  td.X * 2f;
				float interp_y = -td.Y * 2f;
				
				Console.WriteLine("x: " + interp_x * width_from_center + "\t\ty: " + interp_y * height_from_center );
				Entity rock = SceneManager.Instance.createEntity("Rock");
				rock.Transform.Position = new Vector2( interp_x * width_from_center , interp_y * height_from_center );
			
			}
			*/
			base.Update ();
		}
		public List<TouchData> getTouchData()
		{
			return Touch.GetData(	0	);
		}
	}
}

