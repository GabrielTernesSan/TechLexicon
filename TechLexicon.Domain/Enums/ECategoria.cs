using System.ComponentModel;

namespace TechLexicon.Domain.Enums
{
    public enum ECategoria
    {
        [Description("CSharp")]
        CSharp = 1,
        [Description("Orientação a Objetos")]
        OO = 2,
        [Description("DDD")]
        DDD = 3,
        [Description("Microsserviços")]
        Microsservicos = 4,
        [Description("PostgreSQL")]
        Postgres = 5,
        [Description("MongoDB")]
        Mongodb = 6,
        [Description("Redis")]
        Redis = 7,
        [Description("Docker")]
        Docker = 8,
        [Description("Kubernetes")]
        Kubernetes = 9,
        [Description("Azure")]
        Azure = 10,
        [Description("Git")]
        Git = 11,
        [Description("Angular")]
        Angular = 12,
        [Description("React")]
        React = 13,
        [Description("OAuth")]
        Oauth = 14,
        [Description("JWT")]
        Jwt = 15,
        [Description("Redes")]
        Redes = 16
    }
}
