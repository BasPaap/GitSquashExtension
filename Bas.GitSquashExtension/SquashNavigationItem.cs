using Microsoft.TeamFoundation.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bas.GitSquashExtension
{
    [TeamExplorerNavigationItem(SquashNavigationItem.NavigationItemId, 1800)]    
    public class SquashNavigationItem : ITeamExplorerNavigationItem
    {
        public const string NavigationItemId = "C90006F1-AB77-4AA9-BD6C-181F2BA28BF9";

        public string Text => "Squash";

        public Image Image => null;

        public bool IsVisible => true;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Dispose()
        {
            
        }

        public void Execute()
        {
            
        }

        public void Invalidate()
        {
            
        }
    }
}
