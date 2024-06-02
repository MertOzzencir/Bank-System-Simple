using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Client {

   
    public string Name;
    public int Cash;



    public Client(  string name, int cash)
    {
        Name = name;
        Cash = cash;
    }

}
public class BankManager : MonoBehaviour
{
   public static BankManager _instance;
    public static BankManager Instance
    {
        get 
        { 
            if(_instance == null)
            {
                GameObject go = new("GameManager_");
                go.AddComponent<BankManager>();


            }
            return _instance; 
        }
                
    }

    public Bank[] banks = new Bank[1];
    public Client[] clients = new Client[1];    
    private void Awake()
    {
        _instance = this;
        banks[0] = new Bank("Garanti Bank", 5000);

    }
}
            
            



