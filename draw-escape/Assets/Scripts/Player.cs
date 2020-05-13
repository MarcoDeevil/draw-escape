using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public BulletManager bulletManager;
    public Rigidbody2D rb;
    public float rotation_speed = 180, moveSpeed = 10f, cd_shoot = 2f;
    Vector2 movement;
    public GameObject[] bullets;
    public GameObject cel;
    int current_weapon_number;
    float shoot, selected_bullet = 0;
    float current_cd_shoot;

    private void Start() {

    }

    void FixedUpdate() {
        Movement();
    }
    void Update() {
        bulletManager.selected_bullet = selected_bullet;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        shoot = Input.GetAxisRaw("Fire1");

        ChangeWeapon();
        Shoot();  

        current_cd_shoot -= Time.deltaTime;  
    }
    void Shoot(){
        
        if(shoot == 1 && current_cd_shoot <= 0){
            GameObject bullet = Instantiate(bullets[(int)selected_bullet], cel.transform.position , cel.transform.rotation);
            bullet.GetComponent<Bullet>().bullet_number = selected_bullet;
            Physics2D.IgnoreCollision(bullet.GetComponent<BoxCollider2D>(), GetComponent<CircleCollider2D>());
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(cel.transform.right * 10, ForceMode2D.Impulse);
            current_cd_shoot = cd_shoot;
        }
    }

    void ChangeWeapon(){
        if(Input.GetKeyDown(KeyCode.E)){
            selected_bullet = nfmod(selected_bullet+1, 3);
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            selected_bullet= nfmod(selected_bullet-1, 3);
        }
    }
   
    private void Movement(){
        rb.MovePosition(rb.position + movement * moveSpeed*Time.fixedDeltaTime); 
    }
     private void OnCollisionEnter2D(Collision2D collision) {
         if(collision.gameObject.tag == "Enemy"){
             gameObject.GetComponent<AudioSource>().Play();       
         }
     }
       float nfmod(float a, float b)
    {
        return a - b * Mathf.Floor(a / b);
    }   
}