namespace starterModuleMvcFsharp.Config 
    
open DotNetNuke.Web.Mvc.Routing
open DotNetNuke.DependencyInjection
open starterModuleMvcFsharp.Services
open Microsoft.Extensions.DependencyInjection
    
type RouteConfig () =
    interface IMvcRouteMapper with
        member __.RegisterRoutes(mapRouteManager :IMapRoute ) =
            mapRouteManager.MapRoute (
                "starter_module_mvc",
                "default", 
                "{controller}/{action}", 
                [|"starterModuleMvcFsharp.Controllers"|]
            ) |> ignore

type StartUp () =
    interface IDnnStartup with 
        member __.ConfigureServices (services:IServiceCollection) = 
            services.AddScoped<IMyService, MyService>() |> ignore
