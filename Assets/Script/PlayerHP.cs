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

		// Debug用
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
		// PlayerHPクラスなくてもいいかもしれない。
		// baseHPクラスを上書きしてるので、類似1パターンのみしか存在しないのならそれをベースにしてしまうのもありかな？
		// ↑設計としてどうなんだろうとは思います。

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
