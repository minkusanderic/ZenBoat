using System;
using Sce.PlayStation.Core;

namespace Core
{
	public class Camera : Component<GraphicsSystem>
	{
		/*
		public Camera2D cam;
		public Entity target = null;
		public Camera ()
		{
			this.cam = ((GraphicsSystem)SceneManager.Instance.getSystem(typeof(GraphicsSystem))).scene.Camera2D;
		}
		
		public Camera(Entity target)
		{
			this.cam = ((GraphicsSystem)SceneManager.Instance.getSystem(typeof(GraphicsSystem))).scene.Camera2D;
			this.target = target;
		}
		
		public override void Update()
		{
			if(this.target == null)
				{
					this.cam.Center = this.parent.Transform.Position;
				}
			else
			{
				this.cam.Center = new Vector2(target.Transform.Position.X, this.parent.Transform.Position.Y);
			}
		}*/
	}
}

