using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
     gameMan gameman;

    // Update is called once per frame
    void Start()
    {
        gameman = gameMan.instance;
    }
    // Start is called before the first frame update
  public void BacktoGame(){
        gameman.time_in_game = 0;
        SceneManager.LoadScene("Main");
    }
}
