using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameScore.Life < 0)
        {
            StartCoroutine(LifeZero());
        }
        if (CameraMove.stageClear == 28)
        {
            animator.SetTrigger("CloseNum");
            CameraMove.stageClear = 29;
        }
    }
    IEnumerator LifeZero()
    {
        animator.SetTrigger("CloseNum");
        GameScore.Life = 2;
        CameraMove.stageClear = -1;
        GameScore.STAGE = 1;
        GameManager.BallPos = 1;
        yield return new WaitForSeconds(2f);
        audioSource.Play();
    }

}
