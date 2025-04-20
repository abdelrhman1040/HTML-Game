using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "baffles")
        {
            other.gameObject.transform.parent.GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * Random.Range(300000,500000),ForceMode.Acceleration);
            other.gameObject.transform.parent.GetComponent<Rigidbody>().AddForce(transform.up * Time.deltaTime * Random.Range(50000, 100000), ForceMode.Acceleration);
            print("hit");

        }
    }
}
