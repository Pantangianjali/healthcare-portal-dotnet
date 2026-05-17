public interface IClaimsRepository { Task<Claim> GetByIdAsync(int id); } 
public class ClaimsRepository : IClaimsRepository 
{ 
    public Task<Claim> GetByIdAsync(int id) => Task.FromResult(new Claim()); 
} 
public class Claim { public int Id { get; set; } }
