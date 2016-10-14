/***
*	Title: "地下守护神" 项目开发
*			公共层：场景特效
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

namespace Global {
	
	public class FadeInAndOut : MonoBehaviour {
		public static FadeInAndOut Instance;

		public GameObject rawImage;
		public float ColorChangeSpeed = 1f;
		private RawImage _RawImage;
		private bool _BoolScenesToClear = true;
		private bool _BoolScenesToBlack = false;

		void Awake () {
			Instance = this;
			if (_RawImage == null) {
				_RawImage = rawImage.GetComponent<RawImage> ();
			}
		}

		private void ScenesToClear () {
			if (_RawImage.color.a > 0.05) {
				_RawImage.enabled = true;
				_RawImage.color = Color.Lerp (_RawImage.color, Color.clear, ColorChangeSpeed * Time.deltaTime);
			} else {
				_RawImage.color = Color.clear;
				_BoolScenesToClear = false;
				_RawImage.enabled = false;
			}
		}

		private void ScenesToBlack () {
			if (_RawImage.color.a < 0.95) {
				_RawImage.enabled = true;
				_RawImage.color = Color.Lerp (_RawImage.color, Color.black, ColorChangeSpeed * Time.deltaTime);
			} else {
				_RawImage.color = Color.black;
				_BoolScenesToBlack = false;
			}
		}

		public void FadeToClear () {
			_BoolScenesToClear = true;
			_BoolScenesToBlack = false;
		}

		public void FadeToBlack () {
			_BoolScenesToBlack = true;
			_BoolScenesToClear = false;
		}

		void Update () {
			if (_BoolScenesToClear) {
				ScenesToClear ();
			} else if (_BoolScenesToBlack) {
				ScenesToBlack ();
			}
		}
	}
}