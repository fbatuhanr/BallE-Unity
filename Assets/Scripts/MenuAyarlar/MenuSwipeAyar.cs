using UnityEngine;
using System.Collections;

public class MenuSwipeAyar : MonoBehaviour {

    public static bool CanYokSwipeStart;

    Animator MenuSwipe;

    private float fingerStartTime = 0.0f;
    private Vector2 fingerStartPos = Vector2.zero;

    private bool isSwipe = false;
    private float minSwipeDist = 100.0f;
    private float maxSwipeTime = 1.5f;

    public static bool KaydirmaKilit;

    public static int tch;

    void KaldiginBolumdenDevam()
    {
        if (AnaMenu.Bolum != 151) { 
            if (OyuncuAyar.Can > 0 || AnaMenu.AnaMenuSonradanDonulurse || OyuncuAyar.SinirsizCan == 1) {

                CanYokSwipeStart = false;

            MenuSwipe.Play("MenuPanel", -1, 0f);
            Invoke("BolumAyarlari", 1.1f);

            }
            else
            {
                CanYokSwipeStart = true;
            }
        }
    }

    void BolumAyarlari()
    {
        tch = 0;

        OyuncuAyar.Menu_isActive = 0;
        PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);
    }

    void Start()
    {
        MenuSwipe = GetComponent<Animator>();
        KaydirmaKilit = false;
        tch = 0;
    }

    void Update () {

        AnaMenu.Bolum = PlayerPrefs.GetInt("OyuncuHangiBolumdeKaldi");
        OyuncuAyar.Can = PlayerPrefs.GetInt("Can");

        if (Input.touchCount > tch)
        {
            foreach (Touch touch in Input.touches)
            {
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        /* this is a new touch */
                        isSwipe = true;
                        fingerStartTime = Time.time;
                        fingerStartPos = touch.position;
                        break;

                    case TouchPhase.Canceled:
                        /* The touch is being canceled */
                        isSwipe = false;
                        break;

                    case TouchPhase.Ended:

                        float gestureTime = Time.time - fingerStartTime;
                        float gestureDist = (touch.position - fingerStartPos).magnitude;

                        if (isSwipe && gestureTime < maxSwipeTime && gestureDist > minSwipeDist)
                        {
                            Vector2 direction = touch.position - fingerStartPos;
                            Vector2 swipeType = Vector2.zero;

                            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                            {
                                // the swipe is horizontal:
                                swipeType = Vector2.right * Mathf.Sign(direction.x);
                            }
                            else
                            {
                                // the swipe is vertical:
                                swipeType = Vector2.up * Mathf.Sign(direction.y);
                            }

                            if (swipeType.x != 0.0f)
                            {
                                if (swipeType.x > 0.0f)
                                {
                            AnaMenu.MenuSwipeSoldanSaga = true;
                                    AnaMenu.MenuSwipeSagdanSola = false;
                                }
                                else
                                {
                            AnaMenu.MenuSwipeSagdanSola = true;
                                    AnaMenu.MenuSwipeSoldanSaga = false;
                                }
                            }

                            if (swipeType.y != 0.0f)
                            {
                                if (swipeType.y > 0.0f)
                                {
                                    // YUKARI KAYDIRINCA
                                    if (!KaydirmaKilit)
                                    {
                                        KaldiginBolumdenDevam();
                                        tch = 100;
                                    }
                                }
                                else
                                {
                                   // ASAGI
                                }
                            }

                        }

                        break;
                }
            }
        }
    }
  }