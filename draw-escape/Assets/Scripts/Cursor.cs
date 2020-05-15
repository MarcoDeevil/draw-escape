using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{

    BulletManager bulletManager;
    // Start is called before the first frame update
    void Start()
    {

        bulletManager = BulletManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;

        if(bulletManager.selected_bullet == bulletManager.RED){
            this.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if(bulletManager.selected_bullet == bulletManager.GREEN){
            this.GetComponent<SpriteRenderer>().color = new Color(0,190/255f, 0);
        }
        else if(bulletManager.selected_bullet == bulletManager.BLUE){
            this.GetComponent<SpriteRenderer>().color = new Color(77/255f, 219/255f, 255/255f);
        }
    }
}
