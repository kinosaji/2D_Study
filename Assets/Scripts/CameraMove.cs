using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMove : MonoBehaviour
{
    [SerializeField] GameObject Target;
    [SerializeField] AudioClip[] audioClip;

    AudioSource Audio;
    public static int stageClear = 0;
    Vector3 move = new Vector3(0, 1, 0);
    Vector3 _move = new Vector3(1, 0, 0);
    float speed = -20f;

    void Awake() // 게임시작전 카메라위치
    {
        Audio = GetComponent<AudioSource>();
        transform.position = new Vector3(-2, 14.8f, -1);
    }

    IEnumerator CameraMove_down() //**********스테이지1**********
    {
        yield return new WaitForSeconds(2f);
        if (transform.position.y > -0.5f)
        {
            transform.position += move * move.y * speed * Time.deltaTime;
        }
        if (transform.position.y < 14.8f && transform.position.y > 14.3f)
        {
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        if (transform.position.y < -0f && transform.position.y > -0.5f)
        {
            transform.position = new Vector3(-2, -0.5f, -1);
        }
    }
    IEnumerator CameraMove_left() // 스테이지1 클리어
    {
        if (transform.position.x > -29.2f)
        {
            transform.position += _move * _move.x * speed * Time.deltaTime;
        }
        if (transform.position.x <= -28.6f && transform.position.x >= -29.1f)
        {
            transform.position = new Vector3(-29.2f, -0.5f, -1);
            yield return new WaitForSeconds(1f);
            if (stageClear == 1)
            {
                stageClear = 2;
            }
        }

    }
    void CameraMove_down2() //**********스테이지2**********
    {
        if (transform.position.y > -15.8f)
        {
            transform.position += move * move.y * speed * Time.deltaTime;
        }
        if (transform.position.y < -0.5f && transform.position.y > -1f)
        {
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        if (transform.position.y < -15.3f && transform.position.y > -15.8f)
        {
            transform.position = new Vector3(-29, -15.8f, -1);
        }
    }
    IEnumerator CameraMove_Up2() // 스테이지2 Retire 발생
    {
        if (transform.position.y < -0.5f)
        {
            transform.position += move * move.y * 20 * Time.deltaTime;
        }
        if (transform.position.y >= -0.7f && transform.position.y <= 0)
        {
            transform.position = new Vector3(-29.2f, -0.5f, -1);
            yield return new WaitForSeconds(1f);
            stageClear = 2;
        }
    }
    IEnumerator CameraMove_left2() // 스테이지2 클리어
    {
        if (transform.position.x > -56.2f)
        {
            transform.position += _move * _move.x * speed * Time.deltaTime;
        }
        if (transform.position.x <= -55.6f && transform.position.x >= -56.1f)
        {
            transform.position = new Vector3(-56.2f, -15.8f, -1);
            yield return new WaitForSeconds(1f);
            if (stageClear == 4)
            {
                stageClear = 5;
            }
        }

    }
    void CameraMove_down3() //**********스테이지3**********
    {
        if (transform.position.y > -31f)
        {
            transform.position += move * move.y * speed * Time.deltaTime;
        }
        if (transform.position.y < -15.8f && transform.position.y > -16.3f)
        {
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        if (transform.position.y < -30.5f && transform.position.y > -31f)
        {
            transform.position = new Vector3(-56.4f, -31, -1);
        }
    }
    IEnumerator CameraMove_Up3() // 스테이지3 Retire 발생
    {
        if (transform.position.y < -15.8f) // Y가 대기화면 위치로 될때까지
        {
            transform.position += move * move.y * 20 * Time.deltaTime; // 위로올려준다
        }
        if (transform.position.y >= -16 && transform.position.y <= -15.3f) // 올라가다가 y가 ~라면
        {
            transform.position = new Vector3(-56.2f, -15.8f, -1); // 스테이지 대기화면 좌표
            RockCube.RockNum = 1; // RockCube 정위치
            yield return new WaitForSeconds(1f); //1초후
            stageClear = 5; // 스테이지 다시시작
        }
    }
    IEnumerator CameraMove_left3() // 스테이지3 클리어
    {
        if (transform.position.x > -83.2f)
        {
            transform.position += _move * _move.x * speed * Time.deltaTime;
        }
        if (transform.position.x <= -82.6f && transform.position.x >= -83.1f)
        {
            transform.position = new Vector3(-83.2f, -31.4f, -1);
            yield return new WaitForSeconds(1f);
            if (stageClear == 7)
            {
                stageClear = 8;
            }
        }

    }
    void CameraMove_down4() //**********스테이지4**********
    {
        if (transform.position.y > -46.4f)
        {
            transform.position += move * move.y * speed * Time.deltaTime;
        }
        if (transform.position.y < -31.5f && transform.position.y > -32f)
        {
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        if (transform.position.y < -45.9 && transform.position.y > -46.4f)
        {
            transform.position = new Vector3(-83.2f, -46.4f, -1);
        }
    }
    IEnumerator CameraMove_Up4() // 스테이지4 Retire 발생
    {
        if (transform.position.y < -31.4f) // Y가 대기화면 위치로 될때까지
        {
            transform.position += move * move.y * 20 * Time.deltaTime; // 위로올려준다
        }
        if (transform.position.y >= -31.6 && transform.position.y <= -30.9f) // 올라가다가 y가 ~라면
        {
            transform.position = new Vector3(-83.2f, -31.4f, -1); // 스테이지 대기화면 좌표
            yield return new WaitForSeconds(1f); //1초후
            stageClear = 8; // 스테이지 다시시작
        }
    }
    IEnumerator CameraMove_left4() // 스테이지4 클리어
    {
        if (transform.position.x > -110.2f)
        {
            transform.position += _move * _move.x * speed * Time.deltaTime;
        }
        if (transform.position.x <= -109.6f && transform.position.x >= -110.1f)
        {
            transform.position = new Vector3(-110.2f, -46.4f, -1);
            yield return new WaitForSeconds(1f);
            if (stageClear == 10)
            {
                stageClear = 11;
            }
        }

    }
    void CameraMove_down5() //**********스테이지5**********
    {
        if (transform.position.y > -61.7f)
        {
            transform.position += move * move.y * speed * Time.deltaTime;
        }
        if (transform.position.y < -46.4f && transform.position.y > -46.9f)
        {
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        if (transform.position.y < -61.2 && transform.position.y > -61.7f)
        {
            transform.position = new Vector3(-110.2f, -61.7f, -1);
        }
    }
    IEnumerator CameraMove_Up5() // 스테이지5 Retire 발생
    {
        if (transform.position.y < -46.4f) // Y가 대기화면 위치로 될때까지
        {
            transform.position += move * move.y * 20 * Time.deltaTime; // 위로올려준다
        }
        if (transform.position.y >= -46.6f && transform.position.y <= -45.9f) // 올라가다가 y가 ~라면
        {
            transform.position = new Vector3(-110.2f, -46.4f, -1); // 스테이지 대기화면 좌표
            RockCube.RockNum = 1; // RockCube 정위치
            yield return new WaitForSeconds(1f); //1초후
            stageClear = 11; // 스테이지 다시시작
        }
    }
    IEnumerator CameraMove_left5() // 스테이지5 클리어
    {
        if (transform.position.x >= -137.2f)
        {
            transform.position += _move * _move.x * speed * Time.deltaTime;
        }
        if (transform.position.x <= -136.6f && transform.position.x >= -137.1f)
        {
            transform.position = new Vector3(-137.2f, -61.7f, -1);
            yield return new WaitForSeconds(1f);
            if (stageClear == 13)
            {
                stageClear = 14;
            }
        }

    }
    void CameraMove_down6() //**********스테이지6**********
    {
        if (transform.position.y > -77)
        {
            transform.position += move * move.y * speed * Time.deltaTime;
        }
        if (transform.position.y < -61.7f && transform.position.y > -62.2)
        {
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        if (transform.position.y < -76.5f && transform.position.y > -77)
        {
            transform.position = new Vector3(-137.2f, -77, -1);
        }
    }
    IEnumerator CameraMove_Up6() // 스테이지6 Retire 발생
    {
        if (transform.position.y < -61.7f) // Y가 대기화면 위치로 될때까지
        {
            transform.position += move * move.y * 20 * Time.deltaTime; // 위로올려준다
        }
        if (transform.position.y >= -61.9f && transform.position.y <= -61.2f) // 올라가다가 y가 ~라면
        {
            transform.position = new Vector3(-137.2f, -61.7f, -1); // 스테이지 대기화면 좌표
            yield return new WaitForSeconds(1f); //1초후
            stageClear = 14; // 스테이지 다시시작
        }
    }
    IEnumerator CameraMove_left6() // 스테이지6 클리어
    {
        if (transform.position.x >= -164.2f)
        {
            transform.position += _move * _move.x * speed * Time.deltaTime;
        }
        if (transform.position.x <= -163.6f && transform.position.x >= -164.1f)
        {
            transform.position = new Vector3(-164.2f, -77, -1);
            yield return new WaitForSeconds(1f);
            if (stageClear == 16)
            {
                stageClear = 17;
            }
        }

    }
    void CameraMove_down7() //**********스테이지7**********
    {
        if (transform.position.y > -92.3f)
        {
            transform.position += move * move.y * speed * Time.deltaTime;
        }
        if (transform.position.y < -77 && transform.position.y > -77.5f)
        {
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        if (transform.position.y < -91.8f && transform.position.y > -92.3f)
        {
            transform.position = new Vector3(-164.2f, -92.3f, -1);
        }
    }
    IEnumerator CameraMove_Up7() // 스테이지7 Retire 발생
    {
        if (transform.position.y < -77) // Y가 대기화면 위치로 될때까지
        {
            transform.position += move * move.y * 20 * Time.deltaTime; // 위로올려준다
        }
        if (transform.position.y >= -77.2 && transform.position.y <= -76.5f) // 올라가다가 y가 ~라면
        {
            transform.position = new Vector3(-164.2f, -77, -1); // 스테이지 대기화면 좌표
            RockCube.RockNum = 1; // RockCube 정위치
            yield return new WaitForSeconds(1f); //1초후
            stageClear = 17; // 스테이지 다시시작
        }
    }
    IEnumerator CameraMove_left7() // 스테이지7 클리어
    {
        if (transform.position.x >= -191.2f)
        {
            transform.position += _move * _move.x * speed * Time.deltaTime;
        }
        if (transform.position.x <= -190.6f && transform.position.x >= -191.1f)
        {
            transform.position = new Vector3(-191.2f, -92.3f, -1);
            yield return new WaitForSeconds(1f);
            if (stageClear == 19)
            {
                stageClear = 20;
            }
        }

    }
    void CameraMove_down8() //**********스테이지8**********
    {
        if (transform.position.y > -107.6f)
        {
            transform.position += move * move.y * speed * Time.deltaTime;
        }
        if (transform.position.y < -92.3f && transform.position.y > -92.8f)
        {
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        if (transform.position.y < -107.1f && transform.position.y > -107.6f)
        {
            transform.position = new Vector3(-191.2f, -107.6f, -1);
        }
    }
    IEnumerator CameraMove_Up8() // 스테이지8 Retire 발생
    {
        if (transform.position.y < -92.3f) // Y가 대기화면 위치로 될때까지
        {
            transform.position += move * move.y * 20 * Time.deltaTime; // 위로올려준다
        }
        if (transform.position.y >= -92.5f && transform.position.y <= -91.8f) // 올라가다가 y가 ~라면
        {
            transform.position = new Vector3(-191.2f, -92.3f, -1); // 스테이지 대기화면 좌표
            yield return new WaitForSeconds(1f); //1초후
            stageClear = 20; // 스테이지 다시시작
        }
    }
    IEnumerator CameraMove_left8() // 스테이지8 클리어
    {
        if (transform.position.x >= -218.2f)
        {
            transform.position += _move * _move.x * speed * Time.deltaTime;
        }
        if (transform.position.x <= -217.6f && transform.position.x >= -218.1f)
        {
            transform.position = new Vector3(-218.2f, -107.6f, -1);
            yield return new WaitForSeconds(1f);
            if (stageClear == 22)
            {
                stageClear = 23;
            }
        }

    }
    void CameraMove_down9() //**********스테이지9**********
    {
        if (transform.position.y > -122.9f)
        {
            transform.position += move * move.y * speed * Time.deltaTime;
        }
        if (transform.position.y < -107.6f && transform.position.y > -108.1f)
        {
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        if (transform.position.y < -122.4f && transform.position.y > -122.9f)
        {
            transform.position = new Vector3(-218.2f, -122.9f, -1);
        }
    }
    IEnumerator CameraMove_Up9() // 스테이지9 Retire 발생
    {
        if (transform.position.y < -107.6f) // Y가 대기화면 위치로 될때까지
        {
            transform.position += move * move.y * 20 * Time.deltaTime; // 위로올려준다
        }
        if (transform.position.y >= -107.8f && transform.position.y <= -107.1f) // 올라가다가 y가 ~라면
        {
            transform.position = new Vector3(-218.2f, -107.6f, -1); // 스테이지 대기화면 좌표
            RockCube.RockNum = 1; // RockCube 정위치
            yield return new WaitForSeconds(1f); //1초후
            stageClear = 23; // 스테이지 다시시작
        }
    }
    IEnumerator CameraMove_left9() // 스테이지9 클리어
    {
        if (transform.position.x >= -245.2f)
        {
            transform.position += _move * _move.x * speed * Time.deltaTime;
        }
        if (transform.position.x <= -244.6f && transform.position.x >= -245.1f)
        {
            transform.position = new Vector3(-245.2f, -122.9f, -1);
            yield return new WaitForSeconds(1f);
            if (stageClear == 25)
            {
                stageClear = 26;
            }
        }

    }
    void CameraMove_down10() //**********스테이지10**********
    {
        if (transform.position.y > -138.2f)
        {
            transform.position += move * move.y * speed * Time.deltaTime;
        }
        if (transform.position.y < -122.9f && transform.position.y > -123.4f)
        {
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        if (transform.position.y < -137.7 && transform.position.y > -138.2f)
        {
            transform.position = new Vector3(-245.2f, -138.2f, -1);
        }
    }
    IEnumerator CameraMove_Up10() // 스테이지10 Retire 발생
    {
        if (transform.position.y < -122.9f) // Y가 대기화면 위치로 될때까지
        {
            transform.position += move * move.y * 20 * Time.deltaTime; // 위로올려준다
        }
        if (transform.position.y >= -123.1f && transform.position.y <= -122.4f) // 올라가다가 y가 ~라면
        {
            transform.position = new Vector3(-245.2f, -122.9f, -1); // 스테이지 대기화면 좌표
            RockCube.RockNum = 1; // RockCube 정위치
            yield return new WaitForSeconds(1f); //1초후
            stageClear = 26; // 스테이지 다시시작
        }
    }
    IEnumerator CameraMove_Clear() // 스테이지10 클리어
    {
        yield return new WaitForSeconds(1.9f);
        transform.position = new Vector3(1000, 1000, -1);
    }
    
    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1.9f);
        transform.position = new Vector3(-2, 14.8f, -1); 
        stageClear = 0;
        RockCube.RockNum = 1;
        Target.SetActive(false);
        yield return new WaitForSeconds(1.7f);
        Target.SetActive(true);
    }




    void Update()
    {
        if (stageClear == 0) //**********스테이지1**********
        {
            StartCoroutine(CameraMove_down());
        }
        else if (stageClear == 1) // 스테이지1 클리어
        {
            StartCoroutine(CameraMove_left());
        }
        else if (stageClear == 2) //**********스테이지2**********
        {
            CameraMove_down2();
        }
        else if (stageClear == 3)  // 스테이지2 Retire
        {
            StartCoroutine(CameraMove_Up2());
        }
        else if (stageClear == 4)  //스테이지2 클리어
        {
            StartCoroutine(CameraMove_left2());
        }
        else if (stageClear == 5) //**********스테이지3**********
        {
            CameraMove_down3();
        }
        else if (stageClear == 6)  // 스테이지3 Retire
        {
            StartCoroutine(CameraMove_Up3());
        }
        else if (stageClear == 7)  //스테이지3 클리어
        {
            StartCoroutine(CameraMove_left3());
        }
        else if (stageClear == 8) //**********스테이지4**********
        {
            CameraMove_down4();
        }
        else if (stageClear == 9)  // 스테이지4 Retire
        {
            StartCoroutine(CameraMove_Up4());
        }
        else if (stageClear == 10)  //스테이지4 클리어
        {
            StartCoroutine(CameraMove_left4());
        }
        else if (stageClear == 11) //**********스테이지5**********
        {
            CameraMove_down5();
        }
        else if (stageClear == 12)  // 스테이지5 Retire
        {
            StartCoroutine(CameraMove_Up5());
        }
        else if (stageClear == 13)  //스테이지5 클리어
        {
            StartCoroutine(CameraMove_left5());
        }
        else if (stageClear == 14) //**********스테이지6**********
        {
            CameraMove_down6();
        }
        else if (stageClear == 15)  // 스테이지6 Retire
        {
            StartCoroutine(CameraMove_Up6());
        }
        else if (stageClear == 16)  //스테이지6 클리어
        {
            StartCoroutine(CameraMove_left6());
        }
        else if (stageClear == 17) //**********스테이지7**********
        {
            CameraMove_down7();
        }
        else if (stageClear == 18)  // 스테이지7 Retire
        {
            StartCoroutine(CameraMove_Up7());
        }
        else if (stageClear == 19)  //스테이지7 클리어
        {
            StartCoroutine(CameraMove_left7());
        }
        else if (stageClear == 20) //**********스테이지8**********
        {
            CameraMove_down8();
        }
        else if (stageClear == 21)  // 스테이지8 Retire
        {
            StartCoroutine(CameraMove_Up8());
        }
        else if (stageClear == 22)  //스테이지8 클리어
        {
            StartCoroutine(CameraMove_left8());
        }
        else if (stageClear == 23) //**********스테이지9**********
        {
            CameraMove_down9();
        }
        else if (stageClear == 24)  // 스테이지9 Retire
        {
            StartCoroutine(CameraMove_Up9());
        }
        else if (stageClear == 25)  //스테이지9 클리어
        {
            StartCoroutine(CameraMove_left9());
        }
        else if (stageClear == 26) //**********스테이지10**********
        {
            CameraMove_down10();
        }
        else if (stageClear == 27)  // 스테이지10 Retire
        {
            StartCoroutine(CameraMove_Up10());
        }
        else if (stageClear == 29)  //스테이지10 클리어
        {
            StartCoroutine(CameraMove_Clear());
        }
        else if (stageClear == -1)
        {
            StartCoroutine(Restart());
        }
        
    }
}



