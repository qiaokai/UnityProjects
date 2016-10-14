/***
*	Title: "地下守护神" 项目开发
*
*			控制层：基础控制层
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
using kernal;

public class BaseControl : MonoBehaviour {

	protected void StartNextScenes (string sceneName) {
		//设置下一个场景
		GlobalParams.NextScene = sceneName;
		//加载Loading场景	
		Application.LoadLevel (ScenesName.LoadingScene);
	}
}
