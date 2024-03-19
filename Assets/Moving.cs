using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moving : MonoBehaviour
{
    public GameObject rb;
    bool check = true;
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "2")
        {   
          if(check)
            {
           //  rb.AddForce(100 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                Waits();
            }
             else
            {
              //  rb.AddForce(-100 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                check = true;
            }
           


        }
    }
    IEnumerator Waits()
    {
        yield return new WaitForSeconds(3);
        check = false;
    }
}
