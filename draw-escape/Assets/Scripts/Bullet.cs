﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public BulletManager  bulletManager;
    public float bullet_number;
    AudioManager audioManager;
  
  /// <summary>
  /// Start is called on the frame when a script is enabled just before
  /// any of the Update methods is called the first time.
  /// </summary>
  void Start()
  {
    audioManager = AudioManager.instance;
    if(audioManager == null){
        Debug.LogError("No AudioManager found in the scene");
    }
    bulletManager = GameObject.Find("bullet_manager").GetComponent<BulletManager>();
  }
   void OnCollisionEnter2D(Collision2D other)
   {
       if(bullet_number == bulletManager.RED && other.gameObject.tag == "red_wall"){
           audioManager.PlaySound("wall_hit");
           Debug.Log("red to red");
           Destroy(gameObject);
       }

       else if(bullet_number == bulletManager.BLUE && other.gameObject.tag == "blue_wall"){
            audioManager.PlaySound("wall_hit");
            Debug.Log("blue to blue");
            Destroy(gameObject);
       }

       else if(bullet_number == bulletManager.GREEN && other.gameObject.tag == "green_wall"){
           audioManager.PlaySound("wall_hit");
           Debug.Log("green_to_green");
           Destroy(gameObject);
       }

       else {
           audioManager.PlaySound("bad_wall_hit");
           StartCoroutine(Wait());
           
       }
   }

   IEnumerator Wait()
      {      
          yield return new WaitForSeconds (0.3f);
          SceneManager.LoadScene("Main");
      }
   
}
