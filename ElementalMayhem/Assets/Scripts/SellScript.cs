using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellScript : MonoBehaviour
{
    
    public int startingMoney = 1000;
    public Color[] availableColors;
    public int[] colorPrices;

    private int currentMoney;
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        currentMoney = startingMoney;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Money: " + currentMoney);

        for (int i = 0; i < availableColors.Length; i++)
        {
            if (GUI.Button(new Rect(10, 40 + i * 30, 150, 20), "Buy " + availableColors[i] + " for " + colorPrices[i]))
            {
                BuyColor(i);
            }
        }
    }

    private void BuyColor(int colorIndex)
    {
        if (currentMoney >= colorPrices[colorIndex])
        {
            currentMoney -= colorPrices[colorIndex];
            rend.material.color = availableColors[colorIndex];
        }
        else
        {
            Debug.Log("Not enough money to buy " + availableColors[colorIndex]);
        }
    }
}
