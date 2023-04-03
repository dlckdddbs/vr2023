using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attck()
    {
        Debug.Log(this.power + "데미지를 입혔다");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입혔다.");
        //Debug.Log("현재 hp"+ hp);
    }

    public int GetHp()
    {
        return this.hp;
    }

}

public class Test_008 : MonoBehaviour
{
    Player player_01 = new Player();
    Player player_02 = new Player();

    public Text player01hp;
    public Text player02hp;

    // Start is called before the first frame update
    void Start()
    {
        
        player_01.Attck();
        player_01.Damage(30);
    }

    // Update is called once per frame
    void Update()
    {
        player01hp.text = "Player 01 hp : " + player_01.GetHp().ToString();
        player02hp.text = "Player 01 hp : " + player_02.GetHp().ToString();

        if (Input.GetMouseButtonDown(0))
        {
            player_01.Damage(1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            player_02.Damage(1);
        }
    }
}
