using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject enemy;
    Vector3 enemyPos;
    float angle;
    public GameObject bulletPrefab;
    public SpriteRenderer spriteRenderer;
    public Upgrade upgrade;
    public float damage = 1f;
    public float attackSpeed = 1f;
    public float attackspeeddenominator = 1f;
    float nowtime = 0f;
    float beforeatackedtime = 0f;
    public bool ThisIsSkill1 = false;
    public bool ThisIsSkill2 = false;
    public bool ThisIsSkill3 = false;
    public bool ThisIsSkill4 = false;

    void Start()
    {
        if (ThisIsSkill1) spriteRenderer.enabled = false;
        if (ThisIsSkill2) spriteRenderer.enabled = false;
        if (ThisIsSkill3) spriteRenderer.enabled = false;
        if (ThisIsSkill4) spriteRenderer.enabled = false;
        enemyPos = enemy.transform.position;
    }
    void Update()
    {
        if(ThisIsSkill1 && upgrade.skill1lv < 1) return;
        if(ThisIsSkill1 && upgrade.skill1lv >= 1) spriteRenderer.enabled = true;
        if (ThisIsSkill2 && upgrade.skill2lv < 1) return;
        if (ThisIsSkill2 && upgrade.skill2lv >= 1) spriteRenderer.enabled = true;
        if (ThisIsSkill3 && upgrade.skill3lv < 1) return;
        if (ThisIsSkill3 && upgrade.skill3lv >= 1) spriteRenderer.enabled = true;
        if (ThisIsSkill4 && upgrade.skill4lv < 1) return;
        if (ThisIsSkill4 && upgrade.skill4lv >= 1) spriteRenderer.enabled = true;
        nowtime += Time.deltaTime;
        // マウスとゲームオブジェクトの角度を測る
        enemyPos = enemy.transform.position;
        angle = Mathf.Atan2(enemyPos.y - transform.position.y, enemyPos.x - transform.position.x) * Mathf.Rad2Deg;

        gameObject.transform.rotation = Quaternion.Euler(0, 0, angle);
        if (nowtime - beforeatackedtime > attackSpeed / attackspeeddenominator)
        { 
            GameObject ball = Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y + Random.Range(-0.5f, 0.5f), 0),Quaternion.Euler(0, 0, angle));
            ball.GetComponent<Move>().SetAngleAndEnemyAndDamage(enemy , damage);
            beforeatackedtime = nowtime;
        }
    }
}
