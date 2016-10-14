/***
*	Title: "地下守护神" 项目开发
*
*			控制层：登录场景
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
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Global;

namespace Control {
	public class Ctrl_LoginScenes : BaseControl {
		public static Ctrl_LoginScenes Instance;

		// Use this for initialization
		void Awake () {
			Instance = this;
		}

		public void StartNextScenes () {
			StartNextScenes (ScenesName.LevelOne);
		}
	}
}
