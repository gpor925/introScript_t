using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class movimiento : MonoBehaviour
{
    public int rotateSpeed = 8;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //MOVIMIENTO
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(new Vector3(0,-rotateSpeed,0) * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(new Vector3(0,rotateSpeed,0) * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * Time.deltaTime * 7);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.back * Time.deltaTime * 5);
        }

    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "item"){
            Destroy(other.gameObject);
        }
    }
}
