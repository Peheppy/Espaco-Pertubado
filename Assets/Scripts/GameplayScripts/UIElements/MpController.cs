using System.Collections;
using UnityEngine;
using UnityEngine.UI;
 
public class MpController : MonoBehaviour
{
    public FloatVariable PlayerMp;

    [SerializeField]
    Sprite Mp4, Mp3, Mp2, Mp1, Mp0;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }
    private void Update() 
    {
        ManaBar();
    }
     void ManaBar()
    {
        if (!(image = gameObject.GetComponent<Image>()))
        {
            Debug.Log("I have no Image component! Fix meeeeeeeeeeeee");
        }
        switch (PlayerMp.value)
        {
            case 4f:
                image.sprite = Mp4;
                break;
            case 3f:
                image.sprite = Mp3;
                break;
            case 2f:
                image.sprite = Mp2;
                break;
            case 1f:
                image.sprite = Mp1;
                break;
            default:
                image.sprite = Mp0;
            break;
        }
    }
}
