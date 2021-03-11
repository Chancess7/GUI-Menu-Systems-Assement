using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathFtext : MonoBehaviour
{
    public CanvasGroup Text;
    public float speed = 1f;

    private float _t = 0f;

    void Update()
    {
        _t += Time.deltaTime * speed;
        Text.alpha = Mathf.PingPong(_t, 1f);
    }

}
