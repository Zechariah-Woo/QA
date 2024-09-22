using TMPro;
using UnityEngine;

public class PlayerTwo : MonoBehaviour

{
    [SerializeField] private TextMeshProUGUI _Text;
    private int Age = 16;
    private int Height = 165;
    private int Weight = 100;
    private float Wingspan = 100.29f;


    public void Buttonpressed()
    {
        _Text.text = $"Name : Karl Matthew M. Gabieta \n age : {Age} \n Race : Lahat \n Height : {Height} \n Weight : {Weight} \n Wingspan : {Wingspan}";


    }
}