using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Target;

    public static int BallPos = 1;

    private void Update()
    {
        switch (BallPos)
        {
            case 1:
                StartCoroutine(Respown1()); //스테이지1 스폰 위치
                BallPos = 0;
                break;
            case 2:
                StartCoroutine(Respown2()); // 스테이지2 스폰,리스폰 위치
                BallPos = 0;
                break;
            case 3:
                StartCoroutine(Respown3()); // 스테이지3 스폰,리스폰 위치
                BallPos = 0;
                break;
            case 4:
                StartCoroutine(Respown4()); // 스테이지4 스폰,리스폰 위치
                BallPos = 0;
                break;
            case 5:
                StartCoroutine(Respown5()); // 스테이지5 스폰,리스폰 위치
                BallPos = 0;
                break;
            case 6:
                StartCoroutine(Respown6()); // 스테이지6 스폰,리스폰 위치
                BallPos = 0;
                break;
            case 7:
                StartCoroutine(Respown7()); // 스테이지7 스폰,리스폰 위치
                BallPos = 0;
                break;
            case 8:
                StartCoroutine(Respown8()); // 스테이지8 스폰,리스폰 위치
                BallPos = 0;
                break;
            case 9:
                StartCoroutine(Respown9()); // 스테이지9 스폰,리스폰 위치
                BallPos = 0;
                break;
            case 10:
                StartCoroutine(Respown10()); // 스테이지10 스폰,리스폰 위치
                BallPos = 0;
                break;
            case 11:
                StartCoroutine(Respown11()); // 엔딩화면
                BallPos = 0;
                break;
        }
    }

    IEnumerator Respown1()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(2.7f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(-9.5f, -4.5f, 0);
    }
    IEnumerator Respown2()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(2.7f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(-36.5f, -15.5f, 0);
    }
    IEnumerator Respown3()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(2.7f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(-63.78f, -25.13f, 0);
    }
    IEnumerator Respown4()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(2.7f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(-90.5f, -48.3f, 0);
    }
    IEnumerator Respown5()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(2.7f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(-117.4f, -55.49f, 0);
    }
    IEnumerator Respown6()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(2.7f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(-129.5f, -70.96f, 0);
    }
    IEnumerator Respown7()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(2.7f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(-171.7f, -97.18f, 0);
    }
    IEnumerator Respown8()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(2.7f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(-198.6f, -101.5f, 0);
    }
    IEnumerator Respown9()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(2.7f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(-223.1f,-127, 0);
    }
    IEnumerator Respown10()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(2.7f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(-237.5f, -136.1f, 0);
    }
    IEnumerator Respown11()
    {
        Target.SetActive(false);
        yield return new WaitForSeconds(5f);
        Target.SetActive(true);
        Target.transform.position = new Vector3(989,1004, 0);
    }
}
