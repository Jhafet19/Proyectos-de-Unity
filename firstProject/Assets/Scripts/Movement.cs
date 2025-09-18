using UnityEngine;

public class Movement : MonoBehaviour
{

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // a:-1 0  d:1
        float vertical = Input.GetAxis("Vertical"); // w: -1 0 s:1

        Vector3 direction = new Vector3(horizontal, 0, vertical) * (Time.deltaTime * 5);

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 5f);

        transform.rotation = targetRotation;

        transform.position += direction;




    }
}