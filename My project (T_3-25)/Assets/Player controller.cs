using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    public float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xINput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("vertical");
        float xSpeed = xINput * speed;
        float zSpeed = zInput * speed;
        Vector3 newVelocity = new Vector3(xSpeed,0f,zSpeed);
        playerRigidBody.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }


}
