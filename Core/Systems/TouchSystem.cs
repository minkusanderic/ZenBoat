using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Input;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class TouchSystem : CoreSystem
	{
		public TouchSystem ()
		{
		}
		
		private List<TouchData> touch_data;
		
		public static Vector3 ConvertScreenToWorld(float rel_x,float rel_y, Vector3 pos, Vector3 dir)
		{
			return new Vector3();
		}
		public static Vector3 RayCastOntoPlane(Vector3 pos, Vector3 dir)
		{
			Vector3 N = new Vector3(0, 0, 1);
			return ((-pos.Dot(N))/(dir.Dot(N))) * dir + pos;
		}
		
		public override void Update()
		{
			touch_data = Touch.GetData(0);
			if ( touch_data.Capacity != 0)
			{
				CollectibleManager.Touched = true;
				CollectibleManager.multiplier = 1;
			}
		}
		public List<TouchData> getTouchData()
		{
			return touch_data;
		}
	}
}

