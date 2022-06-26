using System.Collections;
using UnityEngine;
using UnityEngine.UI;
 
public class HpController : MonoBehaviour
{
    public FloatVariable PlayerHp;

    [SerializeField]
    Sprite Hp5, Hp4, Hp3, Hp2, Hp1;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }
    private void Update() 
    {
        lifeBar();
    }
     void lifeBar()
    {
        if (!(image = gameObject.GetComponent<Image>()))
        {
            Debug.Log("I have no Image component! Fix meeeeeeeeeeeee");
        }
        switch (PlayerHp.value)
        {
            case 5f:
                image.sprite = Hp5;
                break;
            case 4f:
                image.sprite = Hp4;
                break;
            case 3f:
                image.sprite = Hp3;
                break;
            case 2f:
                image.sprite = Hp2;
                break;
            default:
                image.sprite = Hp1;
            break;
        }
    }
}
