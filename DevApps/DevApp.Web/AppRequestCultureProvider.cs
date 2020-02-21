using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Globalization;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

using Tripous;
using Tripous.Data;
using Tripous.Model;
using Microsoft.AspNetCore.Http;

namespace Tripous.Web
{
    public class AppRequestCultureProvider : RequestCultureProvider
    {
        public override async Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }
 
            await Task.Yield();
            return new ProviderCultureResult(Session.Language.CultureCode);
        }
    }
}
