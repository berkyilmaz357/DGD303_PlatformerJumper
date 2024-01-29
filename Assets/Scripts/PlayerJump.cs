using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float ziplamaGucu = 10f; 
    private Rigidbody rb; 
    private bool yereDustu = true; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && yereDustu)
        {
            Zipla();
        }
    }

    void Zipla()
    {
        
        rb.velocity = new Vector3(rb.velocity.x, ziplamaGucu, rb.velocity.z);
        yereDustu = false; 
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            yereDustu = true;
        }
    }
}
