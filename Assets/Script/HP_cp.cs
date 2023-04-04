using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField]
    private int maxHP;
    [SerializeField]
    private int hp;
    [SerializeField]
    private int attack;
    [SerializeField]
    private string deffenseTarget;

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == deffenseTarget)
        {
            hp -= collision.gameObject.GetComponent<HP>().attack;
        }
    }
}
