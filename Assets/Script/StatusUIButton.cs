using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusUIButton : MonoBehaviour
{
    [SerializeField]
    // TODO enum使ってミスが起こらないようにしたい
    private string type;

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
            Debug.Log(type + ":Left");
            statusPoint.StatusSelect(type, 1);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(type + ":Right");
            statusPoint.StatusSelect(type, -1);
        }

    }
}
