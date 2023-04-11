using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experiment : MonoBehaviour
{
    // Start is called before the first frame update
    private int _exp;
    private int _nextExp;
    private int _level;

    void Start()
    {
        _exp = 0;
        _nextExp = 10;
        _level = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LevelUp()
    {
        _level++;
        _exp -= _nextExp;
        StatusUp();
        NextExpCalc();
	}
    private void StatusUp()
    {
        this.GetComponent<PlayerHP>().HPUp();
        this.GetComponent<PlayerHP>().AttackUp();
    }

    private void NextExpCalc()
    {
        _nextExp += 10;
    }

    public void GetExp(int add)
    {
        _exp += add;
        while (_exp >= _nextExp)
        {
            LevelUp();
        }
    }
}
