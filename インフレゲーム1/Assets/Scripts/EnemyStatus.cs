using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyStatus : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemyManager enemymanager;
    public EnemyHPManager enemyhpmanager;
    public TextMeshProUGUI text;
    float hp,money;

    void Start()
    {
        hp = 100f;
        money = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        hp = enemyhpmanager.enemyhp[enemymanager.enemylevel.nowlevel];
        money = enemymanager.enemymoney[enemymanager.enemylevel.nowlevel];
        text.text = "HP: " + hp.ToString("F1") + " Cost: " + money.ToString("F1");
    }
}
