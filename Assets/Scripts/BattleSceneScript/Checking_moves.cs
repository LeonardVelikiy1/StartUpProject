using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Checking_moves : MonoBehaviour
{
    public bool enemisMove = false; //где true это ход врага а false наш ход 
    private int enemiHP = 100;
    private int heroHP = 100;
    private int ManaHero = 30;
    private int MadnesEnemi = 0;
    public TextMesh HpTextHero;
    public TextMesh HpTextEnemi;
    public TextMesh Mana;

    //public Text Madnes;

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
                BattleLose();
            }
            if (enemiHP <= 0)
            {
                print("вы победили");
                BattleWin();
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
    public void BattleLose(int _sceneNumber = 3)
    {
        SceneManager.LoadScene(_sceneNumber);
    }

    public void BattleWin(int _sceneNumber = 1)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
