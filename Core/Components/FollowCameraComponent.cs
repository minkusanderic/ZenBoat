using System;

namespace Core
{
	public class FollowCameraComponent : Core.Controller
	{
		GraphicsSystem cam;
		public FollowCameraComponent ()
		{
			cam = (GraphicsSystem) SceneManager.Instance.getSystem( typeof(GraphicsSystem) );
		}
		public override void Update ()
		{
			if ( cam == null )
			{
				cam = (GraphicsSystem)SceneManager.Instance.getSystem( typeof(GraphicsSystem) );
			}
			this.parent.Transform.Position = new Sce.PlayStation.Core.Vector2( cam.camera_pos.X - 350f , 0f );
			//base.Update ();
		}
	}
}

