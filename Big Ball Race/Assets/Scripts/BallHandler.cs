using UnityEngine;
using System.Collections;

public class BallHandler : MonoBehaviour
{
    public enum BallColor
    {
        Red,
        Yellow,
        Blue,
        Pink,
    }
    public BallColor ballColor;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void UnsetSetRBConstraints()
    {
        StartCoroutine(ConstraintsTimer());
    }

    IEnumerator ConstraintsTimer()
    {
        yield return new WaitForSeconds(0.2f);
        GetComponent<SphereCollider>().isTrigger = false;
        rb.constraints = RigidbodyConstraints.None;
        rb.AddForce(new Vector3(0, -15, 0), ForceMode.Impulse);
        yield return new WaitForSeconds(5f);

        rb.constraints = RigidbodyConstraints.FreezeAll;
        GetComponent<SphereCollider>().isTrigger = true;
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("path"))
        {
            float dir = Random.Range(-1.5f, 1.5f);

            if (dir >= 0)
            {
                rb.velocity += new Vector3(1.5f, 0, 0);
            }
            else
            {
                rb.velocity += new Vector3(-1.5f, 0, 0);
            }

        }
    }
}
