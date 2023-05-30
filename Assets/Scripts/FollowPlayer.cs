using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private float mouseInput;
    [SerializeField] private Vector3 offset;

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void LateUpdate() {
        mouseInput = Input.GetAxis("MouseY");
        offset = offset - new Vector3(0f, 0f, mouseInput);
        // Set camera location 
        transform.position = player.transform.position + offset;
    }
}
