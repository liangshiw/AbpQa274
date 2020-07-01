﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpQa274.Pages
{
    public class Index_Tests : AbpQa274WebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
