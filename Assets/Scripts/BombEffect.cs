using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEffect : MonoBehaviour
{
    int BombNum = 0;

    IEnumerator Deley()
    {
        yield return new WaitForSeconds(1f);
        BombNum = 0;
        transform.localPosition = new Vector3(0, 0, 1);
        transform.localScale = new Vector3(0.1f, 0.1f, 1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            BombNum = 1;
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
    void Update()
    {
        if (BombNum == 1)
        {
            transform.localScale += new Vector3(5, 5, 0) * Time.deltaTime;
        }
        if (transform.localScale.x >= 3)
        {
            transform.localScale = new Vector3(3, 3, 0);
            StartCoroutine(Deley());
        }
    }
}
