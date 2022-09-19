using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolumRastgele : MonoBehaviour {
    
    int Dikey_Sayisi,Yatay_Sayisi;

    public GameObject VerticalBarrier, HorizontalBarrier;

    public GameObject GreenDoor, YellowDoor, BlueDoor;

    public GameObject GreenBall, YellowBall, BlueBall;

    bool DestroyAllBarrier;

    Transform ball_1, ball_2, ball_3, door_1,door_2,door_3;

    void Start () {

        DestroyAllBarrier = false;

        ball_1 = GameObject.Find("Bolum/Karakter1").transform;
        ball_2 = GameObject.Find("Bolum/Karakter2").transform;
        ball_3 = GameObject.Find("Bolum/Karakter3").transform;

        door_1 = GameObject.Find("Bolum/GreenDoor").transform;
        door_2 = GameObject.Find("Bolum/YellowDoor").transform;
        door_3 = GameObject.Find("Bolum/BlueDoor").transform;

    }

    /*
        6 x 11 ' lik bir bölümde:

        Koordinat x - y 11:
        (1,11) --> posx = -2.413f , posy = 4.441f , posz = -1.77454f
        (2,11) --> posx = -1.45f , posy = 4.441f , posz = -1.77454f
        (3,11) --> posx = -0.47f , posy = 4.441f , posz = -1.77454f
        (4,11) --> posx = 0.515f , posy = 4.441f , posz = -1.77454f
        (5,11) --> posx = 1.48f , posy = 4.441f , posz = -1.77454f
        (6,11) --> posx = 2.438f , posy = 4.441f , posz = -1.77454f
        
        Koordinat x - y 10:
        (1,10) --> posx = -2.413f , posy = 3.524f , posz = -1.77454f
        (2,10) --> posx = -1.45f , posy = 3.524f , posz = -1.77454f
        (3,10) --> posx = -0.47f , posy = 3.524f , posz = -1.77454f
        (4,10) --> posx = 0.515f , posy = 3.524f , posz = -1.77454f
        (5,10) --> posx = 1.48f , posy = 3.524f , posz = -1.77454f
        (6,10) --> posx = 2.438f , posy = 3.524f , posz = -1.77454f
        
        Koordinat x - y 9:
        (1,9) --> posx = -2.413f , posy = 2.583f , posz = -1.77454f
        (2,9) --> posx = -1.45f , posy = 2.583f , posz = -1.77454f
        (3,9) --> posx = -0.47f , posy = 2.583f , posz = -1.77454f
        (4,9) --> posx = 0.515f , posy = 2.583f , posz = -1.77454f
        (5,9) --> posx = 1.48f , posy = 2.583f , posz = -1.77454f
        (6,9) --> posx = 2.438f , posy = 2.583f , posz = -1.77454f
        
        Koordinat x - y 8:
        (1,8) --> posx = -2.413f , posy = 1.656f , posz = -1.77454f
        (2,8) --> posx = -1.45f , posy = 1.656f , posz = -1.77454f
        (3,8) --> posx = -0.47f , posy = 1.656f , posz = -1.77454f
        (4,8) --> posx = 0.515f , posy = 1.656f , posz = -1.77454f
        (5,8) --> posx = 1.48f , posy = 1.656f , posz = -1.77454f
        (6,8) --> posx = 2.438f , posy = 1.656f , posz = -1.77454f
        
        Koordinat x - y 7:
        (1,7) --> posx = -2.413f , posy = 0.733f , posz = -1.77454f
        (2,7) --> posx = -1.45f , posy = 0.733f , posz = -1.77454f
        (3,7) --> posx = -0.47f , posy = 0.733f , posz = -1.77454f
        (4,7) --> posx = 0.515f , posy = 0.733f , posz = -1.77454f
        (5,7) --> posx = 1.48f , posy = 0.733f , posz = -1.77454f
        (6,7) --> posx = 2.438f , posy = 0.733f , posz = -1.77454f
        
        Koordinat x - y 6:
        (1,6) --> posx = -2.413f , posy = -0.207f , posz = -1.77454f
        (2,6) --> posx = -1.45f , posy = -0.207f , posz = -1.77454f
        (3,6) --> posx = -0.47f , posy = -0.207f , posz = -1.77454f
        (4,6) --> posx = 0.515f , posy = -0.207f , posz = -1.77454f
        (5,6) --> posx = 1.48f , posy = -0.207f , posz = -1.77454f
        (6,6) --> posx = 2.438f , posy = -0.207f , posz = -1.77454f
        
        Koordinat x - y 5:
        (1,5) --> posx = -2.413f , posy = -1.144f , posz = -1.77454f
        (2,5) --> posx = -1.45f , posy = -1.144f , posz = -1.77454f
        (3,5) --> posx = -0.47f , posy = -1.144f , posz = -1.77454f
        (4,5) --> posx = 0.515f , posy = -1.144f , posz = -1.77454f
        (5,5) --> posx = 1.48f , posy = -1.144f , posz = -1.77454f
        (6,5) --> posx = 2.438f , posy = -1.144f , posz = -1.77454f
        
        Koordinat x - y 4:
        (1,4) --> posx = -2.413f , posy = -2.091f , posz = -1.77454f
        (2,4) --> posx = -1.45f , posy = -2.091f , posz = -1.77454f
        (3,4) --> posx = -0.47f , posy = -2.091f , posz = -1.77454f
        (4,4) --> posx = 0.515f , posy = -2.091f , posz = -1.77454f
        (5,4) --> posx = 1.48f , posy = -2.091f , posz = -1.77454f
        (6,4) --> posx = 2.438f , posy = -2.091f , posz = -1.77454f
        
        Koordinat x - y 3:
        (1,3) --> posx = -2.413f , posy = -3.038f , posz = -1.77454f
        (2,3) --> posx = -1.45f , posy = -3.038f , posz = -1.77454f
        (3,3) --> posx = -0.47f , posy = -3.038f , posz = -1.77454f
        (4,3) --> posx = 0.515f , posy = -3.038f , posz = -1.77454f
        (5,3) --> posx = 1.48f , posy = -3.038f , posz = -1.77454f
        (6,3) --> posx = 2.438f , posy = -3.038f , posz = -1.77454f
        
        Koordinat x - y 2:
        (1,2) --> posx = -2.413f , posy = -3.981f , posz = -1.77454f
        (2,2) --> posx = -1.45f , posy = -3.981f , posz = -1.77454f
        (3,2) --> posx = -0.47f , posy = -3.981f , posz = -1.77454f
        (4,2) --> posx = 0.515f , posy = -3.981f , posz = -1.77454f
        (5,2) --> posx = 1.48f , posy = -3.981f , posz = -1.77454f
        (6,2) --> posx = 2.438f , posy = -3.981f , posz = -1.77454f
    
        Koordinat x - y 1:
        (1,1) --> posx = -2.413f , posy = -4.896f , posz = -1.77454f
        (2,1) --> posx = -1.45f , posy = -4.896f , posz = -1.77454f
        (3,1) --> posx = -0.47f , posy = -4.896f , posz = -1.77454f
        (4,1) --> posx = 0.515f , posy = -4.896f , posz = -1.77454f
        (5,1) --> posx = 1.48f , posy = -4.896f , posz = -1.77454f
        (6,1) --> posx = 2.438f , posy = -4.896f , posz = -1.77454f



        VerticalBarrier --> y
        11 --> posy = 4.45f;
        10 --> pos y = 3.529f;
        9 --> posy = 2.591f
        8 --> pos y = 1.66f
        7 --> posy = 0.725f
        6 --> pos y = -0.207f
        5 --> posy = -1.145f
        4 --> pos y = -2.091f
        3 --> posy = -3.04f
        2 --> pos y = -3.981f
        1 --> pos y = -4.9f

        VerticalBarrier --> x
        1 --> pos x = -1.935f
        2 --> pos x = -0.968f
        3 --> pos x = 0.025f
        4 --> pos x = 0.997f
        5 --> pos x = 1.969f


        HorizontalBarrier --> y
        10 --> pos y = 3.99f;
        9 --> pos y = 3.06f; 
        8 --> pos y = 2.115f;
        7 --> pos y = 1.2015f
        6 --> pos y = 0.2556f;
        5 --> pos y = -0.6737f
        4 --> pos y = -1.6184f
        3 --> pos y = -2.5638f
        2 --> pos y = -3.5103f
        1 --> pos y = -4.4544f

        HorizontalBarrier --> x
        1 --> pos x = -2.411f
        2 --> pos x = -1.451f
        3 --> pos x = -0.4747f
        4 --> pos x = 0.5105f
        5 --> pos x = 1.483f
        6 --> pos x = 2.44f      

        DoorVertical --> y
        1 --> pos y = 4.408f;
        2 --> pos y = 3.495f;
        3 --> pos y = 2.565f;
        4 --> pos y = 1.635f;
        5 --> pos y = 0.7f;
        6 --> pos y = -0.232f;
        7 --> pos y = -1.165f;
        8 --> pos y = -2.117f;
        9 --> pos y = -3.057f;
        10 --> pos y = -4.005f;
        11 --> pos y = -4.918;

        DoorHorizontal --> x       
        1 --> pos y = -2.425f;
        2 --> pos y = -1.47f;
        3 --> pos y = -0.492f;
        4 --> pos y = 0.494f;
        5 --> pos y = 1.462f;
        6 --> pos y = 2.4125f;

    */

    List<int> OldGreenBall_xy = new List<int>();
    float PosVerticalGreenBall_y,PosHorizontalGreenBall_x;

    List<int> OldYellowBall_xy = new List<int>();
    float PosVerticalYellowBall_y, PosHorizontalYellowBall_x;

    List<int> OldBlueBall_xy = new List<int>();
    float PosVerticalBlueBall_y, PosHorizontalBlueBall_x;

    List<int> OldGreenDoor_xy = new List<int>();
    float PosVerticalGreenDoor_y, PosHorizontalGreenDoor_x;

    List<int> OldYellowDoor_xy = new List<int>();
    float PosVerticalYellowDoor_y, PosHorizontalYellowDoor_x;

    List<int> OldBlueDoor_xy = new List<int>();
    float PosVerticalBlueDoor_y, PosHorizontalBlueDoor_x;

    List<int> OldVerBarrier_xy = new List<int>();
    float PosVerticalBarrier_x, PosVerticalBarrier_y;

    List<int> OldHorBarrier_xy = new List<int>();
    float PosHorizontalBarrier_x, PosHorizontalBarrier_y;

    void gecik()
    {
        for (int i = 0; i < Dikey_Sayisi; i++)
        {
            VerticalBarrierSettings();
        }
        for (int x = 0; x < Yatay_Sayisi; x++)
        {
            HorizontalBarrierSettings();
        }
    }

    /*
    void Update() {
        
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Dikey_Sayisi = Random.Range(9, 23);
            Yatay_Sayisi = Random.Range(9, 23);

            //   GreenBallSettings();
              //  BlueBallSettings();
            //    YellowBallSettings();

           //     GreenDoorSettings();
           //     YellowDoorSettings();
           //     BlueDoorSettings(); 

            DestroyAllBarrier = true;
            Invoke("DestroyAllBarrierFalse", 1.0f);

            Invoke("gecik", 1.1f);           
        }
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomAllBalls();
        }

        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            for (int i = 0; i < Dikey_Sayisi / 2; i++)
            {
                VerticalBarrierSettings();
            }
            for (int x = 0; x < Yatay_Sayisi / 2; x++)
            {
                HorizontalBarrierSettings();
            }

        }

        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            DestroyAllBarrier = true;
            Invoke("DestroyAllBarrierFalse", 0.5f);
        }

            if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Destroy(GameObject.FindWithTag("Karakter1"));
            Destroy(GameObject.FindWithTag("Karakter2"));
            Destroy(GameObject.FindWithTag("Karakter3"));

            Destroy(GameObject.FindWithTag("YesilKapi"));
            Destroy(GameObject.FindWithTag("SariKapi"));
            Destroy(GameObject.FindWithTag("MaviKapi"));

            OldGreenBall_xy.Clear();
            OldYellowBall_xy.Clear();
            OldBlueBall_xy.Clear();

            OldGreenDoor_xy.Clear();
            OldYellowDoor_xy.Clear();
            OldBlueDoor_xy.Clear();

            DestroyAllBarrier = true;
            Invoke("DestroyAllBarrierFalse", 0.5f);
        }

        if (DestroyAllBarrier)
        {
            Destroy(GameObject.FindWithTag("BariyerVar"));
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            GreenBallSettings();
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            YellowBallSettings();
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            BlueBallSettings();
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            GreenDoorSettings();
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            YellowDoorSettings();
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            BlueDoorSettings();
        }


        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            VerticalBarrierSettings();
        }
        if (Input.GetKey(KeyCode.KeypadDivide))
        {
            VerticalBarrierSettings();
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            HorizontalBarrierSettings();
        }
        if (Input.GetKey(KeyCode.KeypadMultiply))
        {
            HorizontalBarrierSettings();
        }
    }
    */

    void GreenBallSettings() {
        int RandomVertical = Random.Range(1, 12);
        int RandomHorizontal = Random.Range(1, 7);
        string RndmVer = RandomVertical.ToString();
        string RndmHor = RandomHorizontal.ToString();
        int RndmVerHor_xy = int.Parse(RndmVer + RndmHor);
        if (!OldGreenBall_xy.Contains(RndmVerHor_xy))
        {
            string x = RandomVertical.ToString();
            string y = RandomHorizontal.ToString();
            int xy = int.Parse(x + y);
            OldGreenBall_xy.Add(xy);

            switch (RandomVertical)
            {
                case 1: PosVerticalGreenBall_y = -4.896f; break;
                case 2: PosVerticalGreenBall_y = -3.981f; break;
                case 3: PosVerticalGreenBall_y = -3.038f; break;
                case 4: PosVerticalGreenBall_y = -2.091f; break;
                case 5: PosVerticalGreenBall_y = -1.144f; break;
                case 6: PosVerticalGreenBall_y = -0.207f; break;
                case 7: PosVerticalGreenBall_y = 0.733f; break;
                case 8: PosVerticalGreenBall_y = 1.656f; break;
                case 9: PosVerticalGreenBall_y = 2.583f; break;
                case 10: PosVerticalGreenBall_y = 3.524f; break;
                case 11: PosVerticalGreenBall_y = 4.441f; break;
            }
            switch (RandomHorizontal)
            {
                case 1: PosHorizontalGreenBall_x = -2.413f; break;
                case 2: PosHorizontalGreenBall_x = -1.45f; break;
                case 3: PosHorizontalGreenBall_x = -0.47f; break;
                case 4: PosHorizontalGreenBall_x = 0.515f; break;
                case 5: PosHorizontalGreenBall_x = 1.48f; break;
                case 6: PosHorizontalGreenBall_x = 2.438f; break;
            }


            GameObject OlusanObje = Instantiate(GreenBall, new Vector3(PosHorizontalGreenBall_x, PosVerticalGreenBall_y, -1.77454f), Quaternion.identity);

            OlusanObje.transform.localScale = new Vector3(0.4409587f, 0.4257545f, 0.4366712f);

            OlusanObje.name = "Karakter1";

            OlusanObje.transform.parent = GameObject.Find("Bolum").transform;
        }
    }
    void YellowBallSettings()
    {
        int RandomVertical = Random.Range(1, 12);
        int RandomHorizontal = Random.Range(1, 7);
        string RndmVer = RandomVertical.ToString();
        string RndmHor = RandomHorizontal.ToString();
        int RndmVerHor_xy = int.Parse(RndmVer + RndmHor);
        if (!OldYellowBall_xy.Contains(RndmVerHor_xy))
        {
            string x = RandomVertical.ToString();
            string y = RandomHorizontal.ToString();
            int xy = int.Parse(x + y);
            OldYellowBall_xy.Add(xy);

            switch (RandomVertical)
            {
                case 1: PosVerticalYellowBall_y = -4.896f; break;
                case 2: PosVerticalYellowBall_y = -3.981f; break;
                case 3: PosVerticalYellowBall_y = -3.038f; break;
                case 4: PosVerticalYellowBall_y = -2.091f; break;
                case 5: PosVerticalYellowBall_y = -1.144f; break;
                case 6: PosVerticalYellowBall_y = -0.207f; break;
                case 7: PosVerticalYellowBall_y = 0.733f; break;
                case 8: PosVerticalYellowBall_y = 1.656f; break;
                case 9: PosVerticalYellowBall_y = 2.583f; break;
                case 10: PosVerticalYellowBall_y = 3.524f; break;
                case 11: PosVerticalYellowBall_y = 4.441f; break;
            }
            switch (RandomHorizontal)
            {
                case 1: PosHorizontalYellowBall_x = -2.413f; break;
                case 2: PosHorizontalYellowBall_x = -1.45f; break;
                case 3: PosHorizontalYellowBall_x = -0.47f; break;
                case 4: PosHorizontalYellowBall_x = 0.515f; break;
                case 5: PosHorizontalYellowBall_x = 1.48f; break;
                case 6: PosHorizontalYellowBall_x = 2.438f; break;
            }


            GameObject OlusanObje = Instantiate(YellowBall, new Vector3(PosHorizontalYellowBall_x, PosVerticalYellowBall_y, -1.77454f), Quaternion.identity);

            OlusanObje.transform.localScale = new Vector3(0.4409587f, 0.4257545f, 0.4366712f);

            OlusanObje.name = "Karakter2";

            OlusanObje.transform.parent = GameObject.Find("Bolum").transform;
        }
    }
    void BlueBallSettings()
    {
        int RandomVertical = Random.Range(1, 12);
        int RandomHorizontal = Random.Range(1, 7);
        string RndmVer = RandomVertical.ToString();
        string RndmHor = RandomHorizontal.ToString();
        int RndmVerHor_xy = int.Parse(RndmVer + RndmHor);
        if (!OldBlueBall_xy.Contains(RndmVerHor_xy))
        {
            string x = RandomVertical.ToString();
            string y = RandomHorizontal.ToString();
            int xy = int.Parse(x + y);
            OldBlueBall_xy.Add(xy);

            switch (RandomVertical)
            {
                case 1: PosVerticalBlueBall_y = -4.896f; break;
                case 2: PosVerticalBlueBall_y = -3.981f; break;
                case 3: PosVerticalBlueBall_y = -3.038f; break;
                case 4: PosVerticalBlueBall_y = -2.091f; break;
                case 5: PosVerticalBlueBall_y = -1.144f; break;
                case 6: PosVerticalBlueBall_y = -0.207f; break;
                case 7: PosVerticalBlueBall_y = 0.733f; break;
                case 8: PosVerticalBlueBall_y = 1.656f; break;
                case 9: PosVerticalBlueBall_y = 2.583f; break;
                case 10: PosVerticalBlueBall_y = 3.524f; break;
                case 11: PosVerticalBlueBall_y = 4.441f; break;
            }
            switch (RandomHorizontal)
            {
                case 1: PosHorizontalBlueBall_x = -2.413f; break;
                case 2: PosHorizontalBlueBall_x = -1.45f; break;
                case 3: PosHorizontalBlueBall_x = -0.47f; break;
                case 4: PosHorizontalBlueBall_x = 0.515f; break;
                case 5: PosHorizontalBlueBall_x = 1.48f; break;
                case 6: PosHorizontalBlueBall_x = 2.438f; break;
            }


            GameObject OlusanObje = Instantiate(BlueBall, new Vector3(PosHorizontalBlueBall_x, PosVerticalBlueBall_y, -1.77454f), Quaternion.identity);

            OlusanObje.transform.localScale = new Vector3(0.4409587f, 0.4257545f, 0.4366712f);

            OlusanObje.name = "Karakter3";

            OlusanObje.transform.parent = GameObject.Find("Bolum").transform;
        }
    }

    void GreenDoorSettings()
    {
        int RandomVertical = Random.Range(1, 12);
        int RandomHorizontal = Random.Range(1, 7);
        string RndmVer = RandomVertical.ToString();
        string RndmHor = RandomHorizontal.ToString();
        int RndmVerHor_xy = int.Parse(RndmVer + RndmHor);
        if (!OldGreenDoor_xy.Contains(RndmVerHor_xy))
        {
            string x = RandomVertical.ToString();
            string y = RandomHorizontal.ToString();
            int xy = int.Parse(x + y);
            OldGreenDoor_xy.Add(xy);

            switch (RandomVertical)
            {
                case 1: PosVerticalGreenDoor_y = -4.896f; break;
                case 2: PosVerticalGreenDoor_y = -3.981f; break;
                case 3: PosVerticalGreenDoor_y = -3.038f; break;
                case 4: PosVerticalGreenDoor_y = -2.091f; break;
                case 5: PosVerticalGreenDoor_y = -1.144f; break;
                case 6: PosVerticalGreenDoor_y = -0.207f; break;
                case 7: PosVerticalGreenDoor_y = 0.733f; break;
                case 8: PosVerticalGreenDoor_y = 1.656f; break;
                case 9: PosVerticalGreenDoor_y = 2.583f; break;
                case 10: PosVerticalGreenDoor_y = 3.524f; break;
                case 11: PosVerticalGreenDoor_y = 4.441f; break;
            }
            switch (RandomHorizontal)
            {
                case 1: PosHorizontalGreenDoor_x = -2.413f; break;
                case 2: PosHorizontalGreenDoor_x = -1.45f; break;
                case 3: PosHorizontalGreenDoor_x = -0.47f; break;
                case 4: PosHorizontalGreenDoor_x = 0.515f; break;
                case 5: PosHorizontalGreenDoor_x = 1.48f; break;
                case 6: PosHorizontalGreenDoor_x = 2.438f; break;
            }


            GameObject OlusanObje = Instantiate(GreenDoor, new Vector3(PosHorizontalGreenDoor_x, PosVerticalGreenDoor_y, -1.918817f), Quaternion.identity);
            OlusanObje.transform.localRotation = Quaternion.Euler(0, 90, 0);
            OlusanObje.transform.localScale = new Vector3(0.03149073f, 0.03070345f, 0.03149707f);
            OlusanObje.name = "GreenDoor";
            OlusanObje.transform.parent = GameObject.Find("Bolum").transform;
        }
    }
    void YellowDoorSettings()
    {
        int RandomVertical = Random.Range(1, 12);
        int RandomHorizontal = Random.Range(1, 7);
        string RndmVer = RandomVertical.ToString();
        string RndmHor = RandomHorizontal.ToString();
        int RndmVerHor_xy = int.Parse(RndmVer + RndmHor);
        if (!OldYellowDoor_xy.Contains(RndmVerHor_xy))
        {
            string x = RandomVertical.ToString();
            string y = RandomHorizontal.ToString();
            int xy = int.Parse(x + y);
            OldYellowDoor_xy.Add(xy);

            switch (RandomVertical)
            {
                case 1: PosVerticalYellowDoor_y = -4.896f; break;
                case 2: PosVerticalYellowDoor_y = -3.981f; break;
                case 3: PosVerticalYellowDoor_y = -3.038f; break;
                case 4: PosVerticalYellowDoor_y = -2.091f; break;
                case 5: PosVerticalYellowDoor_y = -1.144f; break;
                case 6: PosVerticalYellowDoor_y = -0.207f; break;
                case 7: PosVerticalYellowDoor_y = 0.733f; break;
                case 8: PosVerticalYellowDoor_y = 1.656f; break;
                case 9: PosVerticalYellowDoor_y = 2.583f; break;
                case 10: PosVerticalYellowDoor_y = 3.524f; break;
                case 11: PosVerticalYellowDoor_y = 4.441f; break;
            }
            switch (RandomHorizontal)
            {
                case 1: PosHorizontalYellowDoor_x = -2.413f; break;
                case 2: PosHorizontalYellowDoor_x = -1.45f; break;
                case 3: PosHorizontalYellowDoor_x = -0.47f; break;
                case 4: PosHorizontalYellowDoor_x = 0.515f; break;
                case 5: PosHorizontalYellowDoor_x = 1.48f; break;
                case 6: PosHorizontalYellowDoor_x = 2.438f; break;
            }


            GameObject OlusanObje = Instantiate(YellowDoor, new Vector3(PosHorizontalYellowDoor_x, PosVerticalYellowDoor_y, -1.918817f), Quaternion.identity);
            OlusanObje.transform.localRotation = Quaternion.Euler(0, 90, 0);
            OlusanObje.transform.localScale = new Vector3(0.03149073f, 0.03070345f, 0.03149707f);
            OlusanObje.name = "YellowDoor";
            OlusanObje.transform.parent = GameObject.Find("Bolum").transform;
        }
    }
    void BlueDoorSettings()
    {
        int RandomVertical = Random.Range(1, 12);
        int RandomHorizontal = Random.Range(1, 7);
        string RndmVer = RandomVertical.ToString();
        string RndmHor = RandomHorizontal.ToString();
        int RndmVerHor_xy = int.Parse(RndmVer + RndmHor);
        if (!OldBlueDoor_xy.Contains(RndmVerHor_xy))
        {
            string x = RandomVertical.ToString();
            string y = RandomHorizontal.ToString();
            int xy = int.Parse(x + y);
            OldBlueDoor_xy.Add(xy);

            switch (RandomVertical)
            {
                case 1: PosVerticalBlueDoor_y = -4.896f; break;
                case 2: PosVerticalBlueDoor_y = -3.981f; break;
                case 3: PosVerticalBlueDoor_y = -3.038f; break;
                case 4: PosVerticalBlueDoor_y = -2.091f; break;
                case 5: PosVerticalBlueDoor_y = -1.144f; break;
                case 6: PosVerticalBlueDoor_y = -0.207f; break;
                case 7: PosVerticalBlueDoor_y = 0.733f; break;
                case 8: PosVerticalBlueDoor_y = 1.656f; break;
                case 9: PosVerticalBlueDoor_y = 2.583f; break;
                case 10: PosVerticalBlueDoor_y = 3.524f; break;
                case 11: PosVerticalBlueDoor_y = 4.441f; break;
            }
            switch (RandomHorizontal)
            {
                case 1: PosHorizontalBlueDoor_x = -2.413f; break;
                case 2: PosHorizontalBlueDoor_x = -1.45f; break;
                case 3: PosHorizontalBlueDoor_x = -0.47f; break;
                case 4: PosHorizontalBlueDoor_x = 0.515f; break;
                case 5: PosHorizontalBlueDoor_x = 1.48f; break;
                case 6: PosHorizontalBlueDoor_x = 2.438f; break;
            }


            GameObject OlusanObje = Instantiate(BlueDoor, new Vector3(PosHorizontalBlueDoor_x, PosVerticalBlueDoor_y, -1.918817f), Quaternion.identity);
            OlusanObje.transform.localRotation = Quaternion.Euler(0, 90, 0);
            OlusanObje.transform.localScale = new Vector3(0.03149073f, 0.03070345f, 0.03149707f);
            OlusanObje.name = "BlueDoor";
            OlusanObje.transform.parent = GameObject.Find("Bolum").transform;
        }
    }

    void VerticalBarrierSettings()
    {
        int RandomVertical = Random.Range(1, 6);
        int RandomHorizontal = Random.Range(1, 12);
        string RndmVer = RandomVertical.ToString();
        string RndmHor = RandomHorizontal.ToString();
        int RndmVerHor_xy = int.Parse(RndmVer + RndmHor);

        if (!OldVerBarrier_xy.Contains(RndmVerHor_xy))
        {
            string x = RandomVertical.ToString();
            string y = RandomHorizontal.ToString();
            int xy = int.Parse(x + y);
            OldVerBarrier_xy.Add(xy);

            switch (RandomVertical)
            {
                case 1:
                    PosVerticalBarrier_x = -1.935f;
                    break;
                case 2:
                    PosVerticalBarrier_x = -0.968f;
                    break;
                case 3:
                    PosVerticalBarrier_x = 0.025f;
                    break;
                case 4:
                    PosVerticalBarrier_x = 0.997f;
                    break;
                case 5:
                    PosVerticalBarrier_x = 1.969f;
                    break;
            }
            switch (RandomHorizontal)
            {
                case 1:
                    PosVerticalBarrier_y = 4.45f;
                    break;
                case 2:
                    PosVerticalBarrier_y = 3.529f;
                    break;
                case 3:
                    PosVerticalBarrier_y = 2.591f;
                    break;
                case 4:
                    PosVerticalBarrier_y = 1.66f;
                    break;
                case 5:
                    PosVerticalBarrier_y = 0.725f;
                    break;
                case 6:
                    PosVerticalBarrier_y = -0.207f;
                    break;
                case 7:
                    PosVerticalBarrier_y = -1.145f;
                    break;
                case 8:
                    PosVerticalBarrier_y = -2.091f;
                    break;
                case 9:
                    PosVerticalBarrier_y = -3.04f;
                    break;
                case 10:
                    PosVerticalBarrier_y = -3.981f;
                    break;
                case 11:
                    PosVerticalBarrier_y = -4.9f;
                    break;
            }

            GameObject OlusanObje = Instantiate(VerticalBarrier, new Vector3(PosVerticalBarrier_x, PosVerticalBarrier_y, -2.167401f), Quaternion.identity);
            OlusanObje.transform.localScale = new Vector3(0.1115561f, 0.4422437f, 0.2247789f);

            OlusanObje.name = "Engel_Dikey";

            OlusanObje.transform.parent = GameObject.Find("Bolum_Barriers").transform;

        }
    }
    void HorizontalBarrierSettings()
    {
        int RandomVertical = Random.Range(1, 7);
        int RandomHorizontal = Random.Range(1, 11);
        string RndmVer = RandomVertical.ToString();
        string RndmHor = RandomHorizontal.ToString();
        int RndmVerHor_xy = int.Parse(RndmVer + RndmHor);

        if (!OldHorBarrier_xy.Contains(RndmVerHor_xy))
        {
            string x = RandomVertical.ToString();
            string y = RandomHorizontal.ToString();
            int xy = int.Parse(x + y);
            OldHorBarrier_xy.Add(xy);

            switch (RandomVertical)
            {
                case 1:
                    PosHorizontalBarrier_x = -2.411f;
                    break;
                case 2:
                    PosHorizontalBarrier_x = -1.451f;
                    break;
                case 3:
                    PosHorizontalBarrier_x = -0.4747f;
                    break;
                case 4:
                    PosHorizontalBarrier_x = 0.5105f;
                    break;
                case 5:
                    PosHorizontalBarrier_x = 1.483f;
                    break;
                case 6:
                    PosHorizontalBarrier_x = 2.44f;
                    break;
            }
            switch (RandomHorizontal)
            {
                case 1:
                    PosHorizontalBarrier_y = 3.99f;
                    break;
                case 2:
                    PosHorizontalBarrier_y = 3.06f;
                    break;
                case 3:
                    PosHorizontalBarrier_y = 2.115f;
                    break;
                case 4:
                    PosHorizontalBarrier_y = 1.2015f;
                    break;
                case 5:
                    PosHorizontalBarrier_y = 0.2556f;
                    break;
                case 6:
                    PosHorizontalBarrier_y = -0.6737f;
                    break;
                case 7:
                    PosHorizontalBarrier_y = -1.6184f;
                    break;
                case 8:
                    PosHorizontalBarrier_y = -2.5638f;
                    break;
                case 9:
                    PosHorizontalBarrier_y = -3.5103f;
                    break;
                case 10:
                    PosHorizontalBarrier_y = -4.4544f;
                    break;
            }

            GameObject OlusanObje = Instantiate(HorizontalBarrier, new Vector3(PosHorizontalBarrier_x, PosHorizontalBarrier_y, -2.167401f), Quaternion.identity);
            OlusanObje.transform.localRotation = Quaternion.Euler(0, 0, 270);
            OlusanObje.transform.localScale = new Vector3(0.1115561f, 0.4422437f, 0.2247789f);

            OlusanObje.name = "Engel_Yatay";

            OlusanObje.transform.parent = GameObject.Find("Bolum_Barriers").transform;

        }
    }


    void RandomAllBalls()
    {
        int ball_1_vertical = Random.Range(1, 12);
        int ball_1_horizontal = Random.Range(1, 7);

        int ball_2_vertical = Random.Range(1, 12);
        int ball_2_horizontal = Random.Range(1, 7);

        int ball_3_vertical = Random.Range(1, 12);
        int ball_3_horizontal = Random.Range(1, 7);


        int door_1_vertical = Random.Range(1, 12);
        int door_1_horizontal = Random.Range(1, 7);

        int door_2_vertical = Random.Range(1, 12);
        int door_2_horizontal = Random.Range(1, 7);

        int door_3_vertical = Random.Range(1, 12);
        int door_3_horizontal = Random.Range(1, 7);

        switch (ball_1_vertical) {

                case 1: ball_1.position = new Vector3(ball_1.position.x, -4.896f, ball_1.position.z); break;
                case 2: ball_1.position = new Vector3(ball_1.position.x, -3.981f, ball_1.position.z); break;
                case 3: ball_1.position = new Vector3(ball_1.position.x, -3.038f, ball_1.position.z); break;
                case 4: ball_1.position = new Vector3(ball_1.position.x, -2.091f, ball_1.position.z); break;
                case 5: ball_1.position = new Vector3(ball_1.position.x, -1.144f, ball_1.position.z); break;
                case 6: ball_1.position = new Vector3(ball_1.position.x, -0.207f, ball_1.position.z); break;
                case 7: ball_1.position = new Vector3(ball_1.position.x, 0.733f, ball_1.position.z); break;
                case 8: ball_1.position = new Vector3(ball_1.position.x, 1.656f, ball_1.position.z); break;
                case 9: ball_1.position = new Vector3(ball_1.position.x, 2.583f, ball_1.position.z); break;
                case 10: ball_1.position = new Vector3(ball_1.position.x, 3.524f, ball_1.position.z); break;
                case 11: ball_1.position = new Vector3(ball_1.position.x, 4.441f, ball_1.position.z); break;
                }

             switch (ball_1_horizontal)
            {
                case 1: ball_1.position = new Vector3(-2.413f, ball_1.position.y, ball_1.position.z); break;
                case 2: ball_1.position = new Vector3(-1.45f, ball_1.position.y, ball_1.position.z); break;
                case 3: ball_1.position = new Vector3(-0.47f, ball_1.position.y, ball_1.position.z); break;
                case 4: ball_1.position = new Vector3(0.515f, ball_1.position.y, ball_1.position.z); break;
                case 5: ball_1.position = new Vector3(1.48f, ball_1.position.y, ball_1.position.z); break;
                case 6: ball_1.position = new Vector3(2.438f, ball_1.position.y, ball_1.position.z); break;
            }

        switch (ball_2_vertical)
        {
            case 1: ball_2.position = new Vector3(ball_2.position.x, -4.896f, ball_2.position.z); break;
            case 2: ball_2.position = new Vector3(ball_2.position.x, -3.981f, ball_2.position.z); break;
            case 3: ball_2.position = new Vector3(ball_2.position.x, -3.038f, ball_2.position.z); break;
            case 4: ball_2.position = new Vector3(ball_2.position.x, -2.091f, ball_2.position.z); break;
            case 5: ball_2.position = new Vector3(ball_2.position.x, -1.144f, ball_2.position.z); break;
            case 6: ball_2.position = new Vector3(ball_2.position.x, -0.207f, ball_2.position.z); break;
            case 7: ball_2.position = new Vector3(ball_2.position.x, 0.733f, ball_2.position.z); break;
            case 8: ball_2.position = new Vector3(ball_2.position.x, 1.656f, ball_2.position.z); break;
            case 9: ball_2.position = new Vector3(ball_2.position.x, 2.583f, ball_2.position.z); break;
            case 10: ball_2.position = new Vector3(ball_2.position.x, 3.524f, ball_2.position.z); break;
            case 11: ball_2.position = new Vector3(ball_2.position.x, 4.441f, ball_2.position.z); break;
        }

        switch (ball_2_horizontal)
        {
            case 1: ball_2.position = new Vector3(-2.413f, ball_2.position.y, ball_2.position.z); break;
            case 2: ball_2.position = new Vector3(-1.45f, ball_2.position.y, ball_2.position.z); break;
            case 3: ball_2.position = new Vector3(-0.47f, ball_2.position.y, ball_2.position.z); break;
            case 4: ball_2.position = new Vector3(0.515f, ball_2.position.y, ball_2.position.z); break;
            case 5: ball_2.position = new Vector3(1.48f, ball_2.position.y, ball_2.position.z); break;
            case 6: ball_2.position = new Vector3(2.438f, ball_2.position.y, ball_2.position.z); break;
        }

        switch (ball_3_vertical)
        {
            case 1: ball_3.position = new Vector3(ball_3.position.x, -4.896f, ball_3.position.z); break;
            case 2: ball_3.position = new Vector3(ball_3.position.x, -3.981f, ball_3.position.z); break;
            case 3: ball_3.position = new Vector3(ball_3.position.x, -3.038f, ball_3.position.z); break;
            case 4: ball_3.position = new Vector3(ball_3.position.x, -2.091f, ball_3.position.z); break;
            case 5: ball_3.position = new Vector3(ball_3.position.x, -1.144f, ball_3.position.z); break;
            case 6: ball_3.position = new Vector3(ball_3.position.x, -0.207f, ball_3.position.z); break;
            case 7: ball_3.position = new Vector3(ball_3.position.x, 0.733f, ball_3.position.z); break;
            case 8: ball_3.position = new Vector3(ball_3.position.x, 1.656f, ball_3.position.z); break;
            case 9: ball_3.position = new Vector3(ball_3.position.x, 2.583f, ball_3.position.z); break;
            case 10: ball_3.position = new Vector3(ball_3.position.x, 3.524f, ball_3.position.z); break;
            case 11: ball_3.position = new Vector3(ball_3.position.x, 4.441f, ball_3.position.z); break;
        }

        switch (ball_3_horizontal)
        {
            case 1: ball_3.position = new Vector3(-2.413f, ball_3.position.y, ball_3.position.z); break;
            case 2: ball_3.position = new Vector3(-1.45f, ball_3.position.y, ball_3.position.z); break;
            case 3: ball_3.position = new Vector3(-0.47f, ball_3.position.y, ball_3.position.z); break;
            case 4: ball_3.position = new Vector3(0.515f, ball_3.position.y, ball_3.position.z); break;
            case 5: ball_3.position = new Vector3(1.48f, ball_3.position.y, ball_3.position.z); break;
            case 6: ball_3.position = new Vector3(2.438f, ball_3.position.y, ball_3.position.z); break;
        }

        switch (door_1_vertical)
        {
            case 1: door_1.position = new Vector3(door_1.position.x, -4.896f, door_1.position.z); break;
            case 2: door_1.position = new Vector3(door_1.position.x, -3.981f, door_1.position.z); break;
            case 3: door_1.position = new Vector3(door_1.position.x, -3.038f, door_1.position.z); break;
            case 4: door_1.position = new Vector3(door_1.position.x, -2.091f, door_1.position.z); break;
            case 5: door_1.position = new Vector3(door_1.position.x, -1.144f, door_1.position.z); break;
            case 6: door_1.position = new Vector3(door_1.position.x, -0.207f, door_1.position.z); break;
            case 7: door_1.position = new Vector3(door_1.position.x, 0.733f, door_1.position.z); break;
            case 8: door_1.position = new Vector3(door_1.position.x, 1.656f, door_1.position.z); break;
            case 9: door_1.position = new Vector3(door_1.position.x, 2.583f, door_1.position.z); break;
            case 10: door_1.position = new Vector3(door_1.position.x, 3.524f, door_1.position.z); break;
            case 11: door_1.position = new Vector3(door_1.position.x, 4.441f, door_1.position.z); break;
        }
        switch (door_1_horizontal)
        {
            case 1: door_1.position = new Vector3(-2.413f, door_1.position.y, door_1.position.z); break;
            case 2: door_1.position = new Vector3(-1.45f, door_1.position.y, door_1.position.z); break;
            case 3: door_1.position = new Vector3(-0.47f, door_1.position.y, door_1.position.z); break;
            case 4: door_1.position = new Vector3(0.515f, door_1.position.y, door_1.position.z); break;
            case 5: door_1.position = new Vector3(1.48f, door_1.position.y, door_1.position.z); break;
            case 6: door_1.position = new Vector3(2.438f, door_1.position.y, door_1.position.z); break;
        }
        switch (door_2_vertical)
        {
            case 1: door_2.position = new Vector3(door_2.position.x, -4.896f, door_2.position.z); break;
            case 2: door_2.position = new Vector3(door_2.position.x, -3.981f, door_2.position.z); break;
            case 3: door_2.position = new Vector3(door_2.position.x, -3.038f, door_2.position.z); break;
            case 4: door_2.position = new Vector3(door_2.position.x, -2.091f, door_2.position.z); break;
            case 5: door_2.position = new Vector3(door_2.position.x, -1.144f, door_2.position.z); break;
            case 6: door_2.position = new Vector3(door_2.position.x, -0.207f, door_2.position.z); break;
            case 7: door_2.position = new Vector3(door_2.position.x, 0.733f, door_2.position.z); break;
            case 8: door_2.position = new Vector3(door_2.position.x, 1.656f, door_2.position.z); break;
            case 9: door_2.position = new Vector3(door_2.position.x, 2.583f, door_2.position.z); break;
            case 10: door_2.position = new Vector3(door_2.position.x, 3.524f, door_2.position.z); break;
            case 11: door_2.position = new Vector3(door_2.position.x, 4.441f, door_2.position.z); break;
        }
        switch (door_2_horizontal)
        {
            case 1: door_2.position = new Vector3(-2.413f, door_2.position.y, door_2.position.z); break;
            case 2: door_2.position = new Vector3(-1.45f, door_2.position.y, door_2.position.z); break;
            case 3: door_2.position = new Vector3(-0.47f, door_2.position.y, door_2.position.z); break;
            case 4: door_2.position = new Vector3(0.515f, door_2.position.y, door_2.position.z); break;
            case 5: door_2.position = new Vector3(1.48f, door_2.position.y, door_2.position.z); break;
            case 6: door_2.position = new Vector3(2.438f, door_2.position.y, door_2.position.z); break;
        }

        switch (door_3_vertical)
        {
            case 1: door_3.position = new Vector3(door_3.position.x, -4.896f, door_3.position.z); break;
            case 2: door_3.position = new Vector3(door_3.position.x, -3.981f, door_3.position.z); break;
            case 3: door_3.position = new Vector3(door_3.position.x, -3.038f, door_3.position.z); break;
            case 4: door_3.position = new Vector3(door_3.position.x, -2.091f, door_3.position.z); break;
            case 5: door_3.position = new Vector3(door_3.position.x, -1.144f, door_3.position.z); break;
            case 6: door_3.position = new Vector3(door_3.position.x, -0.207f, door_3.position.z); break;
            case 7: door_3.position = new Vector3(door_3.position.x, 0.733f, door_3.position.z); break;
            case 8: door_3.position = new Vector3(door_3.position.x, 1.656f, door_3.position.z); break;
            case 9: door_3.position = new Vector3(door_3.position.x, 2.583f, door_3.position.z); break;
            case 10: door_3.position = new Vector3(door_3.position.x, 3.524f, door_3.position.z); break;
            case 11: door_3.position = new Vector3(door_3.position.x, 4.441f, door_3.position.z); break;
        }
        switch (door_3_horizontal)
        {
            case 1: door_3.position = new Vector3(-2.413f, door_3.position.y, door_3.position.z); break;
            case 2: door_3.position = new Vector3(-1.45f, door_3.position.y, door_3.position.z); break;
            case 3: door_3.position = new Vector3(-0.47f, door_3.position.y, door_3.position.z); break;
            case 4: door_3.position = new Vector3(0.515f, door_3.position.y, door_3.position.z); break;
            case 5: door_3.position = new Vector3(1.48f, door_3.position.y, door_3.position.z); break;
            case 6: door_3.position = new Vector3(2.438f, door_3.position.y, door_3.position.z); break;
        }
    }


    void DestroyAllBarrierFalse()
    {
        OldVerBarrier_xy.Clear();
        OldHorBarrier_xy.Clear();

        DestroyAllBarrier = false;
    }
}
