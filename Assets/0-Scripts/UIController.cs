using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button newGameButton;
    public Transform backgroundPanel, mainMenuPanel;
    private void Start()
    {
        //backgroundPanel.gameObject.SetActive(false);
        //mainMenuPanel.gameObject.SetActive(false);
        //newGameButton.onClick.AddListener(StartNewGame);
    }
    public void ActivateMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        //backgroundPanel.gameObject.SetActive(true);
        //mainMenuPanel.gameObject.SetActive(true);
    }
    //private void StartNewGame()
    //{
    //    backgroundPanel.gameObject.SetActive(false);
    //    mainMenuPanel.gameObject.SetActive(false);
    //    GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<CharacterController>().StartNewGame();
    //}

}
