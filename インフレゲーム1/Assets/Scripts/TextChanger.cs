using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI text;
    public MoneyManager moneymanager;
    void Start()
    {
        text.text = "Loading...";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = moneymanager.money.ToString();
    }
}
