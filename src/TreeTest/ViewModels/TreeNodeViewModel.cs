namespace TreeTest.ViewModels
{
    public class TreeNodeViewModel
    {
        public string Title { get; set; }

        public TreeNodeViewModel Parent { get; set; }

        public int Index { get; set; }


        public string Level
        {
            get
            {
                string result = "";

                result = "" + (Index + 1);

                TreeNodeViewModel item = this;

                while (item.Parent != null)
                {
                    result = (item.Parent.Index + 1) + "." + result;
                    item = item.Parent;
                }

                return result;
            }
        }

        public List<TreeNodeViewModel> Children { get; set; } = new List<TreeNodeViewModel>();

        public bool Disabled { get; set; }
    }
}
