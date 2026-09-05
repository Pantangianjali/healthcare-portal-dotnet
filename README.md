# Healthcare Claims Portal - Zelis Tech Stack

.NET 10 Web API for healthcare financial data processing.

** Implementation:**
- **Azure Functions** → `ProcessClaimFunction.cs` - Serverless claim processing
- **APIM** → `apim-policy.xml` - JWT auth + rate limiting at gateway 
- **Key Vault** → `KeyVaultService.cs` - Managed Identity for secrets
- **Repository Pattern** → `ClaimsRepository.cs` - Clean data access layer
- **Dependency Injection** → `Program.DI.cs` - Decoupled architecture

Built to mirror healthcare payments platform architecture.
