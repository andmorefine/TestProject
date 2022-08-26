using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

    public float playerSeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force = new Vector2(playerSeed * -1, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            force = new Vector2(playerSeed, 0);
        }

        myRigidBody.MovePosition(myRigidBody.position + force * Time.fixedDeltaTime);
    }
}
