using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    public void FirstScene(){
        SceneManager.LoadScene("MainMenu");
    }
}
