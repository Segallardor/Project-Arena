using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public bool isGameActive;
    public GameObject titleScreen;
    

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        isGameActive = true;

        titleScreen.gameObject.SetActive(false);
    }
}
