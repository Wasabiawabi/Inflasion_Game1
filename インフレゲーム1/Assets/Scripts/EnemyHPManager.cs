using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHPManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shooter;
    float damage;
    public Slider slider;
    public float takeddamage = 0;
    EnemyManager enemyManager;
    public EnemyLevel enemylevel;
    public float[] enemyhp;
    void Start()
    {
        enemyhp = new float[100];
        slider.value = slider.maxValue;
        enemyManager = Camera.main.GetComponent<EnemyManager>();
        enemyhp[1] = 100f;
        for (int i = 2; i < 100; i++) enemyhp[i] = enemyhp[i - 1] * 1.1f;
    }
    void Update()
    {
        damage = shooter.GetComponent<Shooting>().damage;
        slider.value -= takeddamage;
        takeddamage = 0;
        if (slider.value <= 0)
        {
            enemyManager.spawned = false;
            slider.maxValue = enemyhp[enemylevel.nowlevel];
            slider.value = slider.maxValue;
            //Debug.Log("Destroyed");
        }
    }
}
