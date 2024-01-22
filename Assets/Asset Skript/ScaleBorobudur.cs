using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleBorobudur : MonoBehaviour
{
    
    public Slider ScaleSlider;
    [SerializeField] float currentScale = 0.4458053f;
    // Start is called before the first frame update
    void Start()
    {
        ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(ScaleSlider.value, ScaleSlider.value, ScaleSlider.value);
    }

    private void OnGUI()
    {
        currentScale = GUI.HorizontalSlider(new Rect(-137.0f, -710.4591f, 160.0f, 20.0f), currentScale, 0.4458053f, 1.0f);
        transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }

    public void AdjustScale(float newScale)
    {

    }
}
