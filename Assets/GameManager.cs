using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    public static float a = 0f;
    public static float b = 0f;
    public Text score;
    public GameObject Rone;
   
    public GameObject rd;
    public GameObject Rtwo;
    public GameObject Rthree;
    public GameObject cube1;
    public GameObject Rfour;
    public GameObject Rfive;
    public Text Indiscore;
    public GameObject Rsix;
    public GameObject fireworks;
    public GameObject gameovers;
    public FirstPersonController movement;
    public new Renderer ground;
    public GameObject fire;

    public int y;
    public GameObject Rseven;
    public GameObject Reight;
    public GameObject Rnine;
    public GameObject Rten;
    public GameObject Rtwelve;
    public GameObject Relevan;

    public GameObject PauseUI;
    public GameObject LevelComplete;
    bool gamehasended;




    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    public IEnumerator time()
    {
        yield return new WaitForSeconds(4);
    }
    public IEnumerator Ends()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void CompleteL()
    {
        if (gamehasended == false)
        {
            movement.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            LevelComplete.SetActive(true);
           


        }
    }

    // Update is called once per frame
    void Update()
    {
        score.text = a.ToString();
        Indiscore.text = b.ToString();

       





        y = Random.Range(0, 5);
        switch (y)
        {
            case 1:
              //  renderer.material.color = Color.gray;

               ground.material.color = Color.black;
                break;
            case 2:
               // renderer.material.color = Color.green;
                ground.material.color = Color.red;
                break;
            case 3:
              //  renderer.material.color = Color.red;
                  ground.material.color = Color.cyan;
                break;
            case 4:
              //  renderer.material.color = Color.blue;
                 ground.material.color = Color.blue;
                break;
            case 5:
             //   renderer.material.color = Color.magenta;
                 ground.material.color = Color.yellow;
                break;

        }
        if (rd.transform.position.y < 0.00f)
        {
            
            movement.enabled = false;
            StartCoroutine(FindObjectOfType<GameManager>().gameover());
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            movement.enabled = false;
            //   scoress.SetActive(false);
            Time.timeScale = 0f;
            PauseUI.SetActive(true);



        }
    }
    public void Restart()
    {
        Cursor.visible = false;
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        a = 0;
    }
    public IEnumerator gameover()
    {
        Debug.Log("chal bc");
        yield return new WaitForSeconds(2);
       
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameovers.SetActive(true);
       
    }
    public void quit()
    {
        Application.Quit();
    }
    public void Resume()
    {
        Cursor.visible = false;
        PauseUI.SetActive(false);
      
        Time.timeScale = 1f;

        movement.enabled = true;

        
      

    }
  


}
