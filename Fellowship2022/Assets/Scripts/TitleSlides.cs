using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleSlides : MonoBehaviour
{
    [SerializeField] private Image slides;

    [SerializeField] private Sprite pic1;
    [SerializeField] private Sprite pic2;
    [SerializeField] private Sprite pic3;
    // Start is called before the first frame update
    void Start()
    {
        slides.sprite = pic1;
        StartCoroutine(ChangeImage());
    }

    // Update is called once per frame

    private IEnumerator ChangeImage()
    {
        while (true)
        {
            slides.sprite = pic1;
            yield return new WaitForSeconds(3);
            slides.CrossFadeAlpha(0,1,false);
            yield return new WaitForSeconds(1);
            slides.CrossFadeAlpha(1,1,false);
            slides.sprite = pic2;
            yield return new WaitForSeconds(3);
            
            slides.CrossFadeAlpha(0,1,false);
            yield return new WaitForSeconds(1);
            slides.CrossFadeAlpha(1,1,false);
            slides.sprite = pic3;
            yield return new WaitForSeconds(3);
            
            slides.CrossFadeAlpha(0,1,false);
            yield return new WaitForSeconds(1);
            slides.CrossFadeAlpha(1,1,false);
        }
    }
}
