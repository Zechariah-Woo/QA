using TMPro;
using UnityEngine;

public class PlayerOne : MonoBehaviour

{
    [SerializeField] private TextMeshProUGUI _Text;
    private int Age = 69;
    private float Height = 199.99f;
    private int Weight = 1400;
    private float Wingspan = 200.50f;
    
     
    public void Buttonpressed()
    {
        _Text.text = $"Name : Zion F. Footalan \n age : {Age} \n Race : African American \n Height : {Height} \n Weight : {Weight} \n Wingspan : {Wingspan}";
    }
}
