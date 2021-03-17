using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeGunsUI : MonoBehaviour
{
    public playerWestInput plyScr;
    [SerializeField] private Image[] gunsImg = null;
    [SerializeField] private Sprite[] gunsGrey = null;
    [SerializeField] private Sprite[] gunsInitial = null;

    public void greyUIWest(int caseSwitch)
    {
        switch (caseSwitch)
        {
            case 0:
                gunsImg[0].GetComponent<Image>().sprite = gunsGrey[0];
                break;
            case 1: 
                gunsImg[1].GetComponent<Image>().sprite = gunsGrey[1];
                break;
            case 2:
                gunsImg[2].GetComponent<Image>().sprite = gunsGrey[2];
                break;
        }
    }

    public void resetUIWest(int caseSwitch) 
    {
        switch (caseSwitch)
        {
            case 0:
                gunsImg[0].GetComponent<Image>().sprite = gunsInitial[0];
                break;
            case 1: 
                gunsImg[1].GetComponent<Image>().sprite = gunsInitial[1];
                break;
            case 2:
                gunsImg[2].GetComponent<Image>().sprite = gunsInitial[2];
                break;
        }
    }

    //East:
    public void greyUIEast(int caseSwitch)
    {
        switch (caseSwitch)
        {
            case 0:
                gunsImg[3].GetComponent<Image>().sprite = gunsGrey[3];
                break;
            case 1: 
                gunsImg[4].GetComponent<Image>().sprite = gunsGrey[4];
                break;
            case 2:
                gunsImg[5].GetComponent<Image>().sprite = gunsGrey[5];
                break;
        }
    }
    public void resetUIEast(int caseSwitch) 
    {
        switch (caseSwitch)
        {
            case 0:
                gunsImg[3].GetComponent<Image>().sprite = gunsInitial[3];
                break;
            case 1: 
                gunsImg[4].GetComponent<Image>().sprite = gunsInitial[4];
                break;
            case 2:
                gunsImg[5].GetComponent<Image>().sprite = gunsInitial[5];
                break;
        }
    }
}
