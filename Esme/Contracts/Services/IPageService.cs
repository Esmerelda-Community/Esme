using System;

namespace Esme.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);
}
