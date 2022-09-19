using UnityEngine;
using System.Collections;
public class CharController2 : MonoBehaviour {

    // BATUHAN ÖZTÜRK 
    // UPDATE ? -> 11.12.16

    public static bool GameMenuAktifMi_2;

    public Animator CharSwipe;

    public static bool YukariGidisEngeli2, AsagiGidisEngeli2, SolaGidisEngeli2, SagaGidisEngeli2;
    bool DenetSagaGidememe2, DenetSolaGidememe2, DenetAsagiGidememe2, DenetYukariGidememe2;

    public static bool CharControlSol2, CharControlSag2, CharControlYukari2, CharControlAsagi2;

    public static float YukariGidisDeger, AsagiGidisDeger, SolaGidisDeger, SagaGidisDeger;

    private float fingerStartTime = 0.0f;
    private Vector2 fingerStartPos = Vector2.zero;

    private bool isSwipe = false;
    private float minSwipeDist = 40.0f;
    private float maxSwipeTime = 2.0f;

    public static bool SwipeDisabledPauseMenu;
    public static bool SwipeDisabled;

    public static bool TopHareketEttimi;

    public static bool SariTopEngeli_Kalkiyor;

    void Start()
    {
        SariTopEngeli_Kalkiyor = false;

        TopHareketEttimi = false;

        SwipeDisabled = false;

        DenetSagaGidememe2 = false;
        DenetSolaGidememe2 = false;
        DenetAsagiGidememe2 = false;
        DenetYukariGidememe2 = false;
		
		YukariGidisEngeli2 = false;

		AsagiGidisEngeli2 = false;

		SolaGidisEngeli2 = false;

		SagaGidisEngeli2 = false;
	}

