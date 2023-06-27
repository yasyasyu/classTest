using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPoint : MonoBehaviour
{
	// TODO struct�� dictionary�ɂ�����(����U�茈��̂���)
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
	/// �e�X�e�[�^�X��ω�������(�c�X�e�[�^�X�|�C���g���̂�)
	/// </summary>
	/// <param name="type">�X�e�[�^�X�̎��</param>
	/// <param name="num">�����l</param>
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
	/// �X�e�[�^�X�̊���U�茈��
	/// �X�e�[�^�X�ւ̔��f
	/// </summary>
	public void SelectApply()
	{
		// struct��dictionary���o���āA�X�e�[�^�X�̋���ԂƐV��Ԃ�ێ��o���Ă����������

	}
	public int StatusUI(string type)
	{
		switch (type)
		{
			// TODO enum�g���ă~�X���N����Ȃ��悤�ɂ�����
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
