namespace Tennis.Api.Mapping
{
    public class ApiEndpoints
    {
        private const string ApiBase = "api";

        public static class Players
        {
            private const string Base = $"{ApiBase}/players";
            public const string Get = $"{Base}/{{id}}";
            public const string GetAll = Base;
            public const string GetStats = $"{Base}/stats";
        }
    }
}
