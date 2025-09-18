using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;


    // Update is called once per frame
    void Update() {

        Vector3 direction = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = targetRotation;
        //transform es el del GameObjet, mientras que el target apunta a una GameObject difetente
        transform.position = target.position + offset;
        
        
    }
}