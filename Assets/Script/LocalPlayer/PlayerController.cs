using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 200;
    public float horizontal;
    public float vertical;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.back * Time.deltaTime * speed * horizontal);
        transform.Translate(Vector3.right * Time.deltaTime * speed * vertical);
    }

}
