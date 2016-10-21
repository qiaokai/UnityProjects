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
using kernal;

namespace Control {
	public class Ctrl_LoginScenes : BaseControl {
		public static Ctrl_LoginScenes Instance;
		public  AudioClip audio_Background;
		public  AudioClip audio_Sword;
		public  AudioClip audio_Magic;

		void Awake () {
			Instance = this;
		}

		void Start () {
			//确定音频音量
			AudioManager.SetAudioBackgroundVolumns (0.5f);
			AudioManager.SetAudioEffectVolumns (1.0f);
			//播放背景音乐
			AudioManager.PlayBackground (audio_Background);
		}

		public void StartNextScenes () {
			StartNextScenes (ScenesName.LevelOne);
		}

		public void PlayAudioEffactBySword () {
			AudioManager.PlayAudioEffectA (audio_Sword.name);
		}

		public void PlayAudioEffactByMagic () {
			AudioManager.PlayAudioEffectA (audio_Magic.name);
		}
	}
}
