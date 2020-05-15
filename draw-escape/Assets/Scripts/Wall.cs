using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    Color current_color;
    string current_tag;
    public GameObject turret;
    SpriteRenderer spriteRenderer;
    List<string> keyList = new List<string>() {
        "red_wall", "green_wall", "blue_wall"
    };
    
    
   
   private void Start() {     
    spriteRenderer = this.GetComponent<SpriteRenderer>();
    string randomString = keyList[Random.Range(0, keyList.Count)];
    gameObject.tag = randomString;
    if(gameObject.tag == "red_wall")
        spriteRenderer.color = Color.red;
    else if (gameObject.tag == "green_wall")
        spriteRenderer.color = new Color(0, 190/255f, 0);
    else if (gameObject.tag == "blue_wall")
        spriteRenderer.color = new Color(77/255f, 219/255f, 255/255f);
    else {
        spriteRenderer.color = Color.black;
    }       
    
   }
   void OnCollisionEnter2D(Collision2D other){
        current_tag = gameObject.tag;
        if(other.gameObject.tag == "bullet" && current_tag != "black_wall"){
            gameObject.tag = "black_wall";
            float transformation = Random.Range(0.0f, 1.0f);
            if(transformation < 0.5f){
                turret.SetActive(true);
            }
            gameObject.tag = "black_wall";
        }

        else if (other.gameObject.tag == "enemy_bullet"){
            Destroy(other.gameObject);
        }
    }
 
}
