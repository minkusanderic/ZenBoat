using System;
using Sce.PlayStation.Core;


namespace Core
{
	public class Transform
	{
		public Transform()
		{
			this.Position = new Vector2();
			this.Rotation = new Vector2(1.0f, 0.0f);
			
		}
		
		public void SetAngle(float angle)
		{
			this.Rotation = Vector2.UnitX.Rotate(angle);
		}
		
		public Vector2 Position;
		public Vector2 Rotation;
	}
}

