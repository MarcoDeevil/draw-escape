using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform balle;
    public Transform aim;
    Player player;
    private int amorti = 10;
    private bool faireFeu = true;
    public float ballSpeed = 10;
    public float cadence = 1;
    public float cd = 2.5f;
    float current_cd;
    public float ball_speed = 6f;
    public AudioClip weaponSound;

    // Start is called before the first frame update
    void Start()
    {
        current_cd = cd;
        player = Player.instance;
    }

    // Update is called once per frame
    void Update()
    {
        current_cd -= Time.deltaTime;
        if(player){
            transform.LookAt(player.transform.position);
            transform.Rotate(new Vector3(0,-90,0),Space.Self);//correcting the original rotation

             if(current_cd <= 0){
                 attack();
             }

        }

    }

    void attack(){

          float transformation = Random.Range(0.0f, 1.0f);
          if(transformation < 0.8f){
            var projectile = Instantiate(balle, aim.transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody2D>().AddForce(aim.transform.right * 5, ForceMode2D.Impulse);
           
          }
        current_cd = cd;
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            Debug.Log("gracz wszedl w wiezyczke");
        }
    }
}
