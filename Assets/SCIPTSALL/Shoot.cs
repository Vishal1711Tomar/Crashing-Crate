using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shoot : MonoBehaviour  
{
    public GameObject ShootPos;
    public GameObject Ball;
    public float firerate = 100f;
    private float Nexttimetofire = 0f;
    private bool fires = false;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (fires)
        {
            Debug.Log("hi");
            if (Time.time >= Nexttimetofire)
                Nexttimetofire = Time.time + 1 / firerate;
            Instantiate(Ball, ShootPos.transform.position, Quaternion.identity);
        }
      
    }
  
   public void down()
   {
        fires = true;

   }
    public void ups()
    {
        fires = false;
    }

}
