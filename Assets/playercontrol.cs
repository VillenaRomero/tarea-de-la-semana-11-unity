using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float speedx;
    public float speedy;
    public int directionx;
    public int directiony;
    private Rigibody2D _comRigibody;
    private SpriteRenderer _comSpriteRenderer;
    void Awake(){
        _comRigibody = GetComponet<Rigibody>();
        _comSpriteRenderer = GetComponet<SpriteRenderer>();
    }
   
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + speedx * time.Deltatime, 0);
        transform.position = new Vector2(transform.position.y + speedy * time.Deltatime, 0);
    }
    void fixedUpdate() {
        _comRigibody.velocity = new Vector2(speedx * directionx,0);
        _comRigibody.velocity = new Vector2(speedy * directiony,0);
    }
    void OncollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "horizontal1") {
            if (directionx == 1)
            {
                directionx = -1;
                _comSpriteRenderer.flipx = true;
            }
            else if (directionx == -1) {
                directionx = 1;
                comSpriteRenderer.flipx = false;
            }
        }
        if (collision.gameObject.tag == "vertical") {
            if (directiony == 1) {
                directiony = -1;
            }
            else if (directiony == -1) {
                directionv = 1;
            }
        }
    }
}
