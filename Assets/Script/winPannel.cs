﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class winPannel : MonoBehaviour
{
    // Start is called before the first frame update
    public void nextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
