using UnityEngine;
using System.Collections;
public class CharController1 : MonoBehaviour {

    // BATUHAN ÖZTÜRK 
    // UPDATE ? -> 11.12.16

    public static bool GameMenuAktifMi_1;

    public Animator CharSwipe;

    public static bool YukariGidisEngeli1, AsagiGidisEngeli1, SolaGidisEngeli1, SagaGidisEngeli1;
    bool DenetSagaGidememe1, DenetSolaGidememe1, DenetAsagiGidememe1, DenetYukariGidememe1;

    public static bool CharControlSol1, CharControlSag1, CharControlYukari1, CharControlAsagi1;

    public static float YukariGidisDeger, AsagiGidisDeger, SolaGidisDeger, SagaGidisDeger;

    private float fingerStartTime = 0.0f;
    private Vector2 fingerStartPos = Vector2.zero;

    private bool isSwipe = false;
    private float minSwipeDist = 40.0f;
    private float maxSwipeTime = 2.0f;

    public static bool SwipeDisabledPauseMenu;
    public static bool SwipeDisabled;

    public static bool TopHareketEttimi;

    public static bool YesilTopEngeli_Kalkiyor;
    
    void Start()
    {
        YesilTopEngeli_Kalkiyor = false;

        TopHareketEttimi = false;

        SwipeDisabled = false;

        DenetSagaGidememe1 = false;
        DenetSolaGidememe1 = false;
        DenetAsagiGidememe1 = false;
        DenetYukariGidememe1 = false;

        YukariGidisEngeli1 = false;

        AsagiGidisEngeli1 = false;

        SolaGidisEngeli1 = false;

        SagaGidisEngeli1 = false;

    }

