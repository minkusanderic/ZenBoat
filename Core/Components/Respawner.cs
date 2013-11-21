using System;
using Sce.PlayStation.Core;
namespace Core
{
	public class Respawner : IComponent
		
	{
		private Vector2 originalPosition;
		public Respawner ()
		{
		}
		public Respawner (Vector2 pos)
		{
			this.originalPosition = pos;
		}
		public void SetOriginalPosition( Vector2 pos )
		{
			this.originalPosition = pos;
		}
		public void ResetPosition()
		{
			this.parent.Transform.Position = originalPosition;	
		}
	}
}

