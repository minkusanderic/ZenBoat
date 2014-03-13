using System;
using System.Threading;
using System.Diagnostics;

namespace Core
{
	/**
 * Animation Timer class
 */
	public static class Timer
	{
		//  Init and term

		public static bool Init()
		{
			stopwatch = new Stopwatch() ;
			stopwatch.Start() ;
			FrameCount = -1 ;
			return true ;
		}
	
		public static void Term()
		{
		}
	
		//  Frame trigger
	
		public static void StartFrame()
		{
			var currStartTick = stopwatch.ElapsedTicks ;
			start_frame = stopwatch.ElapsedMilliseconds;
			FrameCount ++ ;
			if ( FrameCount != 0 ) {
				DeltaTime = (float)( currStartTick - prevStartTick ) / (float)Stopwatch.Frequency ;
				FrameRate = ( DeltaTime == 0.0f ) ? 0.0f : 1.0f / DeltaTime ;
				FrameTime = (float)( prevEndTick - prevStartTick ) / (float)Stopwatch.Frequency ;
				averageTimerFrame ++ ;
				averageTimerTime += FrameTime ;
			}
			prevStartTick = currStartTick ;
	
			IsAverageUpdated = false ;
			var averageSampleTick = currStartTick - averageTimerStart ;
			if ( FrameCount == 1 || averageSampleTick > Stopwatch.Frequency ) {
				if ( averageTimerFrame == 0 ) averageTimerFrame = 1 ;
				AverageFrameRate = (float)averageTimerFrame / averageSampleTick * Stopwatch.Frequency ;
				AverageFrameTime = averageTimerTime / averageTimerFrame ;
				IsAverageUpdated = true ;
				averageTimerStart = currStartTick ;
				averageTimerFrame = 0 ;
				averageTimerTime = 0.0f ;
			}
		}
		
	public static void EndFrame()
	{
		prevEndTick = stopwatch.ElapsedTicks ;
		
		while((stopwatch.ElapsedMilliseconds - start_frame) < ((1.0f/Globals.frames_per_second) * 1000.0f))
		{
			//block until we get our desired frame rate
		}
	}

	//  Stopwatch properties

	public static TimeSpan Elapsed {
		get { return stopwatch.Elapsed ; }
	}
	public static long ElapsedMilliseconds {
		get { return stopwatch.ElapsedMilliseconds ; }
	}
	public static long ElapsedMicroseconds {
		get { return stopwatch.ElapsedTicks * 1000000 / Stopwatch.Frequency ; }
	}
	public static long ElapsedTicks {
		get { return stopwatch.ElapsedTicks ; }
	}
	public static long Frequency {
		get { return Stopwatch.Frequency ; }
	}

	//  Time values

	public static int FrameCount ;
	public static float DeltaTime ;
	public static float FrameRate ;
	public static float FrameTime ;
	public static float AverageFrameRate ;
	public static float AverageFrameTime ;
	public static bool IsAverageUpdated ;

	//  Variables

	static Stopwatch stopwatch ;
	static long prevStartTick ;
	static long prevEndTick ;

	static long averageTimerStart ;
	static int averageTimerFrame ;
	static float averageTimerTime ;
		
	static long start_frame;
}

} // end Timer