    void OnTriggerStay(Collider Temas) {

        if (Temas.gameObject.tag == "YesilKapi")
        {
            OyunMenu.YesilKapi = true;
        }

        if (!(transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy) || YesilTopEngeli_Kalkiyor)
        {
            if (Temas.gameObject.tag == "EngelSol") {

            SolaGidisEngeli1 = true;
            DenetSolaGidememe1 = true;
        }

        if (Temas.gameObject.tag == "EngelSag") {

            SagaGidisEngeli1 = true;
            DenetSagaGidememe1 = true;
        }

        if (Temas.gameObject.tag == "EngelAsagi")
        {
            AsagiGidisEngeli1 = true;
            DenetAsagiGidememe1 = true;
        }

        if (Temas.gameObject.tag == "EngelYukari")
        {
            YukariGidisEngeli1 = true;
            DenetYukariGidememe1 = true;
        }
        if (Temas.gameObject.tag == "KarakterSol1")
        {
            if (!DenetSolaGidememe1)
            {
                if (CharController2.SolaGidisEngeli2)
                {
                    SolaGidisEngeli1 = true;
                }
                else
                {
                    SolaGidisEngeli1 = false;
                }
            }
        }
        else if (Temas.gameObject.tag == "KarakterSol3")
        {
            if (!DenetSagaGidememe1)
            {
                if (CharController3.SagaGidisEngeli3)
                {
                    SagaGidisEngeli1 = true;
                }
                else
                {
                    SagaGidisEngeli1 = false;
                }
            }
        }

        if (Temas.gameObject.tag == "KarakterSag1")
        {
            if (!DenetSagaGidememe1)
            {
                if (CharController2.SagaGidisEngeli2)
                {
                    SagaGidisEngeli1 = true;
                }
                else
                {
                    SagaGidisEngeli1 = false;
                }
            }
        }
        else if (Temas.gameObject.tag == "KarakterSag3")
        {
            if (!DenetSolaGidememe1)
            {
                if (CharController3.SolaGidisEngeli3)
                {
                    SolaGidisEngeli1 = true;
                }
                else
                {
                    SolaGidisEngeli1 = false;
                }
            }
        }


        if (Temas.gameObject.tag == "KarakterUst1")
        {
            if (!DenetAsagiGidememe1)
            {
                if (CharController2.AsagiGidisEngeli2)
                {
                    AsagiGidisEngeli1 = true;
                }
                else
                {
                    AsagiGidisEngeli1 = false;
                }
            }
        }
        else if (Temas.gameObject.tag == "KarakterUst3")
        {
            if (!DenetAsagiGidememe1)
            {
                if (CharController3.AsagiGidisEngeli3)
                {
                    AsagiGidisEngeli1 = true;
                }
                else
                {
                    AsagiGidisEngeli1 = false;
                }
            }
        }

        if (Temas.gameObject.tag == "KarakterAlt1")
        {
            if (!DenetYukariGidememe1)
            {
                if (CharController2.YukariGidisEngeli2)
                {
                    YukariGidisEngeli1 = true;
                }
                else
                {
                    YukariGidisEngeli1 = false;
                }
            }
        }
        else if (Temas.gameObject.tag == "KarakterAlt3")
        {
            if (!DenetYukariGidememe1)
            {
                if (CharController3.YukariGidisEngeli3)
                {
                    YukariGidisEngeli1 = true;
                }
                else
                {
                    YukariGidisEngeli1 = false;
                }
            }
            }
        }
        else
        {
            SolaGidisEngeli1 = true;
            SagaGidisEngeli1 = true;
            YukariGidisEngeli1 = true;
            AsagiGidisEngeli1 = true;
        }


    }
    void OnTriggerExit(Collider TemasAyrim) {

        if (TemasAyrim.gameObject.tag == "YesilKapi")
        {
            OyunMenu.YesilKapi = false;
        }

        if (!(transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy) || YesilTopEngeli_Kalkiyor)
        {
            if (TemasAyrim.gameObject.tag == "EngelSol")
            {

                SolaGidisEngeli1 = false;
                DenetSolaGidememe1 = false;
            }
            if (TemasAyrim.gameObject.tag == "EngelSag")
            {

                SagaGidisEngeli1 = false;
                DenetSagaGidememe1 = false;
            }

            if (TemasAyrim.gameObject.tag == "EngelAsagi")
            {
                AsagiGidisEngeli1 = false;
                DenetAsagiGidememe1 = false;
            }

            if (TemasAyrim.gameObject.tag == "EngelYukari")
            {
                YukariGidisEngeli1 = false;
                DenetYukariGidememe1 = false;
            }

            if (TemasAyrim.gameObject.tag == "KarakterSol1")
            {
                if (!DenetSolaGidememe1)
                {
                    SolaGidisEngeli1 = false;
                }
            }
            if (TemasAyrim.gameObject.tag == "KarakterSol3")
            {
                if (!DenetSagaGidememe1)
                {
                    SagaGidisEngeli1 = false;
                }
            }


            if (TemasAyrim.gameObject.tag == "KarakterSag1")
            {
                if (!DenetSagaGidememe1)
                {
                    SagaGidisEngeli1 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterSag3")
            {
                if (!DenetSolaGidememe1)
                {
                    SolaGidisEngeli1 = false;
                }
            }


            if (TemasAyrim.gameObject.tag == "KarakterUst1")
            {
                if (!DenetAsagiGidememe1)
                {
                    AsagiGidisEngeli1 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterUst3")
            {
                if (!DenetAsagiGidememe1)
                {
                    AsagiGidisEngeli1 = false;
                }
            }

            if (TemasAyrim.gameObject.tag == "KarakterAlt1")
            {
                if (!DenetYukariGidememe1)
                {
                    YukariGidisEngeli1 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterAlt3")
            {
                if (!DenetYukariGidememe1)
                {
                    YukariGidisEngeli1 = false;
                }
            }
        }
        else
        {
            SolaGidisEngeli1 = true;
            SagaGidisEngeli1 = true;
            YukariGidisEngeli1 = true;
            AsagiGidisEngeli1 = true;
        }
    }
    void Update () {

        if ((transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy) && !YesilTopEngeli_Kalkiyor)
        {
            YukariGidisEngeli1 = true;

            AsagiGidisEngeli1 = true;

            SolaGidisEngeli1 = true;

            SagaGidisEngeli1 = true;
        }

        if (!SwipeDisabled && !SwipeDisabledPauseMenu) { 
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
                                        if (!SagaGidisEngeli1 && CharControlSag1)
                                        {
                                            transform.Translate(SagaGidisDeger, 0, 0);
                                            TopHareketEttimi = true;
                                            CharSwipe.Play("Icosa_SwipeRight", -1, 0);

                                             if (GameMenuAktifMi_1) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }

                                        if ((!CharController2.SagaGidisEngeli2 && CharController2.CharControlSag2) || (!CharController3.SagaGidisEngeli3 && CharController3.CharControlSag3))
                                            {

                                                OyunMenu.MoveCountGenel();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                       if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) { CharTouchClick.SecimIcinTopHareketEttimi = true; } else { CharTouchClick.SecimIcinTopHareketEttimi = false; }

                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }

                                            }

                                            else
                                            {

                                                OyunMenu.MoveCountChar1();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);

                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if ((!CharController2.SagaGidisEngeli2 && CharController2.CharControlSag2) || (!CharController3.SagaGidisEngeli3 && CharController3.CharControlSag3))
                                            {
                                                OyunMenu.MoveCountGenel();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }
                                            transform.Translate(0, 0, 0);
                                        }
                                    }
                                else
                                {
                                        if (!SolaGidisEngeli1 && CharControlSol1)
                                        {
                                            transform.Translate(SolaGidisDeger, 0, 0);                                  
                                            TopHareketEttimi = true;
                                            CharSwipe.Play("Icosa_SwipeLeft", -1, 0);
                                             if (GameMenuAktifMi_1) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }

                                            if ((!CharController2.SolaGidisEngeli2 && CharController2.CharControlSol2) || (!CharController3.SolaGidisEngeli3 && CharController3.CharControlSol3))
                                            {

                                                OyunMenu.MoveCountGenel();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }

                                            else
                                            {

                                                OyunMenu.MoveCountChar1();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if ((!CharController2.SolaGidisEngeli2 && CharController2.CharControlSol2) || (!CharController3.SolaGidisEngeli3 && CharController3.CharControlSol3))
                                            {
                                                OyunMenu.MoveCountGenel();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }
                                            transform.Translate(0, 0, 0);
                                        }

                                    }
                            }

                            if (swipeType.y != 0.0f)
                            {
                                if (swipeType.y > 0.0f)
                                {
                                        if (!YukariGidisEngeli1 && CharControlYukari1)
                                        {
                                            transform.Translate(0, YukariGidisDeger, 0);
                                            TopHareketEttimi = true;
                                            CharSwipe.Play("Icosa_SwipeUp", -1, 0);
                                             if (GameMenuAktifMi_1) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                                            if ((!CharController2.YukariGidisEngeli2 && CharController2.CharControlYukari2) || (!CharController3.YukariGidisEngeli3 && CharController3.CharControlYukari3))
                                            {

                                                OyunMenu.MoveCountGenel();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }

                                            else
                                            {

                                                OyunMenu.MoveCountChar1();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if ((!CharController2.YukariGidisEngeli2 && CharController2.CharControlYukari2) || (!CharController3.YukariGidisEngeli3 && CharController3.CharControlYukari3))
                                            {
                                                OyunMenu.MoveCountGenel();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }
                                            transform.Translate(0, 0, 0);
                                        }
                                    }
                                else
                                {
                                        if (!AsagiGidisEngeli1 && CharControlAsagi1)
                                        {
                                            transform.Translate(0, AsagiGidisDeger, 0);
                                            TopHareketEttimi = true;
                                            CharSwipe.Play("Icosa_SwipeDown", -1, 0);
                                             if (GameMenuAktifMi_1) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }

                                            if ((!CharController2.AsagiGidisEngeli2 && CharController2.CharControlAsagi2) || (!CharController3.AsagiGidisEngeli3 && CharController3.CharControlAsagi3))
                                            {

                                                OyunMenu.MoveCountGenel();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }

                                            else
                                            {

                                                OyunMenu.MoveCountChar1();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if ((!CharController2.AsagiGidisEngeli2 && CharController2.CharControlAsagi2) || (!CharController3.AsagiGidisEngeli3 && CharController3.CharControlAsagi3))
                                            {
                                                OyunMenu.MoveCountGenel();
                                                GameMenu_Ses_Efekt.RastgeleEfektSesi();
                                                
                                                if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                                                if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                                                }
                                                else
                                                {
                                                    BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                                                }
                                            }
                                            transform.Translate(0, 0, 0);
                                        }
                                    }
                            }

                        }

                        break;
                }
            }
        }


        if (Input.GetKeyDown(KeyCode.A)) {

            
            if (!SolaGidisEngeli1 && CharControlSol1)
                {
			    transform.Translate (SolaGidisDeger, 0,0);
                    TopHareketEttimi = true;
                CharSwipe.Play("Icosa_SwipeLeft", -1, 0);

                     if (GameMenuAktifMi_1) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }

    if ((!CharController2.SolaGidisEngeli2 && CharController2.CharControlSol2) || (!CharController3.SolaGidisEngeli3 && CharController3.CharControlSol3)) {

             OyunMenu.MoveCountGenel();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }

         else {

            OyunMenu.MoveCountChar1();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }
                }
			    else
              {
      if ((!CharController2.SolaGidisEngeli2 && CharController2.CharControlSol2) || (!CharController3.SolaGidisEngeli3 && CharController3.CharControlSol3))
                 {
              OyunMenu.MoveCountGenel();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }
                    transform.Translate (0,0,0);
             }

        }

        if (Input.GetKeyDown(KeyCode.S)) {
       
            if (!AsagiGidisEngeli1 && CharControlAsagi1) {
				    transform.Translate (0, AsagiGidisDeger, 0);
                    TopHareketEttimi = true;
                CharSwipe.Play("Icosa_SwipeDown", -1, 0);
                 if (GameMenuAktifMi_1) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }

             if ((!CharController2.AsagiGidisEngeli2 && CharController2.CharControlAsagi2) || (!CharController3.AsagiGidisEngeli3 && CharController3.CharControlAsagi3))
                    {

                        OyunMenu.MoveCountGenel();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }

                    else
                    {

                        OyunMenu.MoveCountChar1();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }
                }
                else
                {
                    if ((!CharController2.AsagiGidisEngeli2 && CharController2.CharControlAsagi2) || (!CharController3.AsagiGidisEngeli3 && CharController3.CharControlAsagi3))
                    {
                        OyunMenu.MoveCountGenel();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }
                    transform.Translate(0, 0, 0);
                }
            }

        if (Input.GetKeyDown(KeyCode.D)) {
     
            if (!SagaGidisEngeli1 && CharControlSag1) {
				    transform.Translate (SagaGidisDeger, 0, 0);
                    TopHareketEttimi = true;
                CharSwipe.Play("Icosa_SwipeRight", -1, 0);
                 if (GameMenuAktifMi_1) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                    if ((!CharController2.SagaGidisEngeli2 && CharController2.CharControlSag2) || (!CharController3.SagaGidisEngeli3 && CharController3.CharControlSag3))
                    {

                        OyunMenu.MoveCountGenel();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }

                    else
                    {

                        OyunMenu.MoveCountChar1();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }
                }
                else
                {
                    if ((!CharController2.SagaGidisEngeli2 && CharController2.CharControlSag2) || (!CharController3.SagaGidisEngeli3 && CharController3.CharControlSag3))
                    {
                        OyunMenu.MoveCountGenel();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }
                    transform.Translate(0, 0, 0);
                }
            }

        if (Input.GetKeyDown(KeyCode.W)) {
            if (!YukariGidisEngeli1 && CharControlYukari1) {
				    transform.Translate (0, YukariGidisDeger, 0);
                    TopHareketEttimi = true;
                CharSwipe.Play("Icosa_SwipeUp", -1, 0);
                 if (GameMenuAktifMi_1) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
      if ((!CharController2.YukariGidisEngeli2 && CharController2.CharControlYukari2) || (!CharController3.YukariGidisEngeli3 && CharController3.CharControlYukari3))
                    {

                        OyunMenu.MoveCountGenel();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }

                    else
                    {

                        OyunMenu.MoveCountChar1();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }
                }
                else
                {
                    if ((!CharController2.YukariGidisEngeli2 && CharController2.CharControlYukari2) || (!CharController3.YukariGidisEngeli3 && CharController3.CharControlYukari3))
                    {
                        OyunMenu.MoveCountGenel();
                        GameMenu_Ses_Efekt.RastgeleEfektSesi();
                        
                        if (transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(3).gameObject.activeInHierarchy) {  CharTouchClick.SecimIcinTopHareketEttimi = true;  }  Invoke("SecimTopHareketFalse",0.25f);
                        if (BarrierTouchClick.IptalEdici1 || BarrierTouchClick.IptalEdici2)
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = true;
                        }
                        else
                        {
                            BarrierTouchClick.SecimIcinHareketEdildiMi = false;
                        }
                    }
                    transform.Translate(0, 0, 0);
                }
            }

         }
        
    }
    void SecimTopHareketFalse()
    {
        CharTouchClick.SecimIcinTopHareketEttimi = false;
    }
}
