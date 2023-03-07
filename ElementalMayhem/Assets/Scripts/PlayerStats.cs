using System;
using System.Collections;
using System.Collections.Generic;
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

    [Space] 
    public int strength;
    public int intelligence;
    public int endurance;
    public int agility;
    public int speed;

    public Slider healthBar;
    public Slider expBar;

    public TextMeshProUGUI healthSliderDisplay;
    public TextMeshProUGUI expSliderDisplay;

    private void Start()
    {
        
    }

    public void Update()
    {
        ChangeSliderUI();
    }

    public void ChangeSliderUI()
    {
        healthBar.value = currHealth;
        expBar.value = currExp;

        healthBar.maxValue = maxHealth;
        expBar.maxValue = maxExp;

        healthSliderDisplay.text = currHealth + " / " + maxHealth;
        expSliderDisplay.text = currExp + " / " + maxExp;
    }
}
