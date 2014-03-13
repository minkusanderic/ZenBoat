using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


namespace Core
{
	
	public class ProfileNode
	{
		public List<ProfileNode> children = new List<ProfileNode>();
		public long start;
		public long end;
		
		public String name;
		[Conditional("DEBUG")]
		public void print_stats(long ticks, int level)
		{
			long used_ticks = ticks;
			String prepend = new String('-', level);
			Console.WriteLine(prepend + this.name + ": " + ((end-start)*100/ticks).ToString() + "%");
			foreach(var node in children)
			{
				node.print_stats(end-start, level + 1);
				used_ticks -= node.end-node.start;
			}
			if((used_ticks > 0) && (children.Count > 0))
			{
				Console.WriteLine(prepend + '-' + "Other :" + (used_ticks * 100 / ticks).ToString() + "%");
			}
		}
	}
	
	public class Profiler
	{
		
		public static Stack<ProfileNode> start_times = new Stack<ProfileNode>();
		public static Stopwatch stopwatch = new Stopwatch();
		
		public static ProfileNode root_node;
		public Profiler ()
		{
		}
		[Conditional("DEBUG")]
		public static void StartFrame()
		{
			stopwatch.Reset();
			stopwatch.Start();
			root_node = new ProfileNode();
			root_node.name = "Root";
			root_node.start = stopwatch.ElapsedTicks;
			start_times.Push(root_node);
			
		}
		
		[Conditional("DEBUG")]
		public static void Begin(String section)
		{
			var temp_node = new ProfileNode();
			temp_node.name = section;
			temp_node.start = stopwatch.ElapsedTicks;
			start_times.Push(temp_node);
		}
		
		[Conditional("DEBUG")]
		public static void End()
		{
			var temp_node = start_times.Pop();
			temp_node.end = stopwatch.ElapsedTicks;
			start_times.Peek().children.Add(temp_node);
		}
		
		[Conditional("DEBUG")]
		public static void EndFrame()
		{
			start_times.Pop();
			if(start_times.Count != 0)
			{
				throw new Exception("Profiler Begins and Ends did not match up!");
			}
			stopwatch.Stop();
			root_node.end = stopwatch.ElapsedTicks;
			
			root_node.print_stats(root_node.end - root_node.start, 1);
		}
	}
}

