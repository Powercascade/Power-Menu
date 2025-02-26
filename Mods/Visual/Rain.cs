        public static void Rain(){
            for (int i = 1; i < BetterDayNightManager.instance.weatherCycle.Length; i++){
                BetterDayNightManager.instance.weatherCycle[i] = BetterDayNightManager.WeatherType.Raining;
            }}

        public static void NoRain(){
for (int i = 1; i < BetterDayNightManager.instance.weatherCycle.Length; i++){
                BetterDayNightManager.instance.weatherCycle[i] = BetterDayNightManager.WeatherType.None;
            }}