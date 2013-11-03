using System;
using System.Collections.Generic;
namespace Core
{
	public class WhirlpoolTrigger : TriggerComponent
	{
		public WhirlpoolTrigger (List<Entity> target_list ) : base(target_list)
		{
			Console.WriteLine( "making Whirpooltrigger" );
			base.targets = target_list;
		}
		public override void onCollide (Entity target)
		{
			Console.WriteLine( "Reached End game!" );
			base.onCollide (target);
		}
	}
}

