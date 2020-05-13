using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Dobra, to są początki i wiele rzeczy będzie poprawiane, ale na pewno potrzeba nam cos takiego jak post manager 
//śledzi on każde dodanie stanowiska i usunięcie i wie ile ich jest i jakie one są, te info można wykorzystać
//to zrobienia ładnie tego w ui, zeby wyświetlało stanowiska jakie mamy i zeby mozna było tam klikać cos o nich
public class BulletManager : MonoBehaviour
{
    // Start is called before the first frame updat
    public float RED = 0;
    public float BLUE = 1;
    public float GREEN = 2;

    public Image red_bullet;
    public Image blue_bullet;
    public Image green_bullet;

    public float selected_bullet;

   private void Update() {

        red_bullet.rectTransform.localScale = new Vector2(0.4f, 0.4f);
        blue_bullet.rectTransform.localScale = new Vector2(0.4f, 0.4f);
        green_bullet.rectTransform.localScale = new Vector2(0.4f, 0.4f);

       if(selected_bullet == RED){
           red_bullet.rectTransform.localScale = new Vector2(0.8f, 0.8f);
       }
       else if(selected_bullet == BLUE){
           blue_bullet.rectTransform.localScale = new Vector2(0.8f, 0.8f); 
       }
        else if(selected_bullet == GREEN){
           green_bullet.rectTransform.localScale = new Vector2(0.8f, 0.8f);
       }
   }
}
