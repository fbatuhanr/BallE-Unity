using UnityEngine;
using System.Collections;
public class CharController3 : MonoBehaviour {

    // BATUHAN ÖZTÜRK 
    // UPDATE ? -> 7.01.17

    public static bool GameMenuAktifMi_3;

    public Animator CharSwipe;

    public static bool YukariGidisEngeli3, AsagiGidisEngeli3, SolaGidisEngeli3, SagaGidisEngeli3;
    bool DenetSagaGidememe3, DenetSolaGidememe3, DenetAsagiGidememe3, DenetYukariGidememe3;

    public static bool CharControlSol3, CharControlSag3, CharControlYukari3, CharControlAsagi3;

    public static float YukariGidisDeger, AsagiGidisDeger, SolaGidisDeger, SagaGidisDeger;

    private float fingerStartTime = 0.0f;
    private Vector2 fingerStartPos = Vector2.zero;

    private bool isSwipe = false;
    private float minSwipeDist = 40.0f;
    private float maxSwipeTime = 2.0f;

    public static bool SwipeDisabledPauseMenu;
    public static bool SwipeDisabled;

    public static bool TopHareketEttimi;

    public static bool MaviTopEngeli_Kalkiyor;
    
    void Start()
    {
        MaviTopEngeli_Kalkiyor = false;

        TopHareketEttimi = false;

        SwipeDisabled = false;

        DenetSagaGidememe3 = false;
        DenetSolaGidememe3 = false;
        DenetAsagiGidememe3 = false;
        DenetYukariGidememe3 = false;

        YukariGidisEngeli3 = false;

        AsagiGidisEngeli3 = false;

        SolaGidisEngeli3 = false;

        SagaGidisEngeli3 = false;
    }

