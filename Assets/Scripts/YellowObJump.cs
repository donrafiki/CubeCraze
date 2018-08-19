using UnityEngine;

public class YellowObJump : MonoBehaviour
{
    public Rigidbody rb;
    public float JumpForce = 10000f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObstacleY")
        {
            Debug.Log("Jump!");
            rb.AddForce(0, 0, JumpForce * Time.deltaTime);
        }
    }

}
