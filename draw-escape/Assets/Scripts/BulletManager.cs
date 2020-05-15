using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    public static BulletManager instance;
    AudioManager audioManager;

    public Image red_bullet;
    public Image blue_bullet;
    public Image green_bullet;

    public float time_in_game = 0;
    public float laczny_czas = 0;
    public float procenty = 0;
    

    public float selected_bullet ;

    void Start()
    {
        audioManager = AudioManager.instance;
    }
     void Awake() {
        //DontDestroyOnLoad(gameObject);
        if(instance != null){
            Debug.LogError("More than one AudioManager in the scene");
        }
        else {
            instance = this;
        }
    }

    private void Update() {
        if(SceneManager.GetActiveScene().name == "Main"){
                time_in_game += Time.deltaTime; 
        
                red_bullet.rectTransform.localScale = new Vector2(1f, 1f);
                blue_bullet.rectTransform.localScale = new Vector2(1f, 1f);
                green_bullet.rectTransform.localScale = new Vector2(1f, 1f);

            if(selected_bullet == RED){
                red_bullet.rectTransform.localScale = new Vector2(2f, 2f);
            }
            else if(selected_bullet == BLUE){
            blue_bullet.rectTransform.localScale = new Vector2(2f, 2f); 
        }
            else if(selected_bullet == GREEN){
            green_bullet.rectTransform.localScale = new Vector2(2f, 2f);
        }
        }
    }

    
}
