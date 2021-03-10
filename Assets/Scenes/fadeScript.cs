using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fadeScript : MonoBehaviour
{
    // can ignore the update, it's just to make the coroutines get called for example
    void Update()
    {
 
        if (Input.GetKeyUp(KeyCode.E))
        {
            StartCoroutine(FadeTextToZeroAlpha(1f, GetComponent<Text>()));
        }
    }


    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}