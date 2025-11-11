
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseActivator : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject pause_button;
    public GameObject intrface;
    public GameObject resume_button;
    public GameObject score_pause;
    public GameObject finScore;
    public GameObject shop_panel;
    public ButtonRotate br;

    public void Pause()
    {
        intrface.SetActive(false);
        pausePanel.SetActive(true);
        score_pause.SetActive(true);
        finScore.SetActive(false);
        Time.timeScale = 0f;
        br.PauseOff();
    }
    public void Resume()
    {
        intrface.SetActive(true);
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void OpenMenuScene()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void GameOver()
    {
        intrface.SetActive(false);
        pausePanel.SetActive(true);
        score_pause.SetActive(false);
        finScore.SetActive(true);
        resume_button.SetActive(false);
        Time.timeScale = 0f;
    }
    public void OpenShop()
    {
        intrface.SetActive(false);
        shop_panel.SetActive(true);
        Time.timeScale = 0f;
        br.PauseOff();
    }
    public void CloseShop()
    {
        intrface.SetActive(true);
        shop_panel.SetActive(false);
        Time.timeScale = 1f;
    }
}