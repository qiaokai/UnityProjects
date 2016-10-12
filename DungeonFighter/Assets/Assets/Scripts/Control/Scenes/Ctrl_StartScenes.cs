/***
*	Title: "地下守护神" 项目开发
*			控制层：开始场景
*			
*	Description:
*			[描述]
*			
*	Data:2016
*
*	
*	Version: 0.0.1
*	
*	Motify Recoder:
*	
*/



using UnityEngine;
using System.Collections;

namespace Control {
	
	public class Ctrl_StartScenes : MonoBehaviour {
		public static Ctrl_StartScenes Instance;

		void Awake () {
			Instance = this;
		}

		internal void NewGame () {
			//场景淡出

			print (GetType()+": NewGame");


//			Application.loadedLevel ("");
		}

		internal void Continue () {
			print (GetType()+": Continue");

		}
	}
}
