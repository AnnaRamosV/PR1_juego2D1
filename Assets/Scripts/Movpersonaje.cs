using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movpersonaje : MonoBehaviour
{  
    public float multVelocidad = 5f;
    private Rigidbody2D rb;
    public float multSalto = 5f;
     private bool puedoSaltar = true;

   //  SpriteRenderer sr;


    // Start is called before the first frame update
    void Start() 
    {
        rb = GetComponent<Rigidbody2D> ();
        transform.position = new Vector3(-4.15f, 0.45f, 0);
        //  sr = this.GetComponent<SpriteRenderer> ();
    } 

    // Update is called once per frame
    void Update()
    {
        //Movimiento
        float movTeclas = Input.GetAxis("Horizontal"); //*multVelocidad*Time.deltaTime;
        //float movTeclas = Input.GetAxis("Vertical"); //*multVelocidad*Time.deltaTime;
        float miDeltaTime = Time.deltaTime;

        rb.velocity = new Vector2(movTeclas*multVelocidad, rb.velocity.y);
        
      //FLIP
        if(Input.GetKeyDown(KeyCode.A)){
          this.GetComponent<SpriteRenderer>().flipX = true;
        }else if(Input.GetKeyDown(KeyCode.D)){
          this.GetComponent<SpriteRenderer>().flipX = false;
        }

        //SALTO//
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        if(hit){
          puedoSaltar = true;
          Debug.Log(hit.collider.name);
        }else {
          puedoSaltar = false;
        }

        if(Input.GetKeyDown(KeyCode.Space) && puedoSaltar){
          rb.AddForce(
            new Vector2(0,multSalto),
            ForceMode2D.Impulse
          );
          puedoSaltar = false; 
        }
    }
    void OnCollisionEnter2D(){
      puedoSaltar = true;
    }
}
