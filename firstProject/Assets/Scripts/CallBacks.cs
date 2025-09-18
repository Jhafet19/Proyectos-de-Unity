using UnityEngine;

public class CallBacks : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // a:-1 0  d:1
        float vertical = Input.GetAxis("Vertical"); // w: -1 0 s:1
        Vector3 direction = new Vector3(horizontal, 0, vertical) * (Time.deltaTime * 5);

        //Eje Global
        //transform.position += direction;

        //Ejes locales
        transform.Translate(direction);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(0f, 180f * horizontal * Time.deltaTime, 0f);
        }

        /*if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(x: -1 * Time.deltaTime, y: 0, z: 0);
            //calcula 1 entre los fps del ordenador
        }*/
    }
}