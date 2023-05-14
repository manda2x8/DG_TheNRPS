using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void Startbutton(){
        SceneManager.LoadScene("CodingSimulation");
        Debug.Log("123");
    }
}
