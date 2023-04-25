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
    protected internal bool isAttack;

    [SerializeField]
    private string attackTarget;

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHP;
        isAttack = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == attackTarget && isAttack)
        {
            collision.gameObject.GetComponent<baseHP>().Defence(attack);
            isAttack = false;
        }
    }

    public virtual void Defence(int damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            Deth();
        }
    }

    public virtual void Deth()
    {
        //基底クラスの実装
        //それぞれの派生クラスで上書きするよ
    }
}
