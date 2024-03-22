using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movpersonaje : MonoBehaviour
{  
    public float multVelocidad = 1;
    //  public float multSalto = 1;
   //  SpriteRenderer sr;
   //  RigidBody2D rb;
    
   //  public bool puedoSaltar = false;


    // Start is called before the first frame update
    void Start() 
    {
        //  rb = this.GetComponent<RigidBody2D> ();
        //  sr = this.GetComponent<SpriteRenderer> ();
    } 

    // Update is called once per frame
    void Update()
    {
        //Movimiento
        // float mov = Input.GetAxis("Horizontal")*multVelocidad*Time.deltaTime;
       //  transform.position = new Vector3(transform.position.x+mov, transform.position.y, transform.position.z);
       //  transform.Translate(mov, 0, 0);

         //  if(Input.GetKeyDown(KeyCode.D)) {
          //      sr.flipX = false;
         //  }

        //Salto

         //  RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.4f);
         //   if(hit){
         //  Debug.DrawRay(transform.position, Vector2.down, Color.magenta);
         //  if(hit.collider.name == "Grid"){
         //       puedoSaltar = true;
         //  }else{
          //      puedoSaltar = false;
          // }

        //  if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar==true) 
        // {
         //   rb.AddForce(new Vector2.up * multSalto, ForceMode2d.Impulse);{

         //   }
       //   }
    }
     // void OnCollisionEnter2D(Collision2D col){
       //  global::System.Object value = Debug.Log(col.gameObject.name);
    // }
    

   
}
