﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainGame : MonoBehaviour
{
    // Start is called before the first frame update
  public void LoadMain(){
      SceneManager.LoadScene("Main");
  }

  public void PlayJD(){
      GetComponent<AudioSource>().Play();
  }
}
