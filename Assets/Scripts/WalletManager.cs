using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalletManager : MonoBehaviour
{

    public int currentAmount = 0;
    public Text balance;
    // Start is called before the first frame update
    void Start()
    {
        addMoney();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N)) {
            addMoney();
        }
    }

    public void addMoney(){
        currentAmount = currentAmount + 500000;
        string newBalance = currentAmount.ToString();
        int len = currentAmount.ToString().Length;
        string initZeros = "";
        for(int i = len; i<9; i++){
            initZeros = initZeros + '0';
        }
        
        balance.text = initZeros + newBalance;
    }

    public void deductMoney(){
        currentAmount = currentAmount - 10000;
        string newBalance = currentAmount.ToString();
        int len = currentAmount.ToString().Length;
        string initZeros = "";
        for(int i = len; i<9; i++){
            initZeros = initZeros + '0';
        }
        
        balance.text = initZeros + newBalance;
    }


}
