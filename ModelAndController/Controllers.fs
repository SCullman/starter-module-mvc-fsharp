namespace starterModuleMvcFsharp.Controllers 

open DotNetNuke.Web.Mvc.Framework.Controllers
open System.Web.Mvc
open starterModuleMvcFsharp.Models
open starterModuleMvcFsharp.Services
open DotNetNuke.Web.Mvc.Framework.ActionFilters
open DotNetNuke.Collections;
open DotNetNuke.Security

[<DnnHandleError>]
type HomeController (service: IMyService) =
    inherit DnnController ()
        
    [< HttpGet>]
    member __.Home () = 
        let message = { Message = service.DnnHello(); Name = "" }
        __.View message :> ActionResult

    [<HttpPost>]
    member __.Home data =
        let message = {data with Message = service.DnnHelloPersonalize data.Name}
        __.View message :> ActionResult

[<DnnHandleError>]
[<DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)>]
type SettingsController () =
    inherit DnnController ()

    [<HttpGet>]
    member __.Settings () =
        
        let settings =  
            { Setting1 = __.ModuleContext.Configuration.ModuleSettings.GetValueOrDefault("Setting1", false)
              Setting2 = __.ModuleContext.Configuration.ModuleSettings.GetValueOrDefault("Setting2", System.DateTime.Now) }

        __.View settings :> ActionResult

    [<HttpPost>] 
    [<ValidateInput(false)>]
    [<DotNetNuke.Web.Mvc.Framework.ActionFilters.ValidateAntiForgeryToken>]
    member __.Settings ( settings ) =
        __.ModuleContext.Configuration.ModuleSettings.["Setting1"] <- settings.Setting1.ToString()
        __.ModuleContext.Configuration.ModuleSettings.["Setting2"] <- settings.Setting2.ToUniversalTime().ToString("u")
        __.RedirectToDefaultRoute();

