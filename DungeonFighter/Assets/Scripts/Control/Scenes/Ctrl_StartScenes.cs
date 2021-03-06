﻿/***
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
using Global;
using kernal;

namespace Control {
	
	public class Ctrl_StartScenes : BaseControl {
		public static Ctrl_StartScenes Instance;
		public AudioClip _AudioBackGround;

		void Awake () {
			Instance = this;
		}

		void Start () {
			AudioManager.SetAudioBackgroundVolumns (0.5F);
			AudioManager.SetAudioEffectVolumns (1F);
			AudioManager.PlayBackground (_AudioBackGround);
		}

		internal void NewGame () {
			StartCoroutine ("EnterNextScenes", ScenesName.LoginScene);
		}

		internal void Continue () {
			print (GetType () + ": Continue");

		}

		IEnumerator EnterNextScenes (string sceneName) {
			//场景淡出
			FadeInAndOut.Instance.FadeToBlack ();
			yield return new WaitForSeconds (1.5f);
			//打开下一个场景
			StartNextScenes (sceneName);
		
		}
	}
}
