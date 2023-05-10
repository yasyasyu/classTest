using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusUIButton : MonoBehaviour
{
    [SerializeField]
    // TODO enum�g���ă~�X���N����Ȃ��悤�ɂ�����
    private string _type;

    public string type {
        get { return _type; }
    }

    private StatusPoint statusPoint;
    void Start()
    {
        statusPoint = GameObject.Find("Player").GetComponent<StatusPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPress()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(_type + ":Left");
            statusPoint.StatusSelect(_type, 1);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(_type + ":Right");
            statusPoint.StatusSelect(_type, -1);
        }

    }
}
