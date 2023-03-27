using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int level;

    [Space] 
    public int currHealth;
    public int maxHealth;

    [Space]
    public int currExp;
    public int maxExp;
    
    [Space] 
    public int currMoney;

    public Slider healthBar;
    public Slider expBar;

    public TextMeshProUGUI healthSliderDisplay;
    public TextMeshProUGUI expSliderDisplay;
    public TextMeshProUGUI expLevelDisplay;
    public TextMeshProUGUI playerMoneyDisplay;

    private void Start()
    {
        
    }

    public void Update()
    {
        ChangeSliderUI();
        LevelUp();
    }

    public void ChangeSliderUI()
    {
        healthBar.value = currHealth;
        expBar.value = currExp;

        healthBar.maxValue = maxHealth;
        expBar.maxValue = maxExp;

        healthSliderDisplay.text = currHealth + " / " + maxHealth;
        expSliderDisplay.text = currExp + " / " + maxExp;
        playerMoneyDisplay.text = "Coins: " + currMoney;

    }

    public void LevelUp()
    {
        if (expBar.value >= maxExp)
        {
            level += 1;
            expLevelDisplay.text = "Level: " + level;
            expSliderDisplay.text = (currExp = 0).ToString();
            expSliderDisplay.text = (maxExp = (int)(maxExp * 1.3f)).ToString(CultureInfo.CurrentCulture);
            expSliderDisplay.text = (maxHealth = (int)(maxHealth + 2)).ToString(CultureInfo.CurrentCulture);
        }
    }
}
