using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuWelcome, MenuButtonTengah, MenuButtonKeluar, MenuGuide, MenuInformasi;
    private float kecepatan = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        MenuWelcome.DOAnchorPos(new Vector2(0,0), kecepatan);
        MenuButtonTengah.DOAnchorPos(new Vector2(0, 1354), kecepatan);
        MenuButtonKeluar.DOAnchorPos(new Vector2(0, 331), kecepatan);
        MenuGuide.DOAnchorPos(new Vector2(-1500, 0), kecepatan);
        MenuInformasi.DOAnchorPos(new Vector2(-1500, 0), kecepatan);
    }
    public void MenuUtama()
    {
        MenuWelcome.DOAnchorPos(new Vector2(0, 0), kecepatan);
        MenuButtonTengah.DOAnchorPos(new Vector2(0, 1354), kecepatan);
        MenuButtonKeluar.DOAnchorPos(new Vector2(0, 331), kecepatan);
        MenuGuide.DOAnchorPos(new Vector2(-1500, 0), kecepatan);
        MenuInformasi.DOAnchorPos(new Vector2(-1500, 0), kecepatan);
    }
    public void MenuInformasibutton()
    {
        MenuWelcome.DOAnchorPos(new Vector2(0, 2200), kecepatan);
        MenuButtonTengah.DOAnchorPos(new Vector2(-1500, 1354), kecepatan);
        MenuButtonKeluar.DOAnchorPos(new Vector2(1500, 331), kecepatan);
        MenuGuide.DOAnchorPos(new Vector2(-1500, 0), kecepatan);
        MenuInformasi.DOAnchorPos(new Vector2(0, 0), kecepatan);
    }
    public void MenuPetunjukbutton()
    {
        MenuWelcome.DOAnchorPos(new Vector2(0, 2200), kecepatan);
        MenuButtonTengah.DOAnchorPos(new Vector2(-1500, 1354), kecepatan);
        MenuButtonKeluar.DOAnchorPos(new Vector2(1500, 331), kecepatan);
        MenuGuide.DOAnchorPos(new Vector2(0, 0), kecepatan);
        MenuInformasi.DOAnchorPos(new Vector2(-1500, 0), kecepatan);
    }

}
