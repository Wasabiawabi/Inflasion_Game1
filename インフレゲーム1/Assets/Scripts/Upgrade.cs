using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Upgrade : MonoBehaviour
{
    // Start is called before the first frame update
    public MoneyManager moneyManager;
    public Shooting shootershooting;
    public Shooting skill1shooting;
    public Shooting skill2shooting;
    public Shooting skill3shooting;
    public Shooting skill4shooting;
    public TextMeshProUGUI balllevel;
    public TextMeshProUGUI ballpow;
    public TextMeshProUGUI ballnextcost;
    public TextMeshProUGUI skill1level;
    public TextMeshProUGUI skill1pow;
    public TextMeshProUGUI skill1cost;
    public TextMeshProUGUI skill2level;
    public TextMeshProUGUI skill2pow;
    public TextMeshProUGUI skill2cost;
    public TextMeshProUGUI skill3level;
    public TextMeshProUGUI skill3pow;
    public TextMeshProUGUI skill3cost;
    public TextMeshProUGUI skill4level;
    public TextMeshProUGUI skill4pow;
    public TextMeshProUGUI skill4cost;
    public int balllv = 1;
    public int skill1lv = 0;
    public int skill2lv = 0;
    public int skill3lv = 0;
    public int skill4lv = 0;
    public float upgradeballCost = 3f;
    public float upgradeskill1cost = 5f;
    public float upgradeskill2cost = 10f;
    public float upgradeskill3cost = 22f;
    public float upgradeskill4cost = 50f;

    void Start()
    {
        balllevel.text = "Ball lv. " + balllv.ToString();
        ballpow.text = "pow " + shootershooting.damage.ToString("F1");
        ballnextcost.text = upgradeballCost.ToString("F1");
        skill1level.text = "Skill1 lv. " + skill1lv.ToString();
        skill1pow.text = "pow " + (skill1shooting.damage).ToString("F1");
        skill1cost.text = upgradeskill1cost.ToString("F1");
        skill2level.text = "Skill2 lv. " + skill2lv.ToString();
        skill2pow.text = "pow " + (skill2shooting.damage).ToString("F1");
        skill2cost.text = upgradeskill2cost.ToString("F1");
    }

    public void UpgradeBall()
    {
        if (moneyManager.money >= upgradeballCost)
        {
            moneyManager.money -= upgradeballCost;
            balllevel.text = "Ball lv. " + (++balllv).ToString();
            shootershooting.damage *= 1.1f;
            ballpow.text = "pow " + shootershooting.damage.ToString("F1");
            upgradeballCost *= 1.1f;
            ballnextcost.text =  upgradeballCost.ToString("F1");
        }
    }

    public void UpgradeSkill1()
    {
        if(skill1lv == 0 && moneyManager.money >= upgradeskill1cost)
        {
            moneyManager.money -= upgradeskill1cost;
            skill1level.text = "Skill1 lv. " + (++skill1lv).ToString();
            skill1shooting.damage = 3f;
            skill1pow.text = "pow " + (skill1shooting.damage).ToString("F1");
            upgradeskill1cost *= 1.1f;
            skill1cost.text = upgradeskill1cost.ToString("F1");
        }
        else if (moneyManager.money >= upgradeskill1cost)
        {
            moneyManager.money -= upgradeskill1cost;
            skill1level.text = "Skill1 lv. " + (++skill1lv).ToString();
            skill1shooting.damage *= 1.1f;
            skill1pow.text = "pow " + (skill1shooting.damage).ToString("F1");
            upgradeskill1cost *= 1.1f;
            skill1cost.text = upgradeskill1cost.ToString("F1");
        }
    }

    public void UpgradeSkill2()
    {
        if (skill2lv == 0 && moneyManager.money >= upgradeskill2cost)
        {
            moneyManager.money -= upgradeskill2cost;
            skill2level.text = "Skill2 lv. " + (++skill2lv).ToString();
            skill2shooting.damage = 10f;
            skill2pow.text = "pow " + (skill2shooting.damage).ToString("F1");
            upgradeskill2cost *= 1.1f;
            skill2cost.text = upgradeskill2cost.ToString("F1");
        }
        else if (moneyManager.money >= upgradeskill2cost)
        {
            moneyManager.money -= upgradeskill2cost;
            skill2level.text = "Skill2 lv. " + (++skill2lv).ToString();
            skill2shooting.damage *= 1.1f;
            skill2pow.text = "pow " + (skill2shooting.damage).ToString("F1");
            upgradeskill2cost *= 1.1f;
            skill2cost.text = upgradeskill2cost.ToString("F1");
        }
    }

    public void UpgradeSkill3()
    {
        if (skill3lv == 0 && moneyManager.money >= upgradeskill3cost)
        {
            moneyManager.money -= upgradeskill3cost;
            skill3level.text = "Skill3 lv. " + (++skill3lv).ToString();
            skill3shooting.damage = 30f;
            skill3pow.text = "pow " + (skill3shooting.damage).ToString("F1");
            upgradeskill3cost *= 1.1f;
            skill3cost.text = upgradeskill3cost.ToString("F1");
        }
        else if (moneyManager.money >= upgradeskill3cost)
        {
            moneyManager.money -= upgradeskill3cost;
            skill3level.text = "Skill3 lv. " + (++skill3lv).ToString();
            skill3shooting.damage *= 1.1f;
            skill3pow.text = "pow " + (skill3shooting.damage).ToString("F1");
            upgradeskill3cost *= 1.1f;
            skill3cost.text = upgradeskill3cost.ToString("F1");
        }
    }

    public void UpgradeSkill4()
    {
        if (skill4lv == 0 && moneyManager.money >= upgradeskill4cost)
        {
            moneyManager.money -= upgradeskill4cost;
            skill4level.text = "Skill4 lv. " + (++skill4lv).ToString();
            skill4shooting.damage = 100f;
            skill4pow.text = "pow " + (skill4shooting.damage).ToString("F1");
            upgradeskill4cost *= 1.1f;
            skill4cost.text = upgradeskill4cost.ToString("F1");
        }
        else if (moneyManager.money >= upgradeskill4cost)
        {
            moneyManager.money -= upgradeskill4cost;
            skill4level.text = "Skill4 lv. " + (++skill4lv).ToString();
            skill4shooting.damage *= 1.1f;
            skill4pow.text = "pow " + (skill4shooting.damage).ToString("F1");
            upgradeskill4cost *= 1.1f;
            skill4cost.text = upgradeskill4cost.ToString("F1");
        }
    }
}
