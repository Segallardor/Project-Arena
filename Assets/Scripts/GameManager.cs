using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    public TextMeshProUGUI gameOverText;
    

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
