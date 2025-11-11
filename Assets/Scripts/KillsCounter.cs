using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsCounter : MonoBehaviour
{
    public static int kills;
    public Text score_game;
    public Text score_pause;
    public Text finScore;

    private void Start()
    {
        kills = 0;
    }
    void Update()
    {
        score_game.text = kills.ToString("СЧЁТ: ") + kills;
        score_pause.text = kills.ToString("Ваш СЧЁТ: ") + kills;
        finScore.text = kills.ToString("Игра окончена \n Ваш СЧЁТ: ") + kills;
    }
}
