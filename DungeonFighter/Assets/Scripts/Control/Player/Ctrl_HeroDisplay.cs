/***
*	Title: "地下守护神" 项目开发
*
*			控制层：角色展示
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
	public class Ctrl_HeroDisplay : MonoBehaviour {
		public AnimationClip AniIdle;
		public AnimationClip AniRun;
		public AnimationClip AniAttack;
		private Animation _CurrentAnimation;
		private float _IntervalTimes = 3f;
		private int _PlayNumber;

		void Start () {
			_CurrentAnimation = this.GetComponent<Animation> ();
		}

		void Update () {
			_IntervalTimes -= Time.deltaTime;
			if (_IntervalTimes <= 0) {
				_IntervalTimes = 3F;
				HeroDisPlay (Random.Range (1, 4));
			}
		}

		internal void HeroDisPlay (int animationNo) {
			string animationName = "";
			switch (animationNo) {
			case 1:
				animationName = AniIdle.name;
				break;
			case 2:
				animationName = AniRun.name;
				break;
			case 3:
				animationName = AniAttack.name;
				break;
			}
			DisplayAnimation (animationName);
		}

		internal void DisplayAnimation (string animationName) {
			if (_CurrentAnimation != null) {
				_CurrentAnimation.CrossFade (animationName);
			}
		}

	}
}
