using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

using TreeTest.ViewModels;

namespace TreeTest.Components
{
    public partial class TreeTestComponent
    {
        public TreeTestComponent()
        {
            TreeNodeViewModel rootNode = new TreeNodeViewModel();
            rootNode.Title = "root";

            TreeNodeViewModels.Add(rootNode);

            for(int counter = 0; counter < 10; counter++)
            {
                TreeNodeViewModel childNode = new TreeNodeViewModel
                {
                    Title = "Child " + counter,
                    Parent = rootNode,
                    Index = counter
                };

                rootNode.Children.Add(childNode);
            }
        }

        List<TreeNodeViewModel> TreeNodeViewModels = new List<TreeNodeViewModel>();


            


        IList<TreeNodeViewModel> ExpandedNodes = new List<TreeNodeViewModel>();
        
        TreeNodeViewModel selectedNode;
        
        protected override void OnInitialized()
        {
            //ExpandedNodes.Add(TreeNodeViewModels.Skip(1).First());
            //ExpandedNodes.Add(TreeNodeViewModels.Skip(1).Take(1).First().Children.Skip(1).First());
        }
    }
}