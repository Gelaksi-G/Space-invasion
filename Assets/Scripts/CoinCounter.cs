using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public static int coins; 
    public Text scoreCoins;
    public void Start()
    {
        scoreCoins.text = coins.ToString();
        coins = 0;
    }
    public void CoinPicker()
    {

        scoreCoins.text = coins.ToString();
    }
    void Update()
    {
        scoreCoins.text = coins.ToString();
    }
}
