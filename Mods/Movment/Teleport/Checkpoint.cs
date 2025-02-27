       public static void Checkpoint(){
            if (rightGrab){
                if (CheckPoint == null){
                    CheckPoint = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(CheckPoint.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(CheckPoint.GetComponent<SphereCollider>());
                    CheckPoint.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);}
                CheckPoint.transform.position = GorillaTagger.Instance.rightHandTransform.position;}
            if (CheckPoint != null){
                if (rightPrimary){
                    CheckPoint.GetComponent<Renderer>().material.color = bgColorA;
                    TeleportPlayer(CheckPoint.transform.position);
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;}
                else{
                    CheckPoint.GetComponent<Renderer>().material.color = buttonDefaultA;
                }}}

        public static void DisableCheckpoint(){
            if (CheckPoint != null){
                UnityEngine.Object.Destroy(CheckPoint);
                CheckPoint = null;
            }}
