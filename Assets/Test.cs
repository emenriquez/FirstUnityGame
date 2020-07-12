using UnityEngine;

public class Test : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(-500 * Time.deltaTime, 200 * Time.deltaTime, 0);
    }
}
