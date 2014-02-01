using System;
using Sce.PlayStation.Core;
namespace Core
{
	public class Respawner : IComponent
		
	{
		public Vector2 originalPosition;
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
			// Load all the cranes they picked up, which lie between the current checkpoint and the next one.
		}
	}
}

