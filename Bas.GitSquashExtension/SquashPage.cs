using Microsoft.TeamFoundation.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bas.GitSquashExtension
{
    [TeamExplorerPage(SquashPage.Id)]
    public class SquashPage : ITeamExplorerPage
    {
        public const string Id = "025AC5CF-A765-4203-B245-CAD9257624F2";
        
        public string Title => "Squash";

        public object PageContent => null;

        public bool IsBusy => false;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Cancel()
        {
            
        }

        public void Dispose()
        {
            
        }

        public object GetExtensibilityService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public void Initialize(object sender, PageInitializeEventArgs e)
        {
            
        }

        public void Loaded(object sender, PageLoadedEventArgs e)
        {
            
        }

        public void Refresh()
        {
            
        }

        public void SaveContext(object sender, PageSaveContextEventArgs e)
        {
            
        }
    }
}
