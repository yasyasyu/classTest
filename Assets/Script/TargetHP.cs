using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetHP : baseHP
{
	public override void Deth()
	{
		//���ꂼ��̏�Ԃɍ��킹�ă��\�b�h�̒��g�E��ނ�ǉ����悤�B
		SceneManager.LoadScene("GameClear");
	}
}
