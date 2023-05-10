using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPoint : MonoBehaviour
{
	// TODO structや dictionaryにしたい(割り振り決定のため)
	private int _statusPoint = 10;

	private int _attack = 0;
	private int _attackSpeed = 0;
	private int _deffence = 0;
	private int _hitPoint = 0;
	private int _speed = 0;
	private int _abilityHaste = 0;
	[SerializeField]
	private Text viewText;
	private void Start()
	{
		Init();
		ViewStatusPoint();
	}

	/// <summary>
	/// 各ステータスを変化させる(残ステータスポイント分のみ)
	/// </summary>
	/// <param name="type">ステータスの種類</param>
	/// <param name="num">増減値</param>
	public void StatusSelect(string type, int num)
	{
		if(_statusPoint == 0)
		{
			return;
		}
		int changeNum = num;
		if(num > _statusPoint)
		{
			changeNum = _statusPoint;
		}
		_statusPoint -= changeNum;

		// TODO num の増減値をステータスポイント以下、0以上にしたい
		switch (type)
		{
			// TODO enum使ってミスが起こらないようにしたい
			case "Attack":
				if(_attack + changeNum < 0)
				{
					_statusPoint += -(_attack + changeNum);
					_attack = 0;
				}
				else
				{
					_attack += changeNum;
				}
				break;

			case "AttackSpeed":
				if (_attackSpeed + changeNum < 0)
				{
					_statusPoint += -(_attackSpeed + changeNum);
					_attackSpeed = 0;
				}
				else
				{
				_attackSpeed += changeNum;
				}
				break;

			case "Deffence":
				if (_deffence + changeNum < 0)
				{
					_statusPoint += -(_deffence + changeNum);
					_deffence = 0;
				}
				else
				{
					_deffence += changeNum;
				}

				break;

			case "HitPoint":
				if (_hitPoint + changeNum < 0)
				{
					_statusPoint += -(_hitPoint + changeNum);
					_hitPoint = 0;
				}
				else
				{
					_hitPoint += changeNum;
				}

				break;

			case "Speed":
				if (_speed + changeNum < 0)
				{
					_statusPoint += -(_speed + changeNum);
					_speed = 0;
				}
				else
				{
					_speed += changeNum;
				}

				break;

			case "AbilityHaste":
				if (_abilityHaste + changeNum < 0)
				{
					_statusPoint += -(_abilityHaste + changeNum);
					_abilityHaste = 0;
				}
				else
				{
					_abilityHaste += changeNum;
				}

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
	public int StatusUI(string type)
	{
		switch (type)
		{
			// TODO enum使ってミスが起こらないようにしたい
			case "Attack":
				return _attack;

			case "AttackSpeed":
				return _attackSpeed;

			case "Deffence":
				return _deffence;

			case "HitPoint":
				return _hitPoint;

			case "Speed":
				return _speed;

			case "AbilityHaste":
				return _abilityHaste;

			default:
				break;
		}
		return -1;
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
		viewText.text = _statusPoint.ToString();
	}
}