    void OnTriggerStay(Collider Temas)
    {
        if (Temas.gameObject.tag == "MaviKapi")
        {
            OyunMenu.MaviKapi = true;
        }
        if (!(transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy) || MaviTopEngeli_Kalkiyor)
        {
            if (Temas.gameObject.tag == "EngelSol")
            {

                SolaGidisEngeli3 = true;
                DenetSolaGidememe3 = true;
            }

            if (Temas.gameObject.tag == "EngelSag")
            {
                SagaGidisEngeli3 = true;
                DenetSagaGidememe3 = true;
            }
            if (Temas.gameObject.tag == "EngelAsagi")
            {
                AsagiGidisEngeli3 = true;
                DenetAsagiGidememe3 = true;
            }

            if (Temas.gameObject.tag == "EngelYukari")
            {
                YukariGidisEngeli3 = true;
                DenetYukariGidememe3 = true;
            }


            if (Temas.gameObject.tag == "KarakterSol1")
            {
                if (!DenetSolaGidememe3)
                {
                    if (CharController2.SolaGidisEngeli2)
                    {
                        SolaGidisEngeli3 = true;
                    }
                    else
                    {
                        SolaGidisEngeli3 = false;
                    }
                }
            }
            else if (Temas.gameObject.tag == "KarakterSol2")
            {
                if (!DenetSolaGidememe3)
                {
                    if (CharController1.SolaGidisEngeli1)
                    {
                        SolaGidisEngeli3 = true;
                    }
                    else
                    {
                        SolaGidisEngeli3 = false;
                    }
                }
            }

            if (Temas.gameObject.tag == "KarakterSag1")
            {
                if (!DenetSagaGidememe3)
                {
                    if (CharController2.SagaGidisEngeli2)
                    {
                        SagaGidisEngeli3 = true;
                    }
                    else
                    {
                        SagaGidisEngeli3 = false;
                    }
                }
            }
            else if (Temas.gameObject.tag == "KarakterSag2")
            {
                if (!DenetSagaGidememe3)
                {
                    if (CharController1.SagaGidisEngeli1)
                    {
                        SagaGidisEngeli3 = true;
                    }
                    else
                    {
                        SagaGidisEngeli3 = false;
                    }
                }
            }


            if (Temas.gameObject.tag == "KarakterUst1")
            {
                if (!DenetAsagiGidememe3)
                {
                    if (CharController2.AsagiGidisEngeli2)
                    {
                        AsagiGidisEngeli3 = true;
                    }
                    else
                    {
                        AsagiGidisEngeli3 = false;
                    }
                }
            }
            else if (Temas.gameObject.tag == "KarakterUst2")
            {
                if (!DenetAsagiGidememe3)
                {
                    if (CharController1.AsagiGidisEngeli1)
                    {
                        AsagiGidisEngeli3 = true;
                    }
                    else
                    {
                        AsagiGidisEngeli3 = false;
                    }
                }
            }

            if (Temas.gameObject.tag == "KarakterAlt1")
            {
                if (!DenetYukariGidememe3)
                {
                    if (CharController2.YukariGidisEngeli2)
                    {
                        YukariGidisEngeli3 = true;
                    }
                    else
                    {
                        YukariGidisEngeli3 = false;
                    }
                }
            }
            else if (Temas.gameObject.tag == "KarakterAlt2")
            {
                if (!DenetYukariGidememe3)
                {
                    if (CharController1.YukariGidisEngeli1)
                    {
                        YukariGidisEngeli3 = true;
                    }
                    else
                    {
                        YukariGidisEngeli3 = false;
                    }
                }
            }
        }
        else
        {
            YukariGidisEngeli3 = true;

            AsagiGidisEngeli3 = true;

            SolaGidisEngeli3 = true;

            SagaGidisEngeli3 = true;
        }

    }
    void OnTriggerExit(Collider TemasAyrim)
    {
        if (TemasAyrim.gameObject.tag == "MaviKapi")
        {
            OyunMenu.MaviKapi = false;
        }
        if (!(transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy) || MaviTopEngeli_Kalkiyor)
        {
            if (TemasAyrim.gameObject.tag == "EngelSol")
            {

                SolaGidisEngeli3 = false;
                DenetSolaGidememe3 = false;
            }
            if (TemasAyrim.gameObject.tag == "EngelSag")
            {
                SagaGidisEngeli3 = false;
                DenetSagaGidememe3 = false;
            }
            if (TemasAyrim.gameObject.tag == "EngelAsagi")
            {
                AsagiGidisEngeli3 = false;
                DenetAsagiGidememe3 = false;
            }

            if (TemasAyrim.gameObject.tag == "EngelYukari")
            {
                YukariGidisEngeli3 = false;
                DenetYukariGidememe3 = false;
            }

            if (TemasAyrim.gameObject.tag == "KarakterSol1")
            {
                if (!DenetSolaGidememe3)
                {
                    SolaGidisEngeli3 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterSol2")
            {
                if (!DenetSolaGidememe3)
                {
                    SolaGidisEngeli3 = false;
                }
            }

            if (TemasAyrim.gameObject.tag == "KarakterSag1")
            {
                if (!DenetSagaGidememe3)
                {
                    SagaGidisEngeli3 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterSag2")
            {
                if (!DenetSagaGidememe3)
                {
                    SagaGidisEngeli3 = false;
                }
            }


            if (TemasAyrim.gameObject.tag == "KarakterUst1")
            {
                if (!DenetAsagiGidememe3)
                {
                    AsagiGidisEngeli3 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterUst2")
            {
                if (!DenetAsagiGidememe3)
                {
                    AsagiGidisEngeli3 = false;
                }
            }

            if (TemasAyrim.gameObject.tag == "KarakterAlt1")
            {
                if (!DenetYukariGidememe3)
                {
                    YukariGidisEngeli3 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterAlt2")
            {
                if (!DenetYukariGidememe3)
                {
                    YukariGidisEngeli3 = false;
                }
            }
        }
        else
        {
            YukariGidisEngeli3 = true;

            AsagiGidisEngeli3 = true;

            SolaGidisEngeli3 = true;

            SagaGidisEngeli3 = true;
        }

    }


    void Update()
    {
        if ((transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy) && !MaviTopEngeli_Kalkiyor)
        {
            YukariGidisEngeli3 = true;

            AsagiGidisEngeli3 = true;

            SolaGidisEngeli3 = true;

            SagaGidisEngeli3 = true;
        }


        if (!SwipeDisabled && !SwipeDisabledPauseMenu)
        {
            {
                if (Input.touchCount > 0 && Input.touchCount < 2)
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

                                            if (!SagaGidisEngeli3 && CharControlSag3)
                                            {
                                                transform.Translate(SagaGidisDeger, 0, 0);
                                                TopHareketEttimi = true;
                                                CharSwipe.Play("Icosa_SwipeRight", -1, 0);
                                                 if (GameMenuAktifMi_3) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                                            }
                                            else
                                            {
                                                transform.Translate(0, 0, 0);
                                            }
                                        }
                                        else
                                        {
                                            if (!SolaGidisEngeli3 && CharControlSol3)
                                            {
                                                transform.Translate(SolaGidisDeger, 0, 0);
                                                TopHareketEttimi = true;
                                                CharSwipe.Play("Icosa_SwipeLeft", -1, 0);
                                                 if (GameMenuAktifMi_3) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                                            }
                                            else
                                            {
                                                transform.Translate(0, 0, 0);
                                            }
                                        }
                                    }

                                    if (swipeType.y != 0.0f)
                                    {
                                        if (swipeType.y > 0.0f)
                                        {
                                            if (!YukariGidisEngeli3 && CharControlYukari3)
                                            {
                                                transform.Translate(0, YukariGidisDeger, 0);
                                                TopHareketEttimi = true;
                                                CharSwipe.Play("Icosa_SwipeUp", -1, 0);
                                                 if (GameMenuAktifMi_3) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                                            }
                                            else
                                            {
                                                transform.Translate(0, 0, 0);
                                            }
                                        }
                                        else
                                        {
                                            if (!AsagiGidisEngeli3 && CharControlAsagi3)
                                            {
                                                transform.Translate(0, AsagiGidisDeger, 0);
                                                TopHareketEttimi = true;
                                                CharSwipe.Play("Icosa_SwipeDown", -1, 0);
                                                 if (GameMenuAktifMi_3) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                                            }
                                            else
                                            {
                                                transform.Translate(0, 0, 0);
                                            }
                                        }
                                    }

                                }

                                break;
                        }
                    }
                }

                if (Input.GetKeyDown(KeyCode.A))
                {
                    if (!SolaGidisEngeli3 && CharControlSol3)
                    {
                        transform.Translate(SolaGidisDeger, 0, 0);
                        TopHareketEttimi = true;
                        CharSwipe.Play("Icosa_SwipeLeft", -1, 0);
                         if (GameMenuAktifMi_3) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                    }
                    else
                    {
                        transform.Translate(0, 0, 0);
                    }
                }
                if (Input.GetKeyDown(KeyCode.S))
                {

                    if (!AsagiGidisEngeli3 && CharControlAsagi3)
                    {
                        transform.Translate(0, AsagiGidisDeger, 0);
                        TopHareketEttimi = true;
                        CharSwipe.Play("Icosa_SwipeDown", -1, 0);
                         if (GameMenuAktifMi_3) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                    }
                    else
                    {
                        transform.Translate(0, 0, 0);
                    }
                }

                if (Input.GetKeyDown(KeyCode.D))
                {
                    if (!SagaGidisEngeli3 && CharControlSag3)
                    {
                        transform.Translate(SagaGidisDeger, 0, 0);
                        TopHareketEttimi = true;
                        CharSwipe.Play("Icosa_SwipeRight", -1, 0);
                         if (GameMenuAktifMi_3) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                    }
                    else
                    {
                        transform.Translate(0, 0, 0);
                    }
                }

                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (!YukariGidisEngeli3 && CharControlYukari3)
                    {
                        transform.Translate(0, YukariGidisDeger, 0);
                        TopHareketEttimi = true;
                        CharSwipe.Play("Icosa_SwipeUp", -1, 0);
                         if (GameMenuAktifMi_3) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                    }
                    else
                    {
                        transform.Translate(0, 0, 0);
                    }
                }
            }
        }
    }
}

