using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;

namespace Core
{
	public class Sprite2d : GraphicsComponent
	{
		public string fileName;
		
		public Sprite2d (string fileName)
		{
			this.fileName = fileName;
		}
		public void SetVisible(bool b)
		{
			this.sprite.Visible = b;
			//return this.
		}
		public void SetScale( Vector2 vec )
		{
			this.sprite.Scale = vec;	
		}
		public bool GetVisible()
		{
			return this.sprite.Visible;	
		}
		public void SetRotation(float rotation)
		{
		 	this.sprite.Rotate( rotation );
		}
		public Vector2 GetRotation()
		{
			return this.sprite.Rotation;	
		}
	}
}

