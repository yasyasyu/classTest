using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : baseHP
{
	public override void Deth()
	{
		// PlayerHP�N���X�Ȃ��Ă�������������Ȃ��B
		// baseHP�N���X���㏑�����Ă�̂ŁA�ގ�1�p�^�[���݂̂������݂��Ȃ��̂Ȃ炻����x�[�X�ɂ��Ă��܂��̂����肩�ȁH
		// ���݌v�Ƃ��Ăǂ��Ȃ񂾂낤�Ƃ͎v���܂��B

		SceneManager.LoadScene("GameOver");
	}
}
