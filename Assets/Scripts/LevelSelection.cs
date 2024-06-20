using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public void OnLevelOne()
    {
        SceneManager.LoadScene(1);
    }

    public void OnLevelTwo()
    {
        SceneManager.LoadScene(2);
    }
    public void OnLevelThree()
    {
        SceneManager.LoadScene(3);
    }
    public void OnLevelFour()
    {
        SceneManager.LoadScene(4);
    }
    public void OnLevelFive()
    {
        SceneManager.LoadScene(5);
    }
    public void OnLevelSix()
    {
        SceneManager.LoadScene(6);
    }
}
