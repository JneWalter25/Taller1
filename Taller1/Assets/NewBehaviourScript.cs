using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{    Rigidbody rb;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = new GameObject();
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        rb.isKinematic = true;
        rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationY;
        rb.gameObject.AddComponent<BoxCollider>();
        rb.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
