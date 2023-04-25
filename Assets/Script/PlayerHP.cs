using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : baseHP
{
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			base.isAttack = true;

			Invoke("AttackPersistence",1);
		}

		// Debug�p
		if (base.isAttack)
		{
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
		else
		{
			gameObject.GetComponent<Renderer>().material.color = Color.white;
		}

	}
	void AttackPersistence()
	{
		base.isAttack = false;
	}
	public override void Deth()
	{
		// PlayerHP�N���X�Ȃ��Ă�������������Ȃ��B
		// baseHP�N���X���㏑�����Ă�̂ŁA�ގ�1�p�^�[���݂̂������݂��Ȃ��̂Ȃ炻����x�[�X�ɂ��Ă��܂��̂����肩�ȁH
		// ���݌v�Ƃ��Ăǂ��Ȃ񂾂낤�Ƃ͎v���܂��B

		SceneManager.LoadScene("GameOver");
	}
	public void HPUp()
	{
		base.hp += 10;
		base.maxHP += 10;
	}

	public void AttackUp()
	{
		base._attack += 10;
	}
}
