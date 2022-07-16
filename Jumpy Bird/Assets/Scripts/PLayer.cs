using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    private Rigidbody2D plyBody;
    private Animator anim;
    private SpriteRenderer spr;
    [SerializeField] private float jumpForce;
   
   private void Awake(){
        plyBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PLayerJump();
        
    }

    void FixedUpdate(){
      //  anim.SetBool("Flap", false);
    }

    

    void PLayerJump(){
        if (Input.GetButtonDown("Jump")){

            plyBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("Flap", true);

            
            
        }

        if (Input.GetButtonUp("Jump")){

            anim.SetBool("Flap", false);
        }

        

    }

    private void OnTriggerEnter2D(Collider2D col){

        if (col.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
        }
    }
}
