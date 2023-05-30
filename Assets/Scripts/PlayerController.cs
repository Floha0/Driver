using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float turnSpeed;
    public List<GameObject> carBot;
    private float horizontalInput;
    private float forwardInput;


    void Start()
    {
        
    }

    void Update()
    {
        // Get input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Transform input to movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        for (int i = 0; i <= carBot.Count - 1; i++)
        {
            carBot[i].transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
