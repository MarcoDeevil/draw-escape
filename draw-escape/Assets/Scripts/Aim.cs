using UnityEngine;
using System.Collections;
 
public class Aim : MonoBehaviour {
     
    private Vector3 mousePos;
    public Transform target;

    //public GameObject player;
    private Vector3 object_pos;
    private float angle;
 
    void FixedUpdate()
    {
           MouseL();
    }

    void MouseL(){
         //Gets mouse position, you can define Z to be in the position you want the weapon to be in
         mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
         Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
         lookPos = lookPos - transform.position;
         float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
         transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
     }
}
 