﻿using Microsoft.AspNetCore.Components;

namespace Comarch20230523.Client.Pages
{
    public partial class Index : ComponentBase
    {
        int LastMultimpleOfThree = 0;

        bool firstOptionValue = false;
        bool secondOptionValue = false;

        private void UpdateLastOfMultipleOfThree(int value)
        {
            LastMultimpleOfThree = value;
        }
    }
}
