using System;
using System.Collections.Generic;
namespace Core

{
	public class ToriiGateTrigger : TriggerComponent
	{
		public ToriiGateTrigger (List<Entity> target_list ) : base(target_list)
		{
			base.targets = target_list;
		}
		public override void onCollide (Entity target)
		{
			Console.WriteLine( "You've reached the Torii Gate - Level Over!" );
			base.onCollide (target);
		}
	}
}

