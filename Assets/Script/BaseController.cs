using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    [SerializeField] GameObject baseObj = null;
    private int setZahyou[] = {
        0, 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Controll();
    }

    private void Controll()
    {
        if (Input.GetKey (KeyCode.LeftArrow))
        { //Up movement
            baseObj.transform.Rotate(0, 0, 3);
        /*
            rigidBody.velocity = new Vector3 (rigidBody.velocity.x, rigidBody.velocity.y, moveSpeed);
            myTransform.rotation = Quaternion.Euler (0, 0, 0);
            animator.SetBool ("Walking", true);
        */
        }
        else if (Input.GetKey (KeyCode.RightArrow))
        {
            baseObj.transform.Rotate(0, 0, -3);
        }
    }
}
