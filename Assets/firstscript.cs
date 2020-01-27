using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstscript : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxSpeed = 10f;
    void Start()
    {
        Debug.Log("Green Ball instantiated");
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        float move2 = Input.GetAxis("Vertical");

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(move * maxSpeed, move2 * maxSpeed);
       

    }
}
