using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void playGameAgain()
    {
        SceneManager.LoadScene(0);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MenuScreen()
    {
        SceneManager.LoadScene(0);
    }
}