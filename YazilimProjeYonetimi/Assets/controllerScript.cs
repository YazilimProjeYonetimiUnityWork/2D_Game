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
        
        text.text = "�erife Bac� 1921 y�l�nda so�uktan donarak vefat etmi�tir. Ancak hikayesinin ac� taraf� m�cadelesinin tertemiz olmas�ndan kaynaklan�yor deniliyor." +
            " �erife Bac�, ta��d��� cephanelerle birlikte yorgunluktan bitap d��t���nden dinlenmeye koyulmu�tur." +
            "Hava buz gibi oldu�undan, d���nd��� tek �ey kuca��ndaki yavrusuna bir �ey olmamas� ve cephaneleri sapasa�lam Ankara'ya ta��makt�. " +
            "Ancak so�uk direncini gittik�e k�r�yordu. Aya�a kalk�p yola devam etmek istese de buna takati kalmad���ndan yere y���ld�. " +
            "Yere y���ld���nda art�k ge� oldu�unu anlayan �erife Bac�, kaza��n� ��kararak cephanelerin �zerini �rtm��." +
            "Daha sonra yavrusunun donmamas� i�in s�k� s�k�ya sar�lm�� ve vefat etmi�tir. Cephanelere bir �ey olmamas� ad�na kaza��n� ��kararak onlar� �rtmesi," +
            " ya�am�n�n son diliminde yavrusunu ya�atmak i�in m�cadelesi, Kurtulu� Sava�� kad�n�n�n �nemini g�steriyor.";
        textImage.enabled = true;
        text.enabled = true;
        close.gameObject.SetActive(true);
        



    }
    public void helpText()
    {
        text.text = "Oyunda iki seviye bulunmaktad�r. �lk a��l��ta oynanmak istenen seviye se�ilir. Seviye se�iminden sonra oyun ba�lamaktad�r." +
            " Klavyenizde yer alan �D� veya �-->� tu�u ile �erife bac� karakterini ve ka�n�y� X y�n�nde ileri do�ru hareket ettirebilirsiniz. " +
            "Oyunda ge�en s�re boyunca oyun i�erisinde kar ya���lar� meydana gelecektir. Bu nedenler �erife bac�n�n ve bebe�in Can seviyelerinde azalma" +
            " meydana gelecektir. Klavyenizde yer alan �H� tu�u ile bebek karakterin can�n� artt�rabilirsiniz. Oyun biti� konumuna geldi�inizde sonlanacakt�r.";
        text.enabled = true;
        close.gameObject.SetActive(true);
        textImage.enabled = true;
    }
    public void developersInfoText()
    {
        text.text = "Oyun hakk�nda daha fazla bilgiye Ana Men�de yer alan HELP, HISTORY ,DEVELOPERS butonlar�na t�klayarak " +
            "ula�abilirsiniz.Hakk�m�zda daha fazla bilgi ve sizlere sunabilece�imiz di�er  hizmetler i�in Manisa Celal Bayar �niversitesi / " +
            "Hasan Ferdi Turgutlu Teknoloji Fak�ltesi'nde bizi ziyaret edin. Acarlar, �ehit, Ali Karakuzu Sk.No:10, 45400 Turgutlu / Manisa \n\n" +
            "Geli�tirme Ekibi :\n\n" +
            "MURAT AK�AY\n" +
            "HAMZA MERT �ZATA";
        text.enabled = true;
        close.gameObject.SetActive(true);
        textImage.enabled = true;
    }

    public void toggleButton()
    {
        value = true;
    }
}
