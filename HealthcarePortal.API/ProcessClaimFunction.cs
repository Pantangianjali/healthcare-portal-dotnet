using Microsoft.Azure.Functions.Worker; 
using Microsoft.Azure.Functions.Worker.Http; 

public class ProcessClaimFunction 
{ 
    [Function("ProcessClaim")] 
    public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req) 
    { 
        return req.CreateResponse(System.Net.HttpStatusCode.OK); 
    } 
}
