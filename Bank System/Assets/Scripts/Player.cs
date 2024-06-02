using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Physics")]
    public float Speed;

    [Header("Bank Information")]
    public int Cash;
    public int PinCode;
    public string MyName;



    Rigidbody _rb;
    Vector3 _position;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        _position = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

    }

    private void FixedUpdate()
    {
        _rb.AddForce(Speed * Time.fixedDeltaTime * _position, ForceMode.VelocityChange);
    }
}
