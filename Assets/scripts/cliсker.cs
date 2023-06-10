using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class cliсker : MonoBehaviour
{
    public Sprite[] images;
    public AudioClip[] AudioClips;
    public int count;
    public TMP_Text text;
    public string nameBuy;
    public GameObject butStore, panelbox;
    public Camera myCamera;
    public GameObject button;
    
    public void Click()
    {
        count++;
        text.text = count.ToString();
    }
    public void buyStore()
    {
        if (nameBuy == "Ckip" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[28];
            count -= 1;
        }
        if (nameBuy == "Nek" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[27];
            count -= 1;
        }
        if (nameBuy == "Vens" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[26];
            count -= 1;
        }
        if (nameBuy == "Taga" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[25];
            count -= 1;
        }
        if (nameBuy == "Tyalet" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[24];
            count -= 1;
        }
        if (nameBuy == "Skala" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[23];
            count -= 1;
        }
        if (nameBuy == "Clepa" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[22];
            count -= 1;
        }
        if (nameBuy == "Bobik" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[21];
            count -= 1;
        }
        if (nameBuy == "Ben" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[20];
            count -= 1;
        }
        if (nameBuy == "Zolo" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[19];
            count -= 1;
        }
        if (nameBuy == "Fred" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[18];
            count -= 1;
        }
        if (nameBuy == "Dyb" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[17];
            count -= 1;
        }
        if (nameBuy == "Dob" && count >= 1)
        {
            button.GetComponent<Image>().sprite = images[16];
            count -= 1;
        }
        if (nameBuy == "Tyryn" && count >= 15)
        {
            button.GetComponent<Image>().sprite = images[15];
            count -= 15;
        }
        if (nameBuy == "Kalmar" && count >= 15)
        {
            button.GetComponent<Image>().sprite = images[14];
            count -= 15;
        }
        if (nameBuy == "Anonimys" && count >= 15)
        {
            button.GetComponent<Image>().sprite = images[13];
            count -= 15;
        }
        if (nameBuy == "God" && count >= 10)
        {
            button.GetComponent<Image>().sprite = images[12];
            count -= 10;
        }
        if (nameBuy == "Sosiska" && count >= 10)
        {
            button.GetComponent<Image>().sprite = images[11];
            count -= 10;
        }
        if (nameBuy == "Chips" && count >= 8)
        {
            button.GetComponent<Image>().sprite = images[10];
            count -= 7;
        }
        if (nameBuy == "Djigan" && count >= 7)
        {
            button.GetComponent<Image>().sprite = images[9];
            count -= 7;
        }
        if (nameBuy == "Koreka" && count >= 7)
        {
            button.GetComponent<Image>().sprite = images[8];
            count -= 7;
        }
        if (nameBuy == "Obama" && count >= 7)
        {
            button.GetComponent<Image>().sprite = images[7];
            count -= 7;
        }
        if (nameBuy == "Korova" && count >= 5)
        {
            button.GetComponent<Image>().sprite = images[6];
            count -= 5;
        }
        if (nameBuy == "Betment" && count >= 5)
        {
            button.GetComponent<Image>().sprite = images[5];
            GetComponent<AudioSource>().PlayOneShot(AudioClips[0]);
            count -= 5;
        }
        if (nameBuy == "Gorin" && count >= 5)
        {
            button.GetComponent<Image>().sprite = images[4];
            count -= 5;
        }
        if (nameBuy == "Zadnica" && count >= 5)
        {
            button.GetComponent<Image>().sprite = images[3];
            GetComponent<AudioSource>().PlayOneShot(AudioClips[1]);
            count -= 5;
        }
        if (nameBuy == "Stepanov" && count >= 3)
        {
            button.GetComponent<Image>().sprite = images[2];
            count -= 3;
        }
        if (nameBuy == "Ejik" && count >= 3)
        {
            button.GetComponent<Image>().sprite = images[1];
            count -= 3;
        }
        if (nameBuy == "Klava" && count >= 3)
        {
            button.GetComponent<Image>().sprite = images[0];
            count -= 3;
        }
        
        if (nameBuy == "pink" && count >= 100)
        {
            myCamera.GetComponent<Camera>().backgroundColor = Color.magenta;
            count -= 100;
        }
        if (nameBuy == "white" && count >= 100)
        {
            myCamera.GetComponent<Camera>().backgroundColor = Color.white;
            count -= 100;
        }
        if (nameBuy == "red" && count >= 10)
        {
            myCamera.GetComponent<Camera>().backgroundColor = Color.red;
            count -= 10;
        }
        if (nameBuy == "yellow" && count >= 10)
        {
            myCamera.GetComponent<Camera>().backgroundColor = Color.yellow;
            count -= 10;
        }
     
        if (nameBuy == "green" && count >= 10)
        {
            myCamera.GetComponent<Camera>().backgroundColor = Color.green;
            count -= 10;
        }
        text.text = count.ToString();
    }

    public void BuyKlava()
    {
        nameBuy = "Klava";
        buyStore();
    } 
    public void BuyEjik()
    {
        nameBuy = "Ejik";
        buyStore();
    } 
    public void BuyStepanov()
    {
        nameBuy = "Stepanov";
        buyStore();
    }
    public void BuyZadnica()
    {
        nameBuy = "Zadnica";
        buyStore();
    } 
    public void BuyGorin()
    {
        nameBuy = "Gorin";
        buyStore();
    }

    public void BuyBetment()
    {
        nameBuy = "Betment";
        buyStore();
    }
    public void BuyKorova()
    {
        nameBuy = "Korova";
        buyStore();
    }
    public void BuyObama()
    {
        nameBuy = "Obama";
        buyStore();
    } 
    public void BuyKoreka()
    {
        nameBuy = "Koreka";
        buyStore();
    } 
    public void BuyDjigan()
    {
        nameBuy = "Djigan";
        buyStore();
    } 
    public void BuyChips()
    {
        nameBuy = "Chips";
        buyStore();
    } 
    public void BuySosiska()
    {
        nameBuy = "Sosiska";
        buyStore();
    } 
    public void BuyGod()
    {
        nameBuy = "God";
        buyStore();
    } 
    public void BuyAnonimys()
    {
        nameBuy = "Anonimys";
        buyStore();
    } 
    public void BuyKalmar()
    {
        nameBuy = "Kalmar";
        buyStore();
    } 
    public void BuyTyryn()
    {
        nameBuy = "Tyryn";
        buyStore();
    } 
    public void BuyDob()
    {
        nameBuy = "Dob";
        buyStore();
    } 
    public void BuyDyb()
    {
        nameBuy = "Dyb";
        buyStore();
    } 
    public void BuyFred()
    {
        nameBuy = "Fred";
        buyStore();
    } 
    public void BuyZolo()
    {
        nameBuy = "Zolo";
        buyStore();
    } 
    public void BuyBen()
    {
        nameBuy = "Ben";
        buyStore();
    } 
    public void BuyBobik()
    {
        nameBuy = "Bobik";
        buyStore();
    }
    public void BuyClepa()
    {
        nameBuy = "Clepa";
        buyStore();
    } 
    public void BuySkala()
    {
        nameBuy = "Skala";
        buyStore();
    } 
    public void BuyTyalet()
    {
        nameBuy = "Tyalet";
        buyStore();
    } 
    public void BuyTaga()
    {
        nameBuy = "Taga";
        buyStore();
    } 
    public void BuyVens()
    {
        nameBuy = "Vens";
        buyStore();
    } 
    public void BuyNek()
    {
        nameBuy = "Nek";
        buyStore();
    } 
    public void BuyCkip()
    {
        nameBuy = "Ckip";
        buyStore();
    } 

    



    public void buyStoreBGpink()
    {
        nameBuy = "pink";
        buyStore();
    }

    public void buyStoreBGwhite()
    {
        nameBuy = "white";
        buyStore();
    }
    public void buyStoreBGred()
    {
        nameBuy = "red";
        buyStore();
    }
    public void buyStoreBGyellow()
    {
        nameBuy = "yellow";
        buyStore();
    }
    public void buyStoreBGgreen()
    {
        nameBuy = "green";
        buyStore();
    }
}

