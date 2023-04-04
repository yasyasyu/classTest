using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private bool flg;
    [SerializeField]
    private float power;
    // Start is called before the first frame update
    void Start()
    {
        flg = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && flg)
        {
            this.GetComponent<Rigidbody>().AddForce(0, power, 0);
            flg = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Touch");
        flg = true;
    }
}
