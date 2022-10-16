using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject Opciones;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play(){
SceneManager.LoadScene("Escena");
    }
public void Options(){
    SceneManager.LoadScene("Opciones");
}

    public void OptionsOff(){
        SceneManager.LoadScene("MenuR");
    }
       public void Exit(){
        Application.Quit();
    }
}
