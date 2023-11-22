using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody rb;
    private float mX, mY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3 (mX, 0.0f, mY);
        rb.AddForce (movement * speed);
    }
    private void onMove(InputValue mValue)
    {
        Vector2 mVector = mValue.Get<Vector2>();
        mX = mVector.x;
        mX = mVector.y;
    }
}
