using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPoint : MonoBehaviour
{
	// TODO struct�� dictionary�ɂ�����(����U�茈��̂���)
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
	/// �e�X�e�[�^�X��ω�������(�c�X�e�[�^�X�|�C���g���̂�)
	/// </summary>
	/// <param name="type">�X�e�[�^�X�̎��</param>
	/// <param name="num">�����l</param>
	public void StatusSelect(string type, int num)
	{
		int changeNum = num;
		if(num > _statusPoint)
		{
			changeNum = _statusPoint;
		}
		_statusPoint -= changeNum;
		Debug.Log(string.Format("num:{0}, change:{1}, status:{2}", num, changeNum, _statusPoint));
		// TODO num �̑����l���X�e�[�^�X�|�C���g�ȉ��A0�ȏ�ɂ�����
		switch (type)
		{
			// TODO enum�g���ă~�X���N����Ȃ��悤�ɂ�����
			// TODO Dictionary�Ȃ�����ƒP���ɏ�����
			case "Attack":
				if(_attack + changeNum < 0 && _attack > 0)
				{
					_statusPoint += -(_attack + changeNum);
					_attack = 0;
				}
				else
				{
					if(changeNum + _attack >= 0)
					{
						_attack += changeNum;
					}
					else{
						_statusPoint += changeNum;
					}
				}
				break;

			case "AttackSpeed":
				if (_attackSpeed + changeNum < 0 && _attackSpeed > 0)
				{
					_statusPoint += -(_attackSpeed + changeNum);
					_attackSpeed = 0;
				}
				else
				{
					if (changeNum + _attackSpeed >= 0)
					{
						_attackSpeed += changeNum;
					}
					else
					{
						_statusPoint += changeNum;
					}
				}
				break;

			case "Deffence":
				if (_deffence + changeNum < 0 && _deffence > 0)
				{
					_statusPoint += -(_deffence + changeNum);
					_deffence = 0;
				}
				else
				{
					if (changeNum + _deffence >= 0)
					{
						_deffence += changeNum;
					}
					else
					{
						_statusPoint += changeNum;
					}
				}

				break;

			case "HitPoint":
				if (_hitPoint + changeNum < 0 && _hitPoint > 0)
				{
					_statusPoint += -(_hitPoint + changeNum);
					_hitPoint = 0;
				}
				else
				{
					if (changeNum + _hitPoint >= 0)
					{
						_hitPoint += changeNum;
					}
					else
					{
						_statusPoint += changeNum;
					}
				}

				break;

			case "Speed":
				if (_speed + changeNum < 0 && _speed > 0)
				{
					_statusPoint += -(_speed + changeNum);
					_speed = 0;
				}
				else
				{
					if (changeNum + _speed >= 0)
					{
						_speed += changeNum;
					}
					else
					{
						_statusPoint += changeNum;
					}
				}

				break;

			case "AbilityHaste":
				if (_abilityHaste + changeNum < 0 && _abilityHaste > 0)
				{
					_statusPoint += -(_abilityHaste + changeNum);
					_abilityHaste = 0;
				}
				else
				{
					if(changeNum + _abilityHaste >= 0)
					{
						_abilityHaste += changeNum;
					}
					else
					{
						_statusPoint += changeNum;
					}
				}

				break;

			default:
				break;
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
