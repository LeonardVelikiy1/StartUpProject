using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Checking_moves : MonoBehaviour
{
    public bool enemisMove = true;//��� true ��� ��� ����� � false ��� ��� 
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
        print("� ��� �������");
        enemiHP -= 5;
        HpTextEnemi.text = enemiHP.ToString();
        enemisMove = true;
        print("� ������� ��������" + enemiHP + "HP");
    }
    public void LaithHATE()
    {
        if(ManaHero > 0)
        {
            print("� ������� ����� ������� �����");
            ManaHero -= 5;
            enemiHP -= 15;
            HpTextEnemi.text = enemiHP.ToString();
            Mana.text = ManaHero.ToString();
            enemisMove = true;
            print("� ������� ��������" + enemiHP + "HP");
        }else
        {
            print("��� ����");
        }
        
    }
    void GameOverCheck()
    {
        if(enemiHP <= 0 || heroHP <= 0)
        { 
            if(heroHP <= 0)
            {
                print("�� ������");
                BatleFase();
            }
            if (enemiHP <= 0)
            {
                print("�� ��������");
                BatleFase();
            }
        }
    }
    void EnemiAction()
    {
        if (MadnesEnemi<30)
        {
            print("� ����� �����");
            heroHP -= 2;
            MadnesEnemi +=5;
            HpTextHero.text = heroHP.ToString();
            enemisMove = false;
            print("� ����� ��������" + heroHP + "HP");
        }else
        {
            heroHP -= 20;
            HpTextHero.text = heroHP.ToString();
            enemisMove = false;
            print("� ����� ��������" + heroHP + "HP");
        }
        
    }
    public void BatleFase(int _sceneNumber = 0)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
