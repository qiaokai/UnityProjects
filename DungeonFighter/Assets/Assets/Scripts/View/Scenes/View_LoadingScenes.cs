/***
*	Title: "地下守护神" 项目开发
*			视图层：场景加载
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

namespace View {
	public class View_LoadingScenes : MonoBehaviour {
		public Slider SilLoadingProgress;
		private float _FloatProgress;

		private AsyncOperation _AsyOper;

		void Start () {
			StartCoroutine ("LoadingNextScene");
		}

		/// <summary>
		/// 更新进度条
		/// </summary>
		void Update () {
			if (_FloatProgress <= 1) {
				_FloatProgress += 0.01F;
			}
			SilLoadingProgress.value = _FloatProgress;
		}

		/// <summary>
		/// 异步加载下一个场景
		/// </summary>
		/// <returns>The progress.</returns>
		IEnumerator LoadingNextScene () {
			_AsyOper = Application.LoadLevelAsync (GlobalParams.NextScene);
			_FloatProgress = _AsyOper.progress;
			yield return _AsyOper;
		}
	}
}
