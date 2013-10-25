using System;


namespace Core
{
	public class SuicideController : Controller
	{
		private int elapsed_frames;
		private int kill_frame;
		public SuicideController (int kill_frame)
		{
			this.elapsed_frames = 0;
			this.kill_frame = kill_frame;
		}
		
		public override void Update()
		{
			if(this.elapsed_frames != -1){
			if(this.elapsed_frames > this.kill_frame)
			{
				this.parent.Destroy();
				this.elapsed_frames = -1;
			}
			this.elapsed_frames++;
			}
			
		}
	}
}

