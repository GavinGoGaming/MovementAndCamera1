using UnityEngine;

public class PlayerCanMove : MonoBehaviour
{

    public Rigidbody PlayerRB1;

    public float ForwardForce = 200f;

    public float BackwardForce = -200f;

    public float LeftForce = 200f;

    public float RightForce = -200f;

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            PlayerRB1.AddForce(ForwardForce, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            PlayerRB1.AddForce(BackwardForce, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            PlayerRB1.AddForce(0, 0, RightForce);
        }

        if (Input.GetKey(KeyCode.A))
        {
            PlayerRB1.AddForce(0, 0, LeftForce);
        }
    }
}
