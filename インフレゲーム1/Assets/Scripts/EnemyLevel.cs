using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EnemyLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI text;
    public int nowlevel = 1;
    void Start()
    {
        text.text = nowlevel.ToString();
    }

    void Update()
    {
     if(Input.GetKey("up")) levelup();
     if (Input.GetKey("down")) leveldown();
    }

    public void levelup()
    {
        if (nowlevel == 99) return;
        nowlevel += 1;
        text.text = nowlevel.ToString();
    }

    public void leveldown()
    {
        if (nowlevel == 1)return;
        nowlevel -= 1;
        text.text = nowlevel.ToString();
    }
}
