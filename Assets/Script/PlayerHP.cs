using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : baseHP
{
	public override void Deth()
	{
		// PlayerHPクラスなくてもいいかもしれない。
		// baseHPクラスを上書きしてるので、類似1パターンのみしか存在しないのならそれをベースにしてしまうのもありかな？
		// ↑設計としてどうなんだろうとは思います。

		SceneManager.LoadScene("GameOver");
	}
}
