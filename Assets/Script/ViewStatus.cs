using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewStatus : MonoBehaviour
{
	private StatusPoint statusPoint;
	private string type;
	private Text viewText;

	void Start()
	{
		type = GetComponentInParent<StatusUIButton>().type;
		viewText = gameObject.GetComponent<Text>();
		statusPoint = GameObject.Find("Player").GetComponent<StatusPoint>();
		TextUpdate();
	}
	public void TextUpdate()
	{
		int viewPoint;
		viewPoint = statusPoint.StatusUI(type);
		Debug.Log(viewPoint);
		viewText.text = viewPoint.ToString();
	}
}
