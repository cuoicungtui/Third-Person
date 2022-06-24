using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int damageAmount = 20;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());

        if (other.CompareTag("Dragon"))
        {
            transform.parent = other.transform;

            other.GetComponent<dragon>().takeDamage(damageAmount);

        }

    }
}
