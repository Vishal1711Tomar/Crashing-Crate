namespace ArionDigital
{
    using UnityEngine;

    public class CrashCrate : MonoBehaviour
    {
        [Header("Whole Create")]
        public MeshRenderer wholeCrate;
        public BoxCollider boxCollider;
        [Header("Fractured Create")]
        public GameObject fracturedCrate;
        [Header("Audio")]
        public AudioSource crashAudioClip;
        bool destroy = false;
      
       

        public void OnTriggerEnter(Collider other)
        { if (other.transform.CompareTag("Coin"))
            {
                destroy = true;
                if (destroy)
                {


                    wholeCrate.enabled = false;
                    boxCollider.enabled = false;
              
                    fracturedCrate.SetActive(true);
                    crashAudioClip.Play();
                    GameManager.a = GameManager.a + 1f;
                  
                }
            }
        }
        

        [ContextMenu("Test")]
        public void Test()
        {
            wholeCrate.enabled = false;
            boxCollider.enabled = false;
            fracturedCrate.SetActive(true);
        }
    }
}