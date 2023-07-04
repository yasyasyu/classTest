using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPoint : MonoBehaviour
{
	// TODO structや dictionaryにしたい(割り振り決定のため)
	private int _statusPoint = 10;

	//private int _attack = 0;
	//private int _attackSpeed = 0;
	//private int _deffence = 0;
	//private int _hitPoint = 0;
	//private int _speed = 0;
	//private int _abilityHaste = 0;
	private Dictionary<string, int> _status = new Dictionary<string, int>();
	[SerializeField]
	private Text viewText;
	private void Awake()
	{
		Init();
	}
	private void Start()
	{
		
		ViewStatusPoint();
	}

	/// <summary>
	/// 各ステータスを変化させる(残ステータスポイント分のみ)
	/// </summary>
	/// <param name="type">ステータスの種類</param>
	/// <param name="num">増減値</param>
	public void StatusSelect(string type, int num)
	{
		if(_status[type] + num < 0 && _status[type] > 0)
		{
			_statusPoint += _status[type] ;
			_status[type] = 0;
		}
		else
		{
			int changeNum = num;
			if (changeNum > _statusPoint)
			{
				changeNum = _statusPoint;
			}

			_statusPoint -= changeNum;
			if (changeNum + _status[type] >= 0)
			{
				_status[type] += changeNum;
			}
			else{
				_statusPoint += changeNum;
			}
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
			case "AttackSpeed":
			case "Deffence":
			case "HitPoint":
			case "Speed":
			case "AbilityHaste":
				return _status[type];

			default:
				break;
		}
		return -1;
	}
	private void Init()
	{
		_status.Add("Attack", 0);
		_status.Add("AttackSpeed", 0);
		_status.Add("Deffence", 0);
		_status.Add("HitPoint", 0);
		_status.Add("Speed", 0);
		_status.Add("AbilityHaste", 0);
	}
	private void ViewStatusPoint()
	{
		viewText.text = _statusPoint.ToString();
	}
}
