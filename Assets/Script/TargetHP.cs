using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetHP : baseHP
{
	[SerializeField]
	private int exp;
	public override void Deth()
	{
		//それぞれの状態に合わせてメソッドの中身・種類を追加しよう。
		//SceneManager.LoadScene("GameClear");
		
	}
}
