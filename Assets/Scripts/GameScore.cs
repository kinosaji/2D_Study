using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    public static int Life = 2;
    public static int STAGE = 1;
    TextMesh textMesh;
    void Start()
    {
        textMesh = GetComponent<TextMesh>();
    }

    void Update()
    {
        _Text();
    }
    void _Text()
    {
        textMesh.text = "STAGE " + STAGE + "\n" + "LIFE : " + Life;
    }
}
