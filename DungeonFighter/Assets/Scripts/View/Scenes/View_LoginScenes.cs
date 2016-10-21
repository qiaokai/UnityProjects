/***
*	Title: "地下守护神" 项目开发
*
*			视图层：登录场景
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

using Control;
using Global;

namespace View {
	
	public class View_LoginScenes : MonoBehaviour {
		public GameObject hero_Sword;
		public GameObject hero_Magic;
		public GameObject ui_Sword;
		public GameObject ui_Magic;
		public InputField input_UserName;

		void Start () {
			GlobalParams.PlayerType = PlayerTypes.SwordHero;
		}

		public void ChangeToSwordHero () {
			hero_Sword.SetActive (true);
			hero_Magic.SetActive (false);

			ui_Sword.SetActive (true);
			ui_Magic.SetActive (false);

			Ctrl_LoginScenes.Instance.PlayAudioEffactBySword ();
		}

		public void ChangeToMagicHero () {
			hero_Magic.SetActive (true);
			hero_Sword.SetActive (false);

			ui_Magic.SetActive (true);
			ui_Sword.SetActive (false);

			Ctrl_LoginScenes.Instance.PlayAudioEffactByMagic ();

			GlobalParams.PlayerType = PlayerTypes.MagicHero;
		}

		public void SubmitInfo () {
			string username = input_UserName.text;
			//跳转到下一个场景
			Ctrl_LoginScenes.Instance.StartNextScenes ();
			print ("" + GlobalParams.PlayerType);
		}
	}
}
