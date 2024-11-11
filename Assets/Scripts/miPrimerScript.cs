using Unity.VisualScripting;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{   
    public GameObject destino;
    Vector3 posicionDestino;
    
    void Start(){
       
    } 

    void Update(){
       posicionDestino = destino.transform.position; 
       transform.position = Vector3.MoveTowards(transform.position,
                                                posicionDestino,
                                                Time.deltaTime);

        // Rotación
        transform.Rotate(Vector3.right * Time.deltaTime * 50);
    }


}
