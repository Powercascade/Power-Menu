        public static void LowQualityMicrophone()
        {
            Photon.Voice.Unity.Recorder mic = GorillaTagger.Instance.myRecorder;
            mic.SamplingRate = SamplingRate.Sampling08000;
            mic.Bitrate = 5;
            mic.RestartRecording(true);}

        public static void HighQualityMicrophone(){
            Photon.Voice.Unity.Recorder mic = GorillaTagger.Instance.myRecorder;
            mic.SamplingRate = SamplingRate.Sampling16000;
            mic.Bitrate = 20000;
            mic.RestartRecording(true);}

        public static void LoudMicrophone(){
            Photon.Voice.Unity.Recorder mic = GorillaTagger.Instance.myRecorder;
            if (!mic.gameObject.GetComponent<MicAmplifier>()){
                mic.gameObject.AddComponent<MicAmplifier>();}
            MicAmplifier loudman = mic.gameObject.GetComponent<MicAmplifier>();
            loudman.AmplificationFactor = 16;
            loudman.BoostValue = 16;
            mic.RestartRecording(true);}

        public static void NotLoudMicrophone(){
            Photon.Voice.Unity.Recorder mic = GorillaTagger.Instance.myRecorder;
            if (mic.gameObject.GetComponent<MicAmplifier>()){
                UnityEngine.Object.Destroy(mic.gameObject.GetComponent<MicAmplifier>());}

            public static void ReloadMicrophone(){
            Photon.Voice.Unity.Recorder mic = GameObject.Find("Photon Manager").GetComponent<Photon.Voice.Unity.Recorder>();
            mic.RestartRecording(true);}