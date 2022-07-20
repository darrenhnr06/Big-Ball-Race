using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BarMeter : MonoBehaviour
{
    public Animation anim;
    public bool isplayerTurn;
    public TMP_Text barMetertext;
    public bool isnotTurnandShoot;
    public float tapOnTimePlayerRot;

    public CharacterMovement characterMovement;
    private bool perfectHit = false;
    private bool barMeterRunning = true;
    private bool detectBartouch = false;
    void Start()
    {
        //barMetertext.text = Gamemanager.instance.playerTotalHealth.ToString();
        //UiManager.instance.taptoshoot.SetActive(true);
        //UiManager.instance.playerTextBox.SetActive(false);
        //UiManager.instance.enemyTextBox.SetActive(false);
        //Player.instance.transform.rotation = Quaternion.Euler(0, tapOnTimePlayerRot, 0);

    }

    private void OnEnable()
    {
        anim.Play();
        detectBartouch = true;
    }

    void Update()
    {
        if (detectBartouch)
        {
            if (Input.GetMouseButtonDown(0))
            {
                float value = (transform.GetChild(0).localPosition.x);
                ArrowPosition(value);
                anim.Stop();
                barMeterRunning = false;
                if (!isnotTurnandShoot)
                {
          //          Player.instance.Animations("TurnAndShoot");
                }
                else
                {
          //          Player.instance.Animations("Pistol");
          //          Player.instance.transform.rotation = Quaternion.Euler(0,tapOnTimePlayerRot, 0);
                }
                isplayerTurn = true;
          //      UiManager.instance.taptoshoot.SetActive(false);
            }
          
        }
        //else
        //{
        //    gameObject.SetActive(false);
        //}
    }

    void ArrowPosition(float pos)
    {
            //if (0.007f > pos && pos > -0.007f)
            //{
            //     Debug.Log("Exact MIddle");
            //     Player.instance.playerBulletSpawner.Invoke("HeadShot", 0.9f);
             if (0.01f > pos && pos > -0.01f)
            {
            //Player.instance.playerBulletSpawner.Invoke("HeadShot", 0.9f);

            perfectHit = true;

                awesomeText(0);
            }
            else if (0.0602f > pos && pos > -0.0579f || -0.0602f < pos && pos < 0.0579f)
            {
                 //Player.instance.playerBulletSpawner.Invoke("BodyShot", 0.9f);
                 //Gamemanager.instance.healthDecreamentValue = 180;
                 awesomeText(1);
            perfectHit = true;

        }
            else if (0.1781f > pos && pos > 0.0602f || -0.1781f < pos && pos < -0.0602f)
            {
                   // Player.instance.playerBulletSpawner.Invoke("BodyShot", 0.9f);
                   // Gamemanager.instance.healthDecreamentValue = 101;
                     awesomeText(2);
            perfectHit = false;
        }
            else if (0.2893f > pos && pos > 0.1781f || -0.2893f < pos && pos < -0.1781f)
            {
                //Player.instance.playerBulletSpawner.Invoke("BodyShot", 0.9f);
                //Gamemanager.instance.healthDecreamentValue = 96;
                awesomeText(3);
            perfectHit = false;
        }
            else if (0.3916f > pos && pos > 0.2893f || -0.3916f < pos && pos < -0.289f)
            {
                  //  Player.instance.playerBulletSpawner.Invoke("BodyShot", 0.9f);
                  //  Gamemanager.instance.healthDecreamentValue = 63;
                    awesomeText(4);
            perfectHit = false;
        }
            else if (0.4769f > pos && pos > 0.3916f || -0.4769f < pos && pos < -0.3916f)
            {
                    //Player.instance.playerBulletSpawner.Invoke("BodyShot", 0.9f);
                    //Gamemanager.instance.healthDecreamentValue = 38;
                     awesomeText(5);
            perfectHit = false;
        }
        healthGain();
    }
    void healthGain()
    {
        //barMetertext.text = (Gamemanager.instance.healthDecreamentValue).ToString();
    }
    void awesomeText(int i)
    {
        //UiManager.instance.awesomeTapAnimation(i);
    }

    public bool ReturnBarMeterRunning()
    {
        return barMeterRunning;
    }

    public bool ReturnPerfectHit()
    {
        return perfectHit;
    }

    public void SetBarRunning(bool value)
    {
        barMeterRunning = value;
    }

    public void SetBarTouch(bool value)
    {
        detectBartouch = value;
    }

    public bool GetBarTouch()
    {
        return detectBartouch;
    }
    
}
