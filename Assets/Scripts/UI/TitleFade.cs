using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleFade : MonoBehaviour
{
    private float time;
    public CanvasGroup fadeUI;
    public Text title; 
    private Color textCol;

    private GameObject player;

    void Start()
    {
        time = 0;
        textCol = title.color;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time = time + Time.deltaTime;

        //Screen black for 4.5 seconds
        if(time < 4.5f)
        {
            fadeUI.alpha = 1;
        }
        else
        {
            fadeUI.alpha = Mathf.Lerp(1, 0, (time - 4.5f)/3);
        }

        //Text fade in after 0.3 seconds
        if(time > 0.3f) //Lerp out
        {            
            textCol = title.color;
            textCol.a = Mathf.Lerp(0, 1, (time-0.3f)/5);

            title.color = textCol;            
        }

        //Prevent player movement for fade time
        if(time < 5f)
        {
            player.GetComponent<PlayerManager>().enabled = false;
        }
        else
        {
            player.GetComponent<PlayerManager>().enabled = true;            
        }

        if(time > 10)
        {
            this.enabled = false; //Avoid extra code running
        }
    }   
}