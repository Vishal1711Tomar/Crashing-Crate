using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENESMANAGER : MonoBehaviour
{ public GameManager GM;
    bool v;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if(SceneManager.GetActiveScene().name == "1")
        {
            if (GameManager.a == 36)
            {


                GM.CompleteL();


            }
            switch (GameManager.a)
            {
                case 6:
                    GM.Rone.SetActive(true);
                    GM.cube1.SetActive(true);
                    GM.Rtwo.SetActive(true);
                    break;
                case 15:
                    GM.Rthree.SetActive(true);
                    GM.Rtwo.SetActive(true);
                  //  GM.Rfour.SetActive(true);
                  //  GM.Rfive.SetActive(true);
                    GM.cube1.SetActive(false);
                    GM.Rone.SetActive(false);
                    GM.Rtwo.SetActive(false);
                    break;
                case 18:

                    GM.Rthree.SetActive(false);
                    GM.Rtwo.SetActive(false);
                    GM.Rfour.SetActive(false);
                    GM.Rfive.SetActive(false);

                    GM.Rsix.SetActive(true);
                    //  fireworks.SetActive(true);

                    break;
                case 30:
                    GM.Rsix.SetActive(false);
                    GM.Rseven.SetActive(true);



                    break;
                case 36:
                    GM.Rseven.SetActive(false);
                    GM.Reight.SetActive(true);
                    GM.Rnine.SetActive(true);
                    GM.Rten.SetActive(true);
                    GM.Relevan.SetActive(true);
                    GM.Rtwelve.SetActive(true);
                    GM.fireworks.SetActive(true);
                    break;

            }
        }
        if(SceneManager.GetActiveScene().name == "2")
        {

            if (GameManager.a == 36)
            {


                GM.CompleteL();


            }
            switch (GameManager.a)
            {
                case 6:
                    GM.Rone.SetActive(true);
                    GM.cube1.SetActive(true);
                    GM.Rtwo.SetActive(true);
                    break;
                case 15:
                    GM.Rthree.SetActive(true);
                    GM.Rtwo.SetActive(true);
                    //  GM.Rfour.SetActive(true);
                    //  GM.Rfive.SetActive(true);
                    GM.cube1.SetActive(false);
                    GM.Rone.SetActive(false);
                    GM.Rtwo.SetActive(false);
                    break;
                case 18:

                    GM.Rthree.SetActive(false);
                    GM.Rtwo.SetActive(false);
                    GM.Rfour.SetActive(false);
                    GM.Rfive.SetActive(false);

                    GM.Rsix.SetActive(true);
                    //  fireworks.SetActive(true);

                    break;
                case 30:
                    GM.Rsix.SetActive(false);
                    GM.Rseven.SetActive(true);



                    break;
                case 36:
                    GM.Rseven.SetActive(false);
                    GM.Reight.SetActive(true);
                    GM.Rnine.SetActive(true);
                    GM.Rten.SetActive(true);
                    GM.Relevan.SetActive(true);
                    GM.Rtwelve.SetActive(true);
                    GM.fireworks.SetActive(true);
                    break;

            }
        }

    }
    
}
