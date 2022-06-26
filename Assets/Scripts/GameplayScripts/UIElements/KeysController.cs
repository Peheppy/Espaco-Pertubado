using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class KeysController : MonoBehaviour
{
    public FloatVariable PlayerKey;

    [SerializeField]
    Sprite K4, K3, K2, K1, K0;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }
    private void Update() 
    {
        KeyBar();
    }
     void KeyBar()
    {
        if (!(image = gameObject.GetComponent<Image>()))
        {
            Debug.Log("I have no Image component! Fix meeeeeeeeeeeee");
        }
        switch (PlayerKey.value)
        {
            case 4f:
                image.sprite = K4;
                break;
            case 3f:
                image.sprite = K3;
                break;
            case 2f:
                image.sprite = K2;
                break;
            case 1f:
                image.sprite = K1;
                break;
            default:
                image.sprite = K0;
            break;
        }
    }
}
