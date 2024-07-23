using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SidewaysForce = 500f;
    public Score score;
    void FixedUpdate()
    {
        rb.AddForce(0,0,ForwardForce*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
            score.StopTime();
        }
    }
}