	void OnTriggerStay(Collider Temas){

        if (Temas.gameObject.tag == "SariKapi")
        {
            OyunMenu.SariKapi = true;
        }
        if (!(transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy) || SariTopEngeli_Kalkiyor)
        {
            if (Temas.gameObject.tag == "EngelSol")
            {

                SolaGidisEngeli2 = true;
                DenetSolaGidememe2 = true;
            }

            if (Temas.gameObject.tag == "EngelSag")
            {

                SagaGidisEngeli2 = true;
                DenetSagaGidememe2 = true;
            }
            if (Temas.gameObject.tag == "EngelAsagi")
            {
                AsagiGidisEngeli2 = true;
                DenetAsagiGidememe2 = true;
            }

            if (Temas.gameObject.tag == "EngelYukari")
            {
                YukariGidisEngeli2 = true;
                DenetYukariGidememe2 = true;
            }


            if (Temas.gameObject.tag == "KarakterSol2")
            {
                if (!DenetSolaGidememe2)
                {
                    if (CharController1.SolaGidisEngeli1)
                    {
                        SolaGidisEngeli2 = true;
                    }
                    else
                    {
                        SolaGidisEngeli2 = false;
                    }
                }
            }
            else if (Temas.gameObject.tag == "KarakterSol3")
            {
                if (!DenetSagaGidememe2)
                {
                    if (CharController3.SagaGidisEngeli3)
                    {
                        SagaGidisEngeli2 = true;
                    }
                    else
                    {
                        SagaGidisEngeli2 = false;
                    }
                }
            }

            if (Temas.gameObject.tag == "KarakterSag2")
            {
                if (!DenetSagaGidememe2)
                {
                    if (CharController1.SagaGidisEngeli1)
                    {
                        SagaGidisEngeli2 = true;
                    }
                    else
                    {
                        SagaGidisEngeli2 = false;
                    }
                }
            }
            else if (Temas.gameObject.tag == "KarakterSag3")
            {
                if (!DenetSolaGidememe2)
                {
                    if (CharController3.SolaGidisEngeli3)
                    {
                        SolaGidisEngeli2 = true;
                    }
                    else
                    {
                        SolaGidisEngeli2 = false;
                    }
                }
            }


            if (Temas.gameObject.tag == "KarakterUst2")
            {
                if (!DenetAsagiGidememe2)
                {
                    if (CharController1.AsagiGidisEngeli1)
                    {
                        AsagiGidisEngeli2 = true;
                    }
                    else
                    {
                        AsagiGidisEngeli2 = false;
                    }
                }
            }
            else if (Temas.gameObject.tag == "KarakterUst3")
            {
                if (!DenetAsagiGidememe2)
                {
                    if (CharController3.AsagiGidisEngeli3)
                    {
                        AsagiGidisEngeli2 = true;
                    }
                    else
                    {
                        AsagiGidisEngeli2 = false;
                    }
                }
            }

            if (Temas.gameObject.tag == "KarakterAlt2")
            {
                if (!DenetYukariGidememe2)
                {
                    if (CharController1.YukariGidisEngeli1)
                    {
                        YukariGidisEngeli2 = true;
                    }
                    else
                    {
                        YukariGidisEngeli2 = false;
                    }
                }
            }
            else if (Temas.gameObject.tag == "KarakterAlt3")
            {
                if (!DenetYukariGidememe2)
                {
                    if (CharController3.YukariGidisEngeli3)
                    {
                        YukariGidisEngeli2 = true;
                    }
                    else
                    {
                        YukariGidisEngeli2 = false;
                    }
                }
            }
        }
        else
        {
            YukariGidisEngeli2 = true;

            AsagiGidisEngeli2 = true;

            SolaGidisEngeli2 = true;

            SagaGidisEngeli2 = true;
        }

    }
	void OnTriggerExit(Collider TemasAyrim){

        if (TemasAyrim.gameObject.tag == "SariKapi")
        {
            OyunMenu.SariKapi = false;
        }
        if (!(transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy) || SariTopEngeli_Kalkiyor)
        {
            if (TemasAyrim.gameObject.tag == "EngelSol")
            {

                SolaGidisEngeli2 = false;
                DenetSolaGidememe2 = false;
            }
            if (TemasAyrim.gameObject.tag == "EngelSag")
            {

                SagaGidisEngeli2 = false;
                DenetSagaGidememe2 = false;
            }
            if (TemasAyrim.gameObject.tag == "EngelAsagi")
            {
                AsagiGidisEngeli2 = false;
                DenetAsagiGidememe2 = false;
            }

            if (TemasAyrim.gameObject.tag == "EngelYukari")
            {
                YukariGidisEngeli2 = false;
                DenetYukariGidememe2 = false;
            }


            if (TemasAyrim.gameObject.tag == "KarakterSol2")
            {
                if (!DenetSolaGidememe2)
                {
                    SolaGidisEngeli2 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterSol3")
            {
                if (!DenetSagaGidememe2)
                {
                    SagaGidisEngeli2 = false;
                }
            }

            if (TemasAyrim.gameObject.tag == "KarakterSag2")
            {
                if (!DenetSagaGidememe2)
                {
                    SagaGidisEngeli2 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterSag3")
            {
                if (!DenetSolaGidememe2)
                {
                    SolaGidisEngeli2 = false;
                }
            }


            if (TemasAyrim.gameObject.tag == "KarakterUst2")
            {
                if (!DenetAsagiGidememe2)
                {
                    AsagiGidisEngeli2 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterUst3")
            {
                if (!DenetAsagiGidememe2)
                {
                    AsagiGidisEngeli2 = false;
                }
            }

            if (TemasAyrim.gameObject.tag == "KarakterAlt2")
            {
                if (!DenetYukariGidememe2)
                {
                    YukariGidisEngeli2 = false;
                }
            }
            else if (TemasAyrim.gameObject.tag == "KarakterAlt3")
            {
                if (!DenetYukariGidememe2)
                {
                    YukariGidisEngeli2 = false;
                }
            }
        }
        else
        {
            YukariGidisEngeli2 = true;

            AsagiGidisEngeli2 = true;

            SolaGidisEngeli2 = true;

            SagaGidisEngeli2 = true;
        }

    }

    void Update() {

        if ((transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy) && !SariTopEngeli_Kalkiyor)
        {
            YukariGidisEngeli2 = true;

            AsagiGidisEngeli2 = true;

            SolaGidisEngeli2 = true;

            SagaGidisEngeli2 = true;
        }


        if (!SwipeDisabled && !SwipeDisabledPauseMenu)
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
                                        if (!SagaGidisEngeli2 && CharControlSag2)
                                        {
                                            transform.Translate(SagaGidisDeger, 0, 0);
                                                TopHareketEttimi = true;
                                            CharSwipe.Play("Icosa_SwipeRight", -1, 0);
                                             if (GameMenuAktifMi_2) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                                        }
                                        else
                                        {
                                            transform.Translate(0, 0, 0);

                                        }
                                    }
                                    else
                                    {
                                        if (!SolaGidisEngeli2 && CharControlSol2)
                                        {
                                            transform.Translate(SolaGidisDeger, 0, 0);
                                                TopHareketEttimi = true;
                                            CharSwipe.Play("Icosa_SwipeLeft", -1, 0);
                                             if (GameMenuAktifMi_2) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
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
                                        if (!YukariGidisEngeli2 && CharControlYukari2)
                                        {
                                            transform.Translate(0, YukariGidisDeger, 0);
                                                  TopHareketEttimi = true;
                                            CharSwipe.Play("Icosa_SwipeUp", -1, 0);
                                             if (GameMenuAktifMi_2) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                                        }
                                        else
                                        {
                                            transform.Translate(0, 0, 0);
                                        }
                                    }
                                    else
                                    {
                                        if (!AsagiGidisEngeli2 && CharControlAsagi2)
                                        {
                                            transform.Translate(0, AsagiGidisDeger, 0);
                                                 TopHareketEttimi = true;
                                            CharSwipe.Play("Icosa_SwipeDown", -1, 0);
                                             if (GameMenuAktifMi_2) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
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
                if (!SolaGidisEngeli2 && CharControlSol2)
                {
                    transform.Translate(SolaGidisDeger, 0, 0);
                    TopHareketEttimi = true;
                    CharSwipe.Play("Icosa_SwipeLeft", -1, 0);
                     if (GameMenuAktifMi_2) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                }
                else
                {
                    transform.Translate(0, 0, 0);
                }
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (!AsagiGidisEngeli2 && CharControlAsagi2)
                {
                    transform.Translate(0, AsagiGidisDeger, 0);
                    TopHareketEttimi = true;
                    CharSwipe.Play("Icosa_SwipeDown", -1, 0);
                     if (GameMenuAktifMi_2) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                }
                else
                {
                    transform.Translate(0, 0, 0);
                }
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                if (!SagaGidisEngeli2 && CharControlSag2)
                {
                    transform.Translate(SagaGidisDeger, 0, 0);
                    TopHareketEttimi = true;
                    CharSwipe.Play("Icosa_SwipeRight", -1, 0);
                     if (GameMenuAktifMi_2) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                }
                else
                {
                    transform.Translate(0, 0, 0);
                }
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (!YukariGidisEngeli2 && CharControlYukari2)
                {
                    transform.Translate(0, YukariGidisDeger, 0);
                    TopHareketEttimi = true;
                    CharSwipe.Play("Icosa_SwipeUp", -1, 0);
                     if (GameMenuAktifMi_2) { GameObject.Find("Canvas/GameMenu_Design/Gostergeler/Hareketler_ve_DahaFazla/Hareket_ve_Sayisi/MoveSayisi").GetComponent<Animator>().Play("CanToplarSayi", -1, 0f); }
                }
                else
                {
                    transform.Translate(0, 0, 0);
                }
            }
        }
    }
}