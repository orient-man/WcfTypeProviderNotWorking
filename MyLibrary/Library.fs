namespace MyLibrary

open System
open System.ServiceModel
open FSharp.Data.TypeProviders

module Test =
    let [<Literal>] Schema = __SOURCE_DIRECTORY__ + @"\..\big.wsdlschema"

    type Big = WsdlService<ServiceUri = "N/A", ForceUpdate = false, LocalSchemaFile = Schema, Wrapped = true>

    type private B = Big.ServiceTypes

    let createClient (url: Uri) = Big.GetBIG(EndpointAddress url)

    let hello name =
        printfn "Hello %s" name