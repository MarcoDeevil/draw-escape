using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMap : MonoBehaviour
{
    gameMan audioManager;
     void Start() {
        audioManager = gameMan.instance;
    }
    // Update is called once per frame
    void Update()
    {
        if (audioManager.trudnosc == 1)
            transform.Rotate(0,0,6.0f*2f*Time.deltaTime);
        
    }

}
