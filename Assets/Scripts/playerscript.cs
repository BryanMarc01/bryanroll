using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerscript : MonoBehaviour
{
    private Rigidbody rb;
   
public AudioClip coinsound;
private int contador;
public Text TextoContador,TextoGanar;
public float velocidad;
 public float tiempo_start; //Los segundos por los quales comienza i la variable que utilizaremos para que vaya contando segundos.
    public float tiempo_end; //Segundos que queremos que pasen para que cambie de escena
    void Start()
    {
         
        rb= GetComponent<Rigidbody>();
        contador=0;
setTextoContador();
TextoGanar.text="";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (contador==12){
     tiempo_start += Time.deltaTime;
        if (tiempo_start >= tiempo_end) 
            SceneManager.LoadScene("MenuR");
  }
        float movimientoH= Input.GetAxis("Horizontal");
        float movimientoV= Input.GetAxis("Vertical");
        

        Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);
        // Asignar movimiento o desplazamiento a mi RigidBody

        rb.AddForce(movimiento*velocidad);
    }
    void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Coleccionable"))
{
    other.gameObject.SetActive(false);
    AudioSource.PlayClipAtPoint(coinsound,transform.position);
    contador=contador+1;
    setTextoContador();
    
}


}

void setTextoContador(){
TextoContador.text = "Contador: " + contador.ToString();
if (contador >= 12){
TextoGanar.text = "¡Ganaste!";

}
  
}

}





