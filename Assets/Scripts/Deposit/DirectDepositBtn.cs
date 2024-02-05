using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class DirectDepositBtn : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    //[SerializeField] private Text banlance;
    //[SerializeField] private Text currentMoney;
    private int banlanceValue;
    private int currentValue;
    //public Text currentMoneyComma;

    public void OnClickDeposit()
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
        if (numBanlance >= numInputField)
        {
            currentValue = numInputField + numMoney;
            GameManager.I.currentMoney.text = currentValue.ToString();

            banlanceValue = numBanlance - numInputField;
            GameManager.I.banlance.text = banlanceValue.ToString();
        }
        else if (numBanlance < numInputField)
        {
            GameManager.I.gameOverD();
        }


        //currentMoney.text= string.Format("{0:#,##0}", numInputField + numMoney);
    }

    public void OnClickDeposit1()
    {
        int num10000 = 10000;
        int numBanlance = int.Parse(GameManager.I.banlance.text);
        int numMoney = int.Parse(GameManager.I.currentMoney.text);

        if (numBanlance >= 10000)
        {
            currentValue = numMoney + num10000;
            GameManager.I.currentMoney.text = currentValue.ToString();

            banlanceValue = numBanlance - num10000;
            GameManager.I.banlance.text = banlanceValue.ToString();
        }
        else if (numBanlance < 10000)
        {
            GameManager.I.gameOverD();
        }

    }

    public void OnClickDeposit2()
    {
        int num20000 = 20000;
        int numBanlance = int.Parse(GameManager.I.banlance.text);
        int numMoney = int.Parse(GameManager.I.currentMoney.text);

        if (numBanlance >= 20000)
        {
            currentValue = numMoney + num20000;
            GameManager.I.currentMoney.text = currentValue.ToString();

            banlanceValue = numBanlance - num20000;
            GameManager.I.banlance.text = banlanceValue.ToString();
        }
        else if (numBanlance < 20000)
        {
            GameManager.I.gameOverD();
        }

    }

    public void OnClickDeposit5()
    {
        int num50000 = 50000;
        int numBanlance = int.Parse(GameManager.I.banlance.text);
        int numMoney = int.Parse(GameManager.I.currentMoney.text);

        if (numBanlance >= 50000)
        {
            currentValue = numMoney + num50000;
            GameManager.I.currentMoney.text = currentValue.ToString();

            banlanceValue = numBanlance - num50000;
            GameManager.I.banlance.text = banlanceValue.ToString();
        }
        else if (numBanlance < 50000)
        {
            GameManager.I.gameOverD();
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
