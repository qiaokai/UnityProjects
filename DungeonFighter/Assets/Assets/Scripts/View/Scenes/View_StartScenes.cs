/***
*	Title: "地下守护神" 项目开发
*			视图层：开始场景
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
using Control;

namespace View {
	
	public class View_StartScenes : MonoBehaviour {
		public void NewGame () {
			Ctrl_StartScenes.Instance.NewGame ();
		}

		public void Continue () {
			Ctrl_StartScenes.Instance.Continue ();
		}

	}
}
