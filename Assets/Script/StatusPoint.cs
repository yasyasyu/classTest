using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPoint : MonoBehaviour
{
	// TODO structや dictionaryにしたい(割り振り決定のため)
	private int _statusPoint = 0;

	private int _attack = 0;
	private int _attackSpeed = 0;
	private int _deffence = 0;
	private int _hitPoint = 0;
	private int _speed = 0;
	private int _abilityHaste = 0;

	private void Start()
	{
		Init();
	}

	/// <summary>
	/// 各ステータスを変化させる(残ステータスポイント分のみ)
	/// </summary>
	/// <param name="type">ステータスの種類</param>
	/// <param name="num">増減値</param>
	public void StatusSelect(string type, int num)
	{
		// TODO num の増減値をステータスポイント以下、0以上にしたい
		switch (type)
		{
			// TODO enum使ってミスが起こらないようにしたい
			case "Attack":
				_attack += num;
				break;

			case "AttackSpeed":
				_attackSpeed += num;
				break;

			case "Deffence":
				_deffence += num;
				break;

			case "HitPoint":
				_hitPoint += num;
				break;

			case "Speed":
				_speed += num;
				break;

			case "AbilityHaste":
				_abilityHaste += num;
				break;

			default:
				break;
		}
		ViewStatusPoint();
	}
	/// <summary>
	/// ステータスの割り振り決定
	/// ステータスへの反映
	/// </summary>
	public void SelectApply()
	{
		// structやdictionaryが出来て、ステータスの旧状態と新状態を保持出来てから実装する

	}

	private void Init()
	{
		_attack = 0;
		_attackSpeed = 0;
		_deffence = 0;
		_hitPoint = 0;
		_speed = 0;
		_abilityHaste = 0;
	}
	private void ViewStatusPoint()
	{
		Debug.Log(string.Format("_attack:{0}", _attack));
		Debug.Log(string.Format("_attackSpeed:{0}", _attackSpeed));
		Debug.Log(string.Format("_deffence:{0}", _deffence));
		Debug.Log(string.Format("_hitPoint:{0}", _hitPoint));
		Debug.Log(string.Format("_speed:{0}", _speed));
		Debug.Log(string.Format("_abilityHaste:{0}", _abilityHaste));
	}
}
