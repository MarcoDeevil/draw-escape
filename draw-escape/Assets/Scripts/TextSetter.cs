using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextSetter : MonoBehaviour
{
    // Start is called before the first frame update
   public TextMeshProUGUI czas;
   public TextMeshProUGUI procenty;
   gameMan gameman;

    // Update is called once per frame
    void Start()
    {
        gameman = gameMan.instance;
        czas.SetText("{0}", gameman.laczny_czas);
        procenty.SetText("{0:1}", gameman.procent);
    }

    public void BacktoGame(){
        gameman.time_in_game = 0;
        SceneManager.LoadScene("Main");
    }
}
