namespace BA.Configuration
{
    public static class Configuration
    {
        private static ApplicationSettings AppSet = null;
        static Configuration()
        { AppSet = new ApplicationSettings(); }

        public static ApplicationSettings AppSets
        { get { return AppSet; } }
    }
}
