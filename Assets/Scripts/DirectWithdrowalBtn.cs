using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class DirectWithdrowalBtn : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    //[SerializeField] private Text banlance;
    //[SerializeField] private Text currentMoney;
    private int banlanceValue;
    private int currentValue;
    //public Text currentMoneyComma;

    public void OnClickWithdraw()
    {
        //��ǲ �ʵ���� ���ڸ� ���ڷ� ��ȯ
        int numInputField = int.Parse(inputField.text);
        int numBanlance = int.Parse(GameManager.I.banlance.text);
        int numMoney = int.Parse(GameManager.I.currentMoney.text);


        //if(inputField = null)
        //{
        //    return;
        //}
        // +�� �޸��� �ִ� ���ڿ��� ��ȯ
        if (numMoney >= numInputField)
        {
            banlanceValue = numInputField + numBanlance;
            GameManager.I.banlance.text = banlanceValue.ToString();

            currentValue = numMoney - numInputField;
            GameManager.I.currentMoney.text = currentValue.ToString();
        }
        else if (numMoney < numInputField)
        {
            GameManager.I.gameOverW();
        }


        //currentMoney.text= string.Format("{0:#,##0}", numInputField + numMoney);
    }

    public void OnClickWithdraw1()
    {
        int numMoney = int.Parse(GameManager.I.currentMoney.text);
        int numBanlance = int.Parse(GameManager.I.banlance.text);
        int num10000 = 10000;
        //int numBanlance = int.Parse(banlance.text);
        //int numMoney = int.Parse(currentMoney.text);

        if (numMoney >= 10000)
        {
            banlanceValue = num10000 + numBanlance;
            GameManager.I.banlance.text = banlanceValue.ToString();

            currentValue = numMoney - num10000;
            GameManager.I.currentMoney.text = currentValue.ToString();
        }
        else if (numMoney < 10000)
        {
            GameManager.I.gameOverW();
        }

    }

    public void OnClickWithdraw2()
    {
        int num20000 = 20000;
        int numBanlance = int.Parse(GameManager.I.banlance.text);
        int numMoney = int.Parse(GameManager.I.currentMoney.text);

        if (numMoney >= 20000)
        {
            banlanceValue = num20000 + numBanlance;
            GameManager.I.banlance.text = banlanceValue.ToString();

            currentValue = numMoney - num20000;
            GameManager.I.currentMoney.text = currentValue.ToString();
        }
        else if (numMoney < 20000)
        {
            GameManager.I.gameOverW();
        }

    }

    public void OnClickWithdraw5()
    {
        int num50000 = 50000;
        int numBanlance = int.Parse(GameManager.I.banlance.text);
        int numMoney = int.Parse(GameManager.I.currentMoney.text);

        if (numMoney >= 50000)
        {
            banlanceValue = num50000 + numBanlance;
            GameManager.I.banlance.text = banlanceValue.ToString();

            currentValue = numMoney - num50000;
            GameManager.I.currentMoney.text = currentValue.ToString();
        }
        else if (numMoney < 50000)
        {
            //gameObject.transform.Find("Error").gameObject.SetActive(true);
            GameManager.I.gameOverW();
        }

    }

    //public string ChangeComma(int currentMoney)
    //{
    //    �� ����(��ǲ�ʵ��� ���� �ҷ��ͼ�
    //    int currentMoney = int.Parse(inputField.text);
    //    ���ڿ�����
    //    string commavalue = string.Format("{0:#,##0}", currentMoney);
    //    return string.Format("{0:#,###}", currentMoney);
    //}


}
