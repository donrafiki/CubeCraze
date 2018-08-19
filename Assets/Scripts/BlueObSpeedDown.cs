using UnityEngine;

public class BlueObSpeedDown : MonoBehaviour
{
    public Rigidbody rb;
    public float SpeedDownForce = -10000f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObstacleU")
        {
            Debug.Log("speedDown");
            rb.AddForce(0, 0, SpeedDownForce * Time.deltaTime);
        }
    }

}
