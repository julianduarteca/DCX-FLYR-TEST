using DCX_FLYR_TEST.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace DCX_FLYR_TEST.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
