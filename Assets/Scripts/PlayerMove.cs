using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClip;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float Bound = 5.5f;
    [SerializeField] float S_Bound = 8.5f;

    Rigidbody2D rigid;
    AudioSource Audio;
    int ShoutNum;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        Audio = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        ShoutNum = 0; // 스테이지3 -> 스테이지4 속도 소멸
        rigid.velocity = new Vector2(0, 0);
    }
    void Update()
    {
        if (rigid.velocity.x > -4)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigid.velocity += new Vector2(-3, 0) * speed * Time.deltaTime;
            }
        }
        if (rigid.velocity.x < 4)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rigid.velocity += new Vector2(3, 0) * speed * Time.deltaTime;
            }
        }

        #region DriftL
        if (ShoutNum == 1)
        {
            rigid.velocity = new Vector2(8.8f, 0.25f);
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                ShoutNum = 2;
                Audio.clip = audioClip[4];
                Audio.Play();
            }
        }
        if (ShoutNum == 2)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigid.velocity -= new Vector2(2, 0) * speed * Time.deltaTime;
                if (rigid.velocity.x <= 0)
                {
                    ShoutNum = 0;
                }
            }
        }
        #endregion
        #region DriftR
        if (ShoutNum == 10)
        {
            rigid.velocity = new Vector2(-8.8f, 0.25f);
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                ShoutNum = 20;
                Audio.clip = audioClip[4];
                Audio.Play();
            }
        }
        if (ShoutNum == 20)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rigid.velocity += new Vector2(2, 0) * speed * Time.deltaTime;
                if (rigid.velocity.x >= 0)
                {
                    ShoutNum = 0;
                }
            }
        }
        #endregion
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BasicCube")
        {
            rigid.AddForce(new Vector2(0, Bound), ForceMode2D.Impulse); // 점프
            Audio.clip = audioClip[0];
            Audio.Play();
        }
        else if (collision.gameObject.tag == "RockCube")
        {
            rigid.velocity = new Vector2(0, 0);
            rigid.AddForce(new Vector2(0, Bound), ForceMode2D.Impulse); // 점프
            Audio.clip = audioClip[1];
            Audio.Play();
        }
        else if (collision.gameObject.tag == "BlueCube")
        {
            rigid.velocity = new Vector2(0, 0);
            rigid.AddForce(new Vector2(0, S_Bound), ForceMode2D.Impulse); // 슈퍼 점프
            Audio.clip = audioClip[6];
            Audio.Play();
        }
        else if (collision.gameObject.name == "Restart")
        {
            SceneManager.LoadScene(0);
            GameScore.Life = 10;
            GameScore.STAGE = 1;
            GameManager.BallPos = 1;
            CameraMove.stageClear = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D collision) // 벽에 닿았을때
    {
        if (collision.gameObject.tag == "L_Wall") // 왼쪽벽에 충돌시 공밀어내기
        {
            ShoutNum = 0;
            rigid.velocity = new Vector2(0, 0);
            Audio.clip = audioClip[5];
            Audio.Play();
            rigid.AddForce(new Vector2(3, 0), ForceMode2D.Impulse);

            if (Input.GetKey(KeyCode.RightArrow)) // 오른쪽으로 벽점프
            {
                rigid.velocity = new Vector2(0, 0);
                rigid.AddForce(new Vector2(5, 4.5f), ForceMode2D.Impulse);
                Audio.clip = audioClip[2];
                Audio.Play();

            }
        }
        else if (collision.gameObject.tag == "R_Wall") // 오른쪽벽에 충돌시 공밀어내기
        {
            ShoutNum = 0;
            rigid.velocity = new Vector2(0, 0);
            Audio.clip = audioClip[5];
            Audio.Play();
            rigid.AddForce(new Vector2(-3, 0), ForceMode2D.Impulse);

            if (Input.GetKey(KeyCode.LeftArrow)) // 왼쪽으로 벽점프
            {
                rigid.velocity = new Vector2(0, 0);
                rigid.AddForce(new Vector2(-5, 4.5f), ForceMode2D.Impulse);
                Audio.clip = audioClip[2];
                Audio.Play();

            }
        }
        else if (collision.gameObject.tag == "LeftShout")
        {
            transform.position = transform.position + new Vector3(0.7f, -0.35f);
            ShoutNum = 1;
            Audio.clip = audioClip[3];
            Audio.Play();
        }
        else if (collision.gameObject.tag == "RightShout")
        {
            transform.position = transform.position + new Vector3(-0.7f, -0.35f);
            ShoutNum = 10;
            Audio.clip = audioClip[3];
            Audio.Play();
        }
    }
}