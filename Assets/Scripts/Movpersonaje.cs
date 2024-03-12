using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movpersonaje : MonoBehaviour
{ 
     //public float multVelocidad = 1;
    //public float multSalto = 1;

    //RigidBody2d rb;


    // Start is called before the first frame update
    void Start() 
    {
         rb = this.GetComponent<RigidBody2d> ();
    } 

    // Update is called once per frame
    void Update()
    {
        //Movimiento
        float mov = Input.GetAxis("Horizontal")*multVelocidad*Time.deltaTime;
        transform.position = new Vector3(transform.position.x+mov, transform.position.y, transform.position.z);
        transform.Translate(mov, 0, 0);

        //Salto
         if (Input.GetKeyDown(KeyCode.Space)) {
         rb.AddForce(new Vector2(0, multSalto), ForceMode2d.Impulse);
         }
    }

   
}
