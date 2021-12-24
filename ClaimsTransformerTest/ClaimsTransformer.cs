using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;


namespace ClaimsTransformerTest
{
    public class ClaimsTransformer : IClaimsTransformation
    {
        private readonly IHttpContextAccessor _accessor;

        public ClaimsTransformer(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            return Task.FromResult(principal);
        }
    }
}
