// NOTE: script is not presenting best practices :)
#r "./packages/FAKE/tools/FakeLib.dll"
open Fake

RestorePackages()

let outDirRoot = "./bin/"
let zipOutDir = "./deploy/"
let servicesOutDir = "./bin/services"
let webSiteOutDir = "./bin/websites"

Target "Clean" (fun _ -> 
    CleanDirs [servicesOutDir; webSiteOutDir; zipOutDir]
)

Target "BuildServices" (fun _ -> 
   !! "./**/*Service.csproj"
   |> MSBuildRelease servicesOutDir "Build"
   |> Log "Services-Out: "
)

Target "BuildWebSites" (fun _ ->
    !! "./**/*FrontEndApp.csproj"
    |> MSBuildReleaseExt null [("DeployOnBuild", "true"); ("PublishProfile", "LocalFilesDeploy.pubxml")] "Build"
    |> Log "WebSites-Out: "
)

Target "ZipDeploy" (fun _ ->
    !! (outDirRoot + "/**/*.*")
        -- "*.zip"
        |> Zip outDirRoot (zipOutDir + "Deploy.zip")
)

Target "Default" (fun _ ->
    trace "Default target started"
)

"Clean"
    ==> "BuildServices"
    ==> "BuildWebSites"
    ==> "ZipDeploy"
    ==> "Default"

RunTargetOrDefault "Default"