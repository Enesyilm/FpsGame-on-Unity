using UnityEngine;

namespace EnesTalhaYılmaz_Fps.Controllers{
public class PcControllers
{
    public bool jumpInput => Input.GetKeyDown(KeyCode.Space);
    public bool semiFireInput=>Input.GetKeyDown(KeyCode.D);
    public bool autoFireInput=>Input.GetKey(KeyCode.D);
    public bool switchWeaponInput=>Input.GetKeyDown(KeyCode.W);
    public bool reloadInput=>Input.GetKeyDown(KeyCode.R);
    public bool renewTargetHealthsInput=>Input.GetKeyDown(KeyCode.V);
    public float horizontal => Input.GetAxis("Horizontal");
    public float vertical => Input.GetAxis("Vertical");
    // Start is called before the first frame update
    
   
}

}
