# Inventory Management Demo Web API #

Inventory Management Web API demo


## Prerequisites ##

* Azure Account: [Get a free account][az account free]
* Azure CLI: [Install][az cli install]


## Getting Started ##

To provision resources to Azure and deploy ASP.NET Core Web API, follow the steps below.

1. Build ASP.NET Core Web API app.

   ```bash
   dotnet restore .
   dotnet build .
   ```

1. Publish the app.

   ```bash
   dotnet publish -c Release -o publish
   ```

1. Zip the app.

   ```bash
   cd publish
   zip zip -r publish.zip .
   mv publish.zip ../
   cd ..
   ```

1. Login to Azure via Azure CLI.

    ```bash
    az login
    ```

1. Run the bash script.

    ```bash
    ./setup.sh
    ```


[az account free]: https://azure.microsoft.com/free?WT.mc_id=github-0000-juyoo
[az cli install]: https://docs.microsoft.com/cli/azure/install-azure-cli?WT.mc_id=github-0000-juyoo
