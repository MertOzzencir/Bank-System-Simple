using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

[System.Serializable]
public class Bank 
{
    public string Name;
    public int CashInVault;
    
    //Constructor
    public Bank(string name, int cash)
    {
        Name = name;
        CashInVault = cash;

    }

    public void CheckBalance(Client client)
    {
        Debug.Log(client.Cash);


    }

    public void Deposit(Client client, int money, Bank bank)
    {

        if(client.Cash >= money)
        {
            bank.CashInVault += money;
            client.Cash -= money;
        }
        else
        {
            Debug.Log("ERROR! Please Make Sure The Money You Wanna Deposit is Higher Than Your Balance");
        }

    }
    public void Withdraw(Client client, int money, Bank bank)
    {

        if (bank.CashInVault >= money)
        {
            bank.CashInVault -= money;
            client.Cash += money;
        }
        else
        {
            Debug.Log("ERROR! Please Make Sure The Money You Wanna Withdraw is Lower Than Cash in Vault");
        }
    }
}
