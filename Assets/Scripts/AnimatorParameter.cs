using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorParameter : MonoBehaviour
{
    Animator animator;
    public static int EndNum = 0;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (EndNum == 1)
        {
            StartCoroutine(Ending());
        }
    }
    IEnumerator Ending()
    {
        EndNum = 0;
        animator.SetInteger("New Int", 1);
        yield return new WaitForSeconds(1f);
        animator.SetInteger("New Int", 0);

    }
}
