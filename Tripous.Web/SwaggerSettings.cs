using System;
 

namespace Tripous.Web
{
    /// <summary>
    /// Swagger settings
    /// <para> https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle </para>
    /// <para> https://thecodebuzz.com/oauth2-authentication-iswagger-open-api-asp-net-core-3-0/ </para>
    /// <para> https://thecodebuzz.com/swagger-api-documentation-in-net-core-3-0/ </para>
    /// <para> https://github.com/domaindrivendev/Swashbuckle.AspNetCore </para>
    /// <para> https://github.com/domaindrivendev/Swashbuckle.AspNetCore#getting-started </para>
    /// <para> https://github.com/domaindrivendev/Swashbuckle.AspNetCore#configuration--customization </para>
    /// <para> https://github.com/domaindrivendev/Swashbuckle.AspNetCore#add-security-definitions-and-requirements </para>
    /// <para> https://github.com/domaindrivendev/Swashbuckle.AspNetCore#enable-oauth20-flows </para>
    /// <para> https://github.com/domaindrivendev/Swashbuckle.AspNetCore#swashbuckleaspnetcoreannotations </para>
    /// <para> https://www.taithienbo.com/configure-oauth2-implicit-flow-for-swagger-ui/ </para>
    /// <para> http://www.sharepointconfig.com/2018/08/configure-swagger-to-authenticate-against-azure-ad/  </para>
    /// </summary>
    public class SwaggerSettings
    {
        /// <summary>
        /// True to use Swagger
        /// </summary>
        public bool Enabled { get; set; } = false;
        /// <summary>
        /// The ClientId, from Azure AD application registration
        /// </summary>
        public string ClientId { get; set; }
        /// <summary>
        /// The ClientSecret, from Azure AD
        /// </summary>
        public string ClientSecret { get; set; }
    }
}
