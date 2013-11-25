using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
namespace Core

{
	public class ToriiGateTrigger : TriggerComponent
	{
		public ToriiGateTrigger (Selector target_list ) : base(target_list)
		{
		}
		public override void onCollide (Entity target)
		{
			Console.WriteLine( "You've reached the Torii Gate - Level Over!" );
			Respawner r = target.FindComponent<Respawner>();
			if ( r != null )
			{
				RigidBody rib = target.FindComponent<RigidBody>();
				r.ResetPosition();
				rib.updateTransformData();	
				rib.Velocity = new Vector2( 0f , 0f );
			}
			SceneManager.Instance.DestroyAll();
			base.onCollide (target);
		}
	}
}

