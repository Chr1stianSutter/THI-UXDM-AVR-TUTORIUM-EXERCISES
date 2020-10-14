using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody rb;
    public int speed;
    public GameObject player;

    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      float moveHorizontal = Input.GetAxis("Horizontal");
      float moveVertical = Input.GetAxis("Vertical");
      Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
      rb.AddForce(movement*speed);
    }
}
