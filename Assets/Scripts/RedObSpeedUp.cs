using UnityEngine;

public class RedObSpeedUp : MonoBehaviour
{
    public Rigidbody rb;
    public float SpeedUpForce = 5000f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObstacleR")
        {
            Debug.Log("speedUp");
            rb.AddForce(0, 0, SpeedUpForce * Time.deltaTime);
        }
    }

}
