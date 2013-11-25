using System;
using System.Collections.Generic;
namespace Core
{
	public class WhirlpoolTrigger : TriggerComponent
	{
		public WhirlpoolTrigger (Selector target_list ) : base(target_list)
		{
			Console.WriteLine( "making Whirpooltrigger" );
		}
		public override void onCollide (Entity target)
		{
			Console.WriteLine( "Reached End game!" );
			base.onCollide (target);
		}
	}
}

