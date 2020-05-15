using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{

    bool win = false;
    int max = 60;
    int ile_black;
    double procent;
    gameMan bulletManager;
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = gameMan.instance;
    }

    // Update is called once per frame
    void Update()
    {
        win = CheckWinn();

        if(win && bulletManager.trudnosc == 0){
            Debug.Log("wygrales essa");
            bulletManager.Wait2();
        }
        else if (win && bulletManager.trudnosc == 1){
            Debug.Log("wygrales whuj essa");
            bulletManager.Wait3();
        }
    }

    bool CheckWinn(){
        ile_black = 0;
        for(int i = 0; i < transform.childCount; i++)
        {
            string Go = transform.GetChild(i).tag;
            if(Go == "black_wall"){
                ile_black = ile_black + 1;  
            }      
        }
        bulletManager.procenty = ile_black;
        if(ile_black == 60)
            return true;
        return false;
    }
}
