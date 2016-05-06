using UnityEngine;
using System.Collections;
using Assets.Scripts.Game;
public class Player : MonoBehaviour
{

	// Use this for initialization
	Rigidbody2D body;
	Collider2D coll;
	private bool canJump;
	public LayerMask whatIsGround;
	//para que mire donde apunta
	private float scaleX;
    Animator anim;

    [SerializeField]
    private float speed;

    
	void Start ()
	{
        speed = 5f;
		scaleX = transform.localScale.x;
		body = GetComponent<Rigidbody2D> ();
		coll = GetComponent<Collider2D> ();
        anim = GetComponent<Animator>();

        anim.Play(gameObject.name+""+PlayerStates.IDLE);
	}
	
	// Update is called once per frame
	void Update ()
	{
		canJump = Physics2D.IsTouchingLayers (coll, whatIsGround);

        body.velocity = new Vector2(speed,body.velocity.y);
		if (canJump) {
            anim.Play(gameObject.name);
			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetMouseButtonDown(0)) {
				body.velocity = new Vector2 (body.velocity.x, 15f);
			}
		}

		//body.velocity.y es para q mientras se mueve tambien caiga
		/*if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.localScale = new Vector3 (-scaleX, transform.localScale.y, transform.localScale.z);
			body.velocity = new Vector2 (-10f, body.velocity.y);

		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.localScale = new Vector3 (scaleX, transform.localScale.y, transform.localScale.z);
			body.velocity = new Vector2 (10f, body.velocity.y);
		}
		//si no se presiona nada no se mueve
		if (!Input.anyKey) {
			body.velocity = new Vector2 (0, body.velocity.y);
		}
        */

		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "vacio")
        {
            CamerMovement.instance.isMoving = false;
            Destroy(gameObject);
            GameOverPanel.instance.show();
        }
    }
}