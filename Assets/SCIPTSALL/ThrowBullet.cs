using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Utility;

public class ThrowBullet : MonoBehaviour
{
    Rigidbody rd;
    Camera cam;
    public float Power = 100f;
    public int x;
    public new Renderer renderer;
   

    private void OnCollisionEnter(Collision collision)
    {
       /* if(collision.transform.CompareTag("Zombie"))
        {
            AIAgent Inst = collision.transform.gameObject.GetComponent<AIAgent>();
            Inst.Health -= 5f;
            Inst.agent.SetDestination(Inst.fpsc.transform.position);


        }*/
    }

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        cam = Camera.main;
        rd.AddForce(cam.transform.forward * Power);
        x = Random.Range(0, 5);
        switch (x)
        {
            case 1:
                renderer.material.color = Color.gray;

                //     ground.material.color = Color.black;
                break;
            case 2:
                renderer.material.color = Color.green;
                //   ground.material.color = Color.red;
                break;
            case 3:
                renderer.material.color = Color.red;
                //   ground.material.color = Color.cyan;
                break;
            case 4:
                renderer.material.color = Color.blue;
                //  ground.material.color = Color.blue;
                break;
            case 5:
                renderer.material.color = Color.magenta;
                //  ground.material.color = Color.yellow;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
       
        Destroy(gameObject, 0.7f);
    }
}
