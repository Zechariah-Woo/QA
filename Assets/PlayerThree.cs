using TMPro;
using UnityEngine;

public class PlayerThree : MonoBehaviour

{
    [SerializeField] private TextMeshProUGUI _Text;
    private int Age = 17;
    private int Height = 180;
    private int Weight = 100000;
    private float Wingspan = 20.69f;


    public void Buttonpressed()
    {
        _Text.text = $"Name : Carlo Gaybriel H. Llao Llao \n age : {Age} \n Race : Lahat \n Height : {Height} \n Weight : {Weight} \n Wingspan : {Wingspan}";


    }
}
