using System;
using System.Text;
using System.Linq;
using Newtonsoft.Json.Linq;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Microsoft.AspNetCore.Builder
{
    public static class SwaggerUIOptionsExtensions
    {
        /// <summary>
        /// Injects additional Javascript files into the index.html page
        /// </summary>
        /// <param name="options"></param>
        /// <param name="path">A path to the javascript - i.e. the script "src" attribute</param>
        /// <param name="type">The script type - i.e. the script "type" attribute</param>
        public static void InjectJavascript(this SwaggerUIOptions options, string path, string type = "text/javascript")
        {
            var builder = new StringBuilder(options.HeadContent);
            builder.AppendLine($"<script src='{path}' type='{type}'></script>");
            options.HeadContent = builder.ToString();
        }
    }
}
