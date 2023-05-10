using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPoint : MonoBehaviour
{
	// TODO struct�� dictionary�ɂ�����(����U�茈��̂���)
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
	/// �e�X�e�[�^�X��ω�������(�c�X�e�[�^�X�|�C���g���̂�)
	/// </summary>
	/// <param name="type">�X�e�[�^�X�̎��</param>
	/// <param name="num">�����l</param>
	public void StatusSelect(string type, int num)
	{
		// TODO num �̑����l���X�e�[�^�X�|�C���g�ȉ��A0�ȏ�ɂ�����
		switch (type)
		{
			// TODO enum�g���ă~�X���N����Ȃ��悤�ɂ�����
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
	/// �X�e�[�^�X�̊���U�茈��
	/// �X�e�[�^�X�ւ̔��f
	/// </summary>
	public void SelectApply()
	{
		// struct��dictionary���o���āA�X�e�[�^�X�̋���ԂƐV��Ԃ�ێ��o���Ă����������

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
