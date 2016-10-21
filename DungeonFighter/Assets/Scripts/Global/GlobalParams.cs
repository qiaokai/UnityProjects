/***
*	Title: "地下守护神" 项目开发
*			公共层：全全局参数
*			
*	Description:
*			1：定义整个项目的枚举类型
*			2：定义整个项目的委托
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

namespace Global {
	public static  class GlobalParams {
		public static string NextScene = "";
		public static string PlayerName = "";
		public  static  PlayerTypes PlayerType;
	}

	/// <summary>
	/// 场景名称
	/// </summary>
	public  class ScenesName {
		public const string StartScene = "StartScene";
		public const string LoadingScene = "LoadingScene";
		public const string LoginScene = "LoginScene";
		public const string LevelOne = "LevelOneScene";

	}

	public  enum PlayerTypes {
		SwordHero,
		MagicHero
	}
}
