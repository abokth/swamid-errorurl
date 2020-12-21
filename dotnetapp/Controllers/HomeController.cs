using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Swamid.Errorurl.Models;
using Swamid.Errorurl.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Builder;

namespace Swamid.Errorurl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IStringLocalizer<HomeController> _localizer;
        private IOptions<RequestLocalizationOptions> _locOptions;
        private LanguageSettings _languageSettings;
        private string _culture;

        [ViewData]
        public string  Title { get; set; }
        [ViewData]
        public string Footer { get; set; }
        public HomeController(ILogger<HomeController> logger, 
            IStringLocalizer<HomeController> localizer,
            IOptions<RequestLocalizationOptions> LocOptions,
            LanguageSettings languageSettings
)
        {
            _logger = logger;
            _localizer = localizer;
            _locOptions = LocOptions;
            _languageSettings = languageSettings;
        }
       
        public IActionResult Index([FromQuery] QueryParams query)
        {

            SetLanguage(query);
            var le = GetErrors();
            var model = new ErrorViewModel() { Parameters = query };
            SetNavigation(le,model);
            
            if (query.errorurl_code + "" == "" | (query.errorurl_code + "" == "ERRORURL_CODE"))
            {
                //Get all errors
                model.LoginError = le.Errors.ToList();
            }
            else
            {
                //Get specific error
                LoginError e = le.Errors.Where(e => e.Type == query.errorurl_code).SingleOrDefault();
                if ((query.errorurl_ctx + "" != "" && (query.errorurl_ctx + "").ToUpper() != "errorurl_ctx"))
                {
                    if (e.context != null)
                    {
                        var ctx = e.context.Where(i => i.Identifiers.Contains(query.errorurl_ctx)).SingleOrDefault();
                        if (ctx != null)
                        {
                            e.Header = ctx.Header;
                            e.Body = ctx.Body;
                        }
                    }
                }
                //ToDo handle if e is null
                model.LoginError = new List<LoginError>() { e };
            }
            Footer = _localizer.GetString("FooterText").Value;
            Title = model.LoginError.First().Header;
            return View(model);
            
        }
        private void SetNavigation(LoginErrors errors, ErrorViewModel model)
        {
            if (errors != null)
            {
                model.Culture = errors.SwitchLang; 
                model.CultureText = errors.SwitchLangText;
                model.CultureLogo = errors.SwitchLangImage;
                model.TechnicalInfo = errors.TechnicalInformation;
                model.ContactInfo = errors.ContactInfo;
            }
        }
        private void SetLanguage(QueryParams query)
        {
            _culture = _languageSettings.DefaultCulture;
            if (query.lang != null)
            {
                if (_languageSettings.SupportedCultures.Contains(query.lang.ToLower()))
                {
                    _culture = query.lang;
                }    
            }
            query.lang = null;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private LoginErrors GetErrors()
        {
            return _languageSettings.LoginErrors.Where(e => e.culture == _culture).FirstOrDefault();
        }
    }
}
