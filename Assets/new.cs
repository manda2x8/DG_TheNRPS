using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButton : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

