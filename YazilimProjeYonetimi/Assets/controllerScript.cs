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
        SceneManager.LoadScene("Game");
    }
    public void playEasyButton()
    {
        SceneManager.LoadScene("EasyGame");
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
        text.text = "Oyunda iki seviye bulunmaktadýr. Ýlk açýlýþta oynanmak istenen seviye seçilir. Seviye seçiminden sonra oyun baþlamaktadýr." +
            " Klavyenizde yer alan “D” veya “-->” tuþu ile þerife bacý karakterini ve kaðnýyý X yönünde ileri doðru hareket ettirebilirsiniz. " +
            "Oyunda geçen süre boyunca oyun içerisinde kar yaðýþlarý meydana gelecektir. Bu nedenler þerife bacýnýn ve bebeðin Can seviyelerinde azalma" +
            " meydana gelecektir. Klavyenizde yer alan “H” tuþu ile bebek karakterin canýný arttýrabilirsiniz. Oyun bitiþ konumuna geldiðinizde sonlanacaktýr.";
        text.enabled = true;
        close.gameObject.SetActive(true);
        textImage.enabled = true;
    }
    public void developersInfoText()
    {
        text.text = "Oyun hakkýnda daha fazla bilgiye Ana Menüde yer alan HELP, HISTORY ,DEVELOPERS butonlarýna týklayarak " +
            "ulaþabilirsiniz.Hakkýmýzda daha fazla bilgi ve sizlere sunabileceðimiz diðer  hizmetler için Manisa Celal Bayar Üniversitesi / " +
            "Hasan Ferdi Turgutlu Teknoloji Fakültesi'nde bizi ziyaret edin. Acarlar, Þehit, Ali Karakuzu Sk.No:10, 45400 Turgutlu / Manisa \n\n" +
            "Geliþtirme Ekibi :\n\n" +
            "MURAT AKÇAY\n" +
            "HAMZA MERT ÖZATA";
        text.enabled = true;
        close.gameObject.SetActive(true);
        textImage.enabled = true;
    }

    public void toggleButton()
    {
        value = true;
    }
}
