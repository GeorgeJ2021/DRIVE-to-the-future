using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cameratarget : MonoBehaviour
{
    Vector2 rot;
    public GameObject camtarget;
    Controls playercar;

    void Awake()
    {
        playercar = new Controls();
        playercar.Car.HorizontalRot.performed += cntx => rot = cntx.ReadValue<Vector2>();
        playercar.Car.HorizontalRot.canceled += cntx => rot = Vector2.zero;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       HorizontalRotate(); 
    }
    void HorizontalRotate()
    {
        Debug.Log("rotating cam");
        camtarget.transform.Rotate(Vector3.up * rot.x*.2f);
    }
}
