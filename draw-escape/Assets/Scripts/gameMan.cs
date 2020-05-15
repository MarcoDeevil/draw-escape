using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMan : MonoBehaviour
{
    public static gameMan instance;
    public float time_in_game = 0;
    public float laczny_czas = 0;
    public float procenty = 0;
    public float procent;
    public int trudnosc = 0;
    
     void Awake() {
        DontDestroyOnLoad(gameObject);
        if(instance != null){
            Debug.LogError("More than one AudioManager in the scene");
        }
        else {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(SceneManager.GetActiveScene().name == "Main")
            time_in_game += Time.deltaTime;
    }

    public IEnumerator Wait()
      {  
          if(trudnosc == 1){
            procent = (procenty/60f)*100f;
            laczny_czas = time_in_game;
            yield return new WaitForSeconds (0.3f);
            SceneManager.LoadScene("dawajGosciu");
          }
          else {
           procent = (procenty/60f)*100f;
           laczny_czas = time_in_game;
            yield return new WaitForSeconds (0.3f);
           SceneManager.LoadScene("AfterMatch");
          }
      }

      public void Wait2()
      { 
        trudnosc = 1;
        laczny_czas = time_in_game;
        //yield return new WaitForSeconds (0.3f);
        SceneManager.LoadScene("AfterMatchWin");
                              
      }

      public void Wait3()
      {  
          procent = (procenty/60f)*100f;
          laczny_czas = time_in_game;
          //yield return new WaitForSeconds (0.1f);
          SceneManager.LoadScene("JAPIERDOLE");
      }
}
