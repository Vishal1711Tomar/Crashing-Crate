using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Starting : MonoBehaviour
{
    public GameObject Level;
    public GameObject Startss;
    public GameObject controlss;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Starts()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Menuback()

    {
        Level.SetActive(false);
        Startss.SetActive(true);

    }
    public void Levels()
    {
        Startss.SetActive(false);
        Level.SetActive(true);

    }
    public void Menu()
    {
        Level.SetActive(false);
        Startss.SetActive(true);

    }
    public void MenubackControls()

    {
        controlss.SetActive(false);
        Startss.SetActive(true);

    }
    public void Controls()
    {
        Startss.SetActive(false);
        controlss.SetActive(true);

    }
    public void quit()
    {
        Application.Quit();
    }
    public void one()
    {
        SceneManager.LoadScene(1);
    }
    public void two()
    {
        SceneManager.LoadScene(2);
    }
    public void three()
    {
        SceneManager.LoadScene(3);
    }
    public void four()
    {
        SceneManager.LoadScene(4);
    }
    public void five()
    {
        SceneManager.LoadScene(5);
    }
    public void Six()
    {
        SceneManager.LoadScene(6);
    }
}
