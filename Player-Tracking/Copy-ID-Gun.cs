        public static void CopyIDGun(){
            if (GetGunInput(false)){
                var GunData = RenderGun();
                RaycastHit Ray = GunData.Ray;
                GameObject NewPointer = GunData.NewPointer;
                if (GetGunInput(true) && Time.time > idgundelay){
                    VRRig possibly = Ray.collider.GetComponentInParent<VRRig>();
                    if (possibly && possibly != GorillaTagger.Instance.offlineVRRig){
                        idgundelay = Time.time + 0.5f;
                        string id = GetPlayerFromVRRig(possibly).UserId;
                        NotifiLib.SendNotification("<color=grey>[</color><color=green>SUCCESS</color><color=grey>]</color> " + id, 5000);
                        GUIUtility.systemCopyBuffer = id;
                    }}}}