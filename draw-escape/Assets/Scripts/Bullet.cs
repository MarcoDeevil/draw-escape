using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    BulletManager  bulletManager;
    gameMan gameman;
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
    bulletManager = BulletManager.instance;
    gameman = gameMan.instance;
  }
   void OnCollisionEnter2D(Collision2D other)
   {
       if(bullet_number == bulletManager.RED && other.gameObject.tag == "red_wall"){
           gameObject.SetActive(false);
           audioManager.PlaySound("wall_hit");
           Debug.Log("red to red");
           other.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
           //other.gameObject.tag = "black_wall";
           Destroy(gameObject);
       }

       else if(bullet_number == bulletManager.BLUE && other.gameObject.tag == "blue_wall"){
           gameObject.SetActive(false);
            audioManager.PlaySound("wall_hit");
            Debug.Log("blue to blue");
            other.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
            //other.gameObject.tag = "black_wall";
            Destroy(gameObject);
       }

       else if(bullet_number == bulletManager.GREEN && other.gameObject.tag == "green_wall"){
           gameObject.SetActive(false);
           audioManager.PlaySound("wall_hit");
           Debug.Log("green_to_green");
           other.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
           //other.gameObject.tag = "black_wall";
           Destroy(gameObject);
       }
       else if(other.gameObject.tag == "enemy_bullet"){
           Destroy(other.gameObject);
           Destroy(gameObject);
       }

       else {
           audioManager.PlaySound("bad_wall_hit");   
           gameObject.SetActive(false);        
           gameman.StartCoroutine(gameman.Wait());       
          
       }
   }  
}
