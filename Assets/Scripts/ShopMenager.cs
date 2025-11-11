
using UnityEngine;
using UnityEngine.UI;

public class ShopMenager : MonoBehaviour
{
    public Button BuyButton1;
    public Button BuyButton2;
    public Button BuyButton3;
    public Text scoreCoins;
    public StationController stationController;
    public Fire fire;
    public ButtonRotate buttonRotate;
    void Start()
    {
        CheckPurchasable();
    }
    public void CheckPurchasable()
    {
        if (CoinCounter.coins >= 10)
        {
            BuyButton1.interactable = true;
            BuyButton2.interactable = true;
            BuyButton3.interactable = true;
        }
        else
        {
            BuyButton1.interactable = false;
            BuyButton2.interactable = false;
            BuyButton3.interactable = false;
        }
    }
    public void OnClickBuy1()
    {
        CoinCounter.coins -= 10;
        scoreCoins.text = CoinCounter.coins.ToString();
        stationController.HealthUp();
    }
    public void OnClickBuy2()
    {
        CoinCounter.coins -= 10;
        scoreCoins.text = CoinCounter.coins.ToString();
        fire.ReloadUp();
    }
    public void OnClickBuy3()
    {
        CoinCounter.coins -= 10;
        scoreCoins.text = CoinCounter.coins.ToString();
        buttonRotate.SpeedUp();
    }
}
