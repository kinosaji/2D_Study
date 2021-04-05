using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearEvent : MonoBehaviour
{
    new AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            audio.Play();
            if (GameScore.STAGE == 1)
            {
                CameraMove.stageClear += 1;
                GameManager.BallPos = 2;
                GameScore.STAGE += 1;
            }
            else if (GameScore.STAGE == 2)
            {
                CameraMove.stageClear += 2;
                GameManager.BallPos = 3;
                GameScore.STAGE += 1;
            }
            else if (GameScore.STAGE == 3)
            {
                CameraMove.stageClear += 2;
                GameManager.BallPos = 4;
                GameScore.STAGE += 1;
            }
            else if (GameScore.STAGE == 4)
            {
                CameraMove.stageClear += 2;
                GameManager.BallPos = 5;
                GameScore.STAGE += 1;
            }
            else if (GameScore.STAGE == 5)
            {
                CameraMove.stageClear += 2;
                GameManager.BallPos = 6;
                GameScore.STAGE += 1;
            }
            else if (GameScore.STAGE == 6)
            {
                CameraMove.stageClear += 2;
                GameManager.BallPos = 7;
                GameScore.STAGE += 1;
            }
            else if (GameScore.STAGE == 7)
            {
                CameraMove.stageClear += 2;
                GameManager.BallPos = 8;
                GameScore.STAGE += 1;

            }
            else if (GameScore.STAGE == 8)
            {
                CameraMove.stageClear += 2;
                GameManager.BallPos = 9;
                GameScore.STAGE += 1;
            }
            else if (GameScore.STAGE == 9)
            {
                CameraMove.stageClear += 2;
                GameManager.BallPos = 10;
                GameScore.STAGE += 1;
            }
            else if (GameScore.STAGE == 10)
            {
                CameraMove.stageClear += 2;
                GameManager.BallPos = 11;
                AnimatorParameter.EndNum = 1;
            }
        }
    }
}
