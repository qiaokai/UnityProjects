/***
*	Title: "地下守护神" 项目开发
*			控制层：角色移动控制
*			
*	Description:
*			通过EasyTouch插件控制角色移动
*
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
	
	public class Ctrl_HeroMovingByET : BaseControl {
		public EasyJoystick joystick;
		public AnimationClip Ani_Idle;
		public AnimationClip Ani_Runing;

		#region 事件注册

		void OnEnable () {
			EasyJoystick.On_JoystickMove += OnJoystickMove;
			EasyJoystick.On_JoystickMoveEnd += OnJoystickMoveEnd;
		}

		void OnDisable () {
			EasyJoystick.On_JoystickMove -= OnJoystickMove;
			EasyJoystick.On_JoystickMoveEnd -= OnJoystickMoveEnd;
		}

		void OnDestroy () {
			EasyJoystick.On_JoystickMove -= OnJoystickMove;
			EasyJoystick.On_JoystickMoveEnd -= OnJoystickMoveEnd;
		}

		#endregion


	

		/// <summary>
		/// 移动摇杆
		/// </summary>
		/// <param name="move">Move.</param>
		void OnJoystickMove (MovingJoystick move) {
			
			if (joystick == null || move.joystickName != joystick.name) {
				return;
			}

			//获取摇杆中心偏移的坐标
			float joyPositionX = move.joystickAxis.x;
			float joyPositionY = move.joystickAxis.y;
			if (joyPositionX != 0 || joyPositionY != 0) {
				//播放奔跑动画
				GetComponent<Animation> ().CrossFade (Ani_Runing.name);
				//设置角色朝向
				transform.LookAt (new Vector3 (transform.position.x - joyPositionX, transform.position.y, transform.position.z - joyPositionY));
				//移动玩家位置
				transform.Translate (Vector3.forward * Time.deltaTime * 3);
			}
		}

		/// <summary>
		/// 移动摇杆结束
		/// </summary>
		/// <param name="move">Move.</param>
		void OnJoystickMoveEnd (MovingJoystick move) {
			if (joystick != null && move.joystickName == joystick.name) {
				GetComponent<Animation> ().CrossFade (Ani_Idle.name);
			}
			
		}
	}
}
