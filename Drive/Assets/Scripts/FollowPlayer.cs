using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset;

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void LateUpdate() {
        // Set camera location 
        transform.position = player.transform.position + offset;
    }
}
