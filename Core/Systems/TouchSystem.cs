using System;
using Sce.PlayStation.Core;

namespace Core
{
	public class TouchSystem : CoreSystem
	{
		public TouchSystem ()
		{
		}
		
		public static Vector3 ConvertScreenToWorld(float rel_x,float rel_y, Vector3 pos, Vector3 dir)
		{
			return new Vector3();
		}
		public static Vector3 RayCastOntoPlane(Vector3 pos, Vector3 dir)
		{
			Vector3 N = new Vector3(0, 0, 1);
			return ((-pos.Dot(N))/(dir.Dot(N))) * dir + pos;
		}
	}
}

