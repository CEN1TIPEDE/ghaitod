using UnityEngine;

public class MovementController : MonoBehaviour
{

    int TestInt = 3;
    string TestString = "Roger";
    float TestFloat = 3.0f;

    int waitInt;

    Rigidbody rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>(); //define rigid component for this use case
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //GetKey = update everytime : GetKeyDown = one-time recieve
        {
            Vector3 force = Vector3.forward;
            rigid.AddForce(force);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 force = Vector3.back;
            rigid.AddForce(force);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Vector3 force = Vector3.right;
            rigid.AddForce(force);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 force = Vector3.left;
            rigid.AddForce(force);
        }
    }
}
