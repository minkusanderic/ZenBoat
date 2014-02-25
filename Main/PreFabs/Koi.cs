using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class Koi
	{
		public Koi ()
		{
		}
		static Entity entity;
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			
			entity = ent;
			ent.tag("koi");
			
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/koifish.mdx"));
			
			//ent.Name = "Koi";
			//ent.tag("koi");
			//ent.Transform.Rotation = new Vector2(0.5f, 1f);
			//ent.Transform.SetAngle(1f);
			
			m.layer = "under_water";
			
			m.scale = new Vector3(3, 3, 3);
			m.model.Animate(0);
			m.model.SetCurrentMotion( 0, 0.1f ) ;
			//ent.attachComponent( new RigidBody(m.model.BoundingSphere.W *.25f) );
			//for(int i =0; i <1000; i++)
			//{
				//int next = ( m.model.CurrentMotion + 1 ) % m.model.Motions.Length ;
				//m.model.SetCurrentMotion( 0, 0.1f ) ;
				//ent.FindComponent<RigidBody>().applyForce(new Vector2(10.0f, 10.0f));
			//} 
		}
	}
}

