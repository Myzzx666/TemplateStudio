﻿namespace Param_RootNamespace.Services
{
    public class ApplicationHostService : IApplicationHostService
    {
        private readonly INavigationService _navigationService;
//{[{
        private readonly IPersistAndRestoreService _persistAndRestoreService;
//}]}

        public ApplicationHostService(INavigationService navigationService, IShellPage shellPage, IThemeSelectorService themeSelectorService)
        {
            _navigationService = navigationService;
//{[{
            _persistAndRestoreService = persistAndRestoreService;
//}]}
        }

        public async Task StopAsync()
        {
            await Task.CompletedTask;
//{[{
            _persistAndRestoreService.PersistData();
//}]}
        }

        private async Task InitializeAsync()
        {
            await Task.CompletedTask;
//{[{
            _persistAndRestoreService.RestoreData();
//}]}
        }
    }
}
