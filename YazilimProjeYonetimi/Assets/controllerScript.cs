using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text;
    private Button close;
    private Image textImage;
    public bool value;
    void Awake()
    {
        text = GameObject.Find("text").GetComponent<Text>();
        close = GameObject.Find("close").GetComponent<Button>();
        textImage= GameObject.Find("textImage").GetComponent<Image>();

    }
    private void Start()
    {
        close.gameObject.SetActive(false);
        text.enabled = false;
        textImage.enabled = false;
        value = false;

    }
    public void playButton()
    {
        if (value)
        {
            SceneManager.LoadScene("EasyGame");
        }
        else
        {
            SceneManager.LoadScene("Game");
        }
    }
    public void closeButton()
    {
        text.enabled = false;
        close.gameObject.SetActive(false);
        textImage.enabled = false;
    }
    public void historyText()
    {
        
        text.text = "Þerife Bacý 1921 yýlýnda soðuktan donarak vefat etmiþtir. Ancak hikayesinin acý tarafý mücadelesinin tertemiz olmasýndan kaynaklanýyor deniliyor." +
            " Þerife Bacý, taþýdýðý cephanelerle birlikte yorgunluktan bitap düþtüðünden dinlenmeye koyulmuþtur." +
            "Hava buz gibi olduðundan, düþündüðü tek þey kucaðýndaki yavrusuna bir þey olmamasý ve cephaneleri sapasaðlam Ankara'ya taþýmaktý. " +
            "Ancak soðuk direncini gittikçe kýrýyordu. Ayaða kalkýp yola devam etmek istese de buna takati kalmadýðýndan yere yýðýldý. " +
            "Yere yýðýldýðýnda artýk geç olduðunu anlayan Þerife Bacý, kazaðýný çýkararak cephanelerin üzerini örtmüþ." +
            "Daha sonra yavrusunun donmamasý için sýký sýkýya sarýlmýþ ve vefat etmiþtir. Cephanelere bir þey olmamasý adýna kazaðýný çýkararak onlarý örtmesi," +
            " yaþamýnýn son diliminde yavrusunu yaþatmak için mücadelesi, Kurtuluþ Savaþý kadýnýnýn önemini gösteriyor.";
        textImage.enabled = true;
        text.enabled = true;
        close.gameObject.SetActive(true);
        



    }
    public void helpText()
    {
        text.text = "D ÝLERÝ GÝT / H BEBEÐE CAN VER";
        text.enabled = true;
        close.gameObject.SetActive(true);
        textImage.enabled = true;
    }
    public void developersInfoText()
    {
        text.text = "MURAT AKÇAY - HAMZA MERT ÖZATA";
        text.enabled = true;
        close.gameObject.SetActive(true);
        textImage.enabled = true;
    }

    public void toggleButton()
    {
        value = true;
    }
}
