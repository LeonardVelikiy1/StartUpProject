using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Checking_moves : MonoBehaviour
{
    public bool enemisMove = true;//где true это ход врага а false наш ход 
    private int enemiHP = 100;
    private int heroHP = 100;
    private int ManaHero = 30;
    private int MadnesEnemi = 0;
    public Text HpTextHero;
    public Text HpTextEnemi;
    public Text Mana;
    public Text Madnes;

    private void Update()
    {
        MovesCheck();
        GameOverCheck();
    }
    void MovesCheck() 
    { 
        if (enemisMove == true)
        {
            EnemiAction();
        }
    }
    public void HeroAction()
    {
        print("я бью монстра");
        enemiHP -= 5;
        HpTextEnemi.text = enemiHP.ToString();
        enemisMove = true;
        print("у монстра осталось" + enemiHP + "HP");
    }
    public void LaithHATE()
    {
        if(ManaHero > 0)
        {
            print("я поражаю врага лучиком света");
            ManaHero -= 5;
            enemiHP -= 15;
            HpTextEnemi.text = enemiHP.ToString();
            Mana.text = ManaHero.ToString();
            enemisMove = true;
            print("у монстра осталось" + enemiHP + "HP");
        }else
        {
            print("нет маны");
        }
        
    }
    void GameOverCheck()
    {
        if(enemiHP <= 0 || heroHP <= 0)
        { 
            if(heroHP <= 0)
            {
                print("вы умерли");
                BatleFase();
            }
            if (enemiHP <= 0)
            {
                print("вы победили");
                BatleFase();
            }
        }
    }
    void EnemiAction()
    {
        if (MadnesEnemi<30)
        {
            print("я кусаю героя");
            heroHP -= 2;
            MadnesEnemi +=5;
            HpTextHero.text = heroHP.ToString();
            enemisMove = false;
            print("у героя осталось" + heroHP + "HP");
        }else
        {
            heroHP -= 20;
            HpTextHero.text = heroHP.ToString();
            enemisMove = false;
            print("у героя осталось" + heroHP + "HP");
        }
        
    }
    public void BatleFase(int _sceneNumber = 0)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
