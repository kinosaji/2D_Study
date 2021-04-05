using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retire : MonoBehaviour
{
    AudioSource Audio;
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            GameScore.Life -= 1;
            CameraMove.stageClear += 1;
            Audio.Play();
            if (GameScore.Life >= 0)
            {
                if (GameScore.STAGE == 2)
                {
                    GameManager.BallPos = 2;
                }
                else if (GameScore.STAGE == 3)
                {
                    GameManager.BallPos = 3;
                }
                else if (GameScore.STAGE == 4)
                {
                    GameManager.BallPos = 4;
                }
                else if (GameScore.STAGE == 5)
                {
                    GameManager.BallPos = 5;
                }
                else if (GameScore.STAGE == 6)
                {
                    GameManager.BallPos = 6;
                }
                else if (GameScore.STAGE == 7)
                {
                    GameManager.BallPos = 7;
                }
                else if (GameScore.STAGE == 8)
                {
                    GameManager.BallPos = 8;
                }
                else if (GameScore.STAGE == 9)
                {
                    GameManager.BallPos = 9;
                }
                else if (GameScore.STAGE == 10)
                {
                    GameManager.BallPos = 10;
                }
            }
        }
    }
}
