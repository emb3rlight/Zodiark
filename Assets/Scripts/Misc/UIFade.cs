using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIFade : MonoBehaviour
{
    public static UIFade instance; 
    public Image fadeScreen;
    private bool shouldFadeToBlack;
    private bool shouldFadefromBlack;
    public float fadeSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
      
    }

    // Update is called once per frame
    void Update()
    {
          if(shouldFadeToBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 1f, fadeSpeed * Time.deltaTime));

            if (fadeScreen.color.a == 1f)
            {
                shouldFadeToBlack = false;
            }
        }

        if(shouldFadefromBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 0f, fadeSpeed * Time.deltaTime));

             if (fadeScreen.color.a == 0f)
            {
                shouldFadefromBlack = false;
            }
        }
        
    }

    public void FadeToBlack()
    {
        shouldFadeToBlack = true;
        shouldFadefromBlack = false;
    }

public void FadeFromBlack()
    {
        shouldFadefromBlack = true;
        shouldFadeToBlack = false; 
    }
}
