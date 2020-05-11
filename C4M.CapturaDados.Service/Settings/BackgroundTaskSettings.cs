namespace C4M.BackgroundTasks.Settings
{
    public class BackgroundTaskSettings
    {
        public class C4MSettings
        {
            public string Id { get; set; }
            public string UserName { get; set; }
            public string CNPJ { get; set; }
            public string Name { get; set; }
            public string ConsumerKey { get; set; }
            public string ConsumerSecret { get; set; }
            public string Obs { get; set; }
        }

        public class C4MApiSettings
        {
            public string UrlDadosCompletos { get; set; }
        }
    }
}
