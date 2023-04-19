using UnityEngine;


namespace com.davidhopetech.phone.run_time.scripts
{
    public class VRCam : MonoBehaviour
    {
        private Phone phone;


        void Start()
        {
            if (phone == null)
            {
                phone = GameObject.FindObjectOfType<Phone>();
                
                if (phone == null)
                {
                    Debug.Log("Error: Phone not found");
                    return;
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (!Object.ReferenceEquals(phone, null))
            {
                transform.rotation = phone.CalibratedGyroAttitude;
            }
        }
    }
}