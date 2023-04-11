using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseHP : MonoBehaviour
{
    [SerializeField]
    protected internal int maxHP;
    [SerializeField]
    protected internal int hp;
    [SerializeField]
    protected internal int _attack;
    public int attack{
        get { return _attack; }
    }
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
            hp -= collision.gameObject.GetComponent<baseHP>().attack;
            if (hp<0)
            {
                Deth();
            }
        }
    }

    public virtual void Deth()
    {
        //基底クラスの実装
        //それぞれの派生クラスで上書きするよ
    }
}
