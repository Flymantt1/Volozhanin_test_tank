using UnityEngine;

public class ActivatePhysicsOnTouch : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // отключаем физику на старте
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tank"))
        {
            rb.isKinematic = false; // включаем физику при касании игрока
        }
    }
}