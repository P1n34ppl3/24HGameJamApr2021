using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StageMenager : MonoBehaviour
{
    public TextMeshProUGUI AnnouncText;

    void Update()
    {
        if (Score.CurrentScore == 1)
        {

            Stage1();
        }
        if (Score.CurrentScore == 20)
        {
            Stage2();
        }
        if (Score.CurrentScore == 40)
        {
            Stage3();
        }
        if (Score.CurrentScore == 60)
        {
            Stage4();
        }
    }
    void Stage1()
    {
        GameObject.FindObjectOfType<AudioManager>().Play("Horn");
        AnnouncText.text = "The enemies have breached the West gate, seek cover!";
        Invoke("clear", 3);
        
    }
    void Stage2()
    {
        GameObject.FindObjectOfType<AudioManager>().Play("Horn");
        AnnouncText.text = "The East gate has now been breached!";
        Invoke("clear", 3);
      
    }
    void Stage3()
    {
        GameObject.FindObjectOfType<AudioManager>().Play("Horn");
        AnnouncText.text = "The East gate has now been breached!";
        Invoke("clear", 3);
        
    }
    void Stage4()
    {
        GameObject.FindObjectOfType<AudioManager>().Play("Horn");
        AnnouncText.text = "The East gate has now been breached!";
        Invoke("clear", 3);
       
    }
    void clear()
    {
        AnnouncText.text = "";
    }
}
