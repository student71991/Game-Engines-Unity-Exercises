using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonMenu : MonoBehaviour
{

    public void PlayGame()
    {

            SceneManager.LoadScene("Exercise1");

    }
    public void Exercise2()
    {

        SceneManager.LoadScene("Exercise2");

    }

}
