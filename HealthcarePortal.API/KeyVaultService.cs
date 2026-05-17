using Azure.Identity; 
using Azure.Security.KeyVault.Secrets; 

var client = new SecretClient(new Uri("https://zelis-kv.vault.azure.net/"), new DefaultAzureCredential());
