using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusUIButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPress()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(gameObject.name + ":Left");
		}
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(gameObject.name + ":Right");
        }

    }
}
