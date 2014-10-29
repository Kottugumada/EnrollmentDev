Add-AzureAccount
Select-AzureSubscription "Visual Studio Ultimate with MSDN"
Publish-AzureWebsiteProject -Name OMAPDev -Package "F:\AzureWebsite\OMAPDev\OMAPDev\PublishedPackage\OMAPDev.zip"