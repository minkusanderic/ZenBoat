using System;

namespace Core
{
	public class RockTouchResponder : TouchResponder
	{
		public RockTouchResponder()
		{
			function = RockTouchHandler;
		}
		
		void RockTouchHandler()
		{
			Entity entity = this.parent;
			entity.attachComponent( new RockFollowTouchController() );
			entity.Transform.Z = 100f;
			entity.FindComponent<RigidBody>().Destroy();	
		}
	}
}

