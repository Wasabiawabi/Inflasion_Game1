using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpriteManager : MonoBehaviour
{
    public EnemyLevel lv;
    public SpriteRenderer spriteRenderer;
    public Sprite[] images;

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.sprite = images[lv.nowlevel / 20];
    }
}
