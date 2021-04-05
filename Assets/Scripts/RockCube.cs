using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCube : MonoBehaviour
{
    public static int RockNum = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            RockNum = 0;
            transform.position += new Vector3(1000, 0, 0);
        }
    }
    private void Update()
    {
        if (RockNum == 1)
        {

            if (transform.position.x > 500)
            {
                transform.position -= new Vector3(1000, 0, 0);
            }
        }
    }
}
