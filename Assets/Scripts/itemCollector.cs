using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollector : MonoBehaviour
{

    private int pineapples = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pineapple"))
        {
            Destroy(collision.gameObject);
            pineapples++;
            Debug.Log("Pineapples: " + pineapples);
        }
    }

}
