using TMPro;
using UnityEngine;
using DG;
using DG.Tweening;
public class PopupController : MonoBehaviour
{
    //Singleton Instance
    static PopupController instance;
    // Public accessor for the instance
    public static PopupController Instance {
        get {
            // If the instance doesn't exist, find it in the scene
            if (instance == null) {
                instance = FindAnyObjectByType<PopupController>();

                // If no instance exists in the scene, create an empty GameObject and add the PopupController script
                if (instance == null) {
                    GameObject singletonObject = new GameObject("PopupController");
                    instance = singletonObject.AddComponent<PopupController>();
                }
            }

            return instance;
        }
    }

    //Todo: Add Dotween to animate the popup
    [SerializeField] GameObject popup;
    [SerializeField] GameObject backGround;
    [SerializeField] TextMeshProUGUI tmp_message;
    [ShowOnly] [SerializeField]  string message = "Default";
    Tween tween;


    void Awake() {
        // Ensure there's only one instance of PopupController
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
    void Start() {
        HidePopup();
    }
    //show popup
    public void ShowPopup(string message) {
        backGround.SetActive(true);

        this.message = message;
        popup.SetActive(true);

        tmp_message.text = message;//set message
        popup.transform.DOScale(1, 0.5f).SetEase(Ease.OutBack).OnComplete(() => {
            backGround.SetActive(true);
        });
        
    }
    //hide popup
    public void HidePopup() {
        popup.transform.DOScale(0, 0.5f).SetEase(Ease.InBack).OnComplete(() => {
            backGround.SetActive(false);
            tmp_message.text = "";//reset message
            popup.SetActive(false);
        });
    }
}
