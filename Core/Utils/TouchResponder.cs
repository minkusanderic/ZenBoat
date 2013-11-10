using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment ;
using Sce.PlayStation.HighLevel.Model ;
using System.Threading ;
using System.Diagnostics ;
namespace Core
{
	public class TouchResponder : Core.Controller
	{
		Vector3 scale;
		public TouchResponderDelegate function;
		static float width	= 960; 
		static float height = 544;
		bool touchDown = false;
		public TouchResponder ( )
		{
		}
		public delegate void TouchResponderDelegate();
		public TouchResponder( TouchResponderDelegate func )
		{
			function = func;
		}
		
		public override void Update ()
		{
			if ( Touch.GetData(0).Count > 0 )
				{
					foreach( TouchData td in Touch.GetData(0) )
					{
						if ( !touchDown )
						{
							touchDown = true;
							float interp_x =  td.X + .5f;
							float interp_y = -td.Y + .5f;
						
							float X = (interp_x * width);
							float Y = (interp_y * height);
							
							// TODO change the hard coded '50f' to something based om the scale of the rock
							
							if ( Math.Abs( X - parent.Transform.Position.X ) < 50f )
							{
								if ( 	Math.Abs( Y - parent.Transform.Position.Y ) < 50f )
								{
									function();
								}
							}
							
							break;
						}
					}
				} 
				else
				{
					touchDown = false;	
				}
			
			
		}
	}
}
/*
 * foreach( TouchData td in Touch.GetData( 0 ) )
			{
				
			}
			*/
