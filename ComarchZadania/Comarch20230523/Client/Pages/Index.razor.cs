using Microsoft.AspNetCore.Components;
using System.Collections.Specialized;
using System.Web;

namespace Comarch20230523.Client.Pages
{
    public partial class Index : ComponentBase
    {
        int LastMultimpleOfThree = 0;
        string ImgSrc = "";

        bool firstOptionValue = false;
        bool secondOptionValue = false;

        [Inject]
        public NavigationManager Navigation { get; set; }

        public string Param1 { get; set; }
        public int Param2 { get; set; }

        protected override void OnInitialized()
        {
            Uri currentUri = new Uri(Navigation.Uri);
            NameValueCollection parameters = HttpUtility.ParseQueryString(currentUri.Query);
            Param1 = parameters["param1"];
            Param2 = Convert.ToInt32(parameters["param2"]);

            base.OnInitialized();
        }

        private void UpdateLastOfMultipleOfThree(int value)
        {
            LastMultimpleOfThree = value;
        }
    }
}
