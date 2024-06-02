using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATM : MonoBehaviour
{
    public Bank _bank;
    int _depositMoney = 100;
    int _withDrawMoney = 200;

    float _timer = 2;
    private void OnTriggerEnter(Collider other)
    {
        _bank = BankManager.Instance.banks[0];

        if (other.CompareTag("Player")){

            CheckClientsToCheckBalance(other);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) && _timer > 1)
        {
            CheckClientsToDeposit(other, _depositMoney);
            _timer = 0;
        }
        if (Input.GetKeyDown(KeyCode.G) && _timer > 1)
        {
            CheckClientsToWithDraw(other,_withDrawMoney);
            _timer = 0;
        }
    }

    void CheckClientsToCheckBalance(Collider other)
    {
        for (int i = 0; i < BankManager.Instance.clients.Length; i++)
        {
            if (BankManager.Instance.clients[i].Name == other.GetComponent<Player>().MyName)
            {

                _bank.CheckBalance(BankManager.Instance.clients[i]);

                return;
            }
        }
    }
    void CheckClientsToDeposit(Collider other,int money)
    {
        for (int i = 0; i < BankManager.Instance.clients.Length; i++)
        {
            if (BankManager.Instance.clients[i].Name == other.GetComponent<Player>().MyName)
            {

                _bank.Deposit(BankManager.Instance.clients[i], money, _bank);

                return;
            }
        }
    }
    void CheckClientsToWithDraw(Collider other, int money)
    {
        for (int i = 0; i < BankManager.Instance.clients.Length; i++)
        {
            if (BankManager.Instance.clients[i].Name == other.GetComponent<Player>().MyName)
            {

                _bank.Withdraw(BankManager.Instance.clients[i], money, _bank);

                return;
            }
        }
    }
   

    private void Update()
    {
        _timer += Time.deltaTime;
    }
}
