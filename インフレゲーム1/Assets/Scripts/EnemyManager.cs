using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] enemiesimges;
    public SpriteRenderer EnemyImage;
    public bool spawned = true;
    int enemyidx = 0;
    public float[] enemymoney;
    public MoneyManager moneymanager;
    public EnemyLevel enemylevel;
    // Update is called once per frame

    private void Start()
    {
        enemymoney = new float[100];
        EnemyImage.sprite = enemiesimges[enemyidx];
        enemymoney[1] = 1f;
        for (int i = 2; i < 100; i++) enemymoney[i] = enemymoney[i - 1] * 1.1f;
    }
    void Update()
    {
     if(!spawned)
        {
            //Debug.Log(enemylevel.nowlevel);
            moneymanager.money += enemymoney[enemylevel.nowlevel];
            spawned = true;
        }
    }
}
