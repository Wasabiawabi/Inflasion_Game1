using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    public float speed = 0.1f;
    Vector3 enemyPos;
    float angle;
    float damage;
    EnemyHPManager enemyHPManager;
    public Shooting shooting;
    public void SetAngleAndEnemyAndDamage(GameObject enemy, float d)
    {
        //enemy = GameObject.Find("Enemy");
        enemyHPManager = enemy.GetComponent<EnemyHPManager>();
        // Shooter�̉�]�����g�ɓK�p�iShooting.cs�Ŕ��ˎ��ɉ�]�ς݂Ȃ�s�v�j
        enemyPos = enemy.transform.position;
        angle = Mathf.Atan2(enemyPos.y - transform.position.y, enemyPos.x - transform.position.x) * Mathf.Rad2Deg;
        damage = d;
        //Debug.Log(angle);
    }

    void Update()
    {
        transform.position += new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad) * speed, Mathf.Sin(angle * Mathf.Deg2Rad) * speed, 0);
        if(Physics2D.OverlapCircle(transform.position, 0.1f)!= null && Physics2D.OverlapCircle(transform.position, 0.1f).CompareTag("enemy"))
        {
            enemyHPManager.takeddamage += damage;
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
