using Microsoft.AspNetCore.Mvc.RazorPages;

namespace playwright_Tier1_Interview.Tier1Testcases
{

    [Reqnroll.Binding]
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    [TestClass]

    public class Tier1_1_0_MenuHeaderTab : NUPageTest
    {
        private readonly IPage? _page;
        public static IWebDriver? _driver;
        public static IBrowser? _browser;

        /// <summary>
        /// </summary>
        /// <returns></returns>
        [SetUp]
        //[OneTimeSetUp]
        public async Task Setup()
        {
            var printactionFile = await ChromeDriveActions.ActionsDriver(AppVariables.Application_Name);

            using var playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new()
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();
            await page.GotoAsync(AppVariables.Application_URL);

            await TIER1_1_0_LOGIN_Button(page);
            await TIER1_1_1_Tier1_Button(page);
            await TIER1_1_2_Services_Button(page);
            // await TIER1_1_3_Circular_Image(page);
            await TIER1_1_4_LoginClient(page);

            await Task.Delay(1);
        }

        [TestCase]
        public async Task TIER1_1_0_TIER1_TestInterview()
        {
            await Task.Delay(1);

        }


        public async Task TIER1_1_0_LOGIN_Button(IPage page)
        {
            /// Expected variables
            /// Login
            /// 
            await page.GetByRole(AriaRole.Listitem).Filter(new() { HasText = "Client Login" }).HoverAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Listitem).Filter(new() { HasText = "Client Login" }).HighlightAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Listitem).Filter(new() { HasText = "Client Login" }).WaitForAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Listitem).Filter(new() { HasText = "Client Login" }).HideHighlightAsync(); await Task.Delay(1000);
        }

        public async Task TIER1_1_1_Tier1_Button(IPage page)
        {
            /// Tier1
            /// 
            await page.GetByRole(AriaRole.Link, new() { Name = "tier1", Exact = true }).HoverAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "tier1", Exact = true }).HighlightAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "tier1", Exact = true }).WaitForAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "tier1", Exact = true }).HideHighlightAsync(); await Task.Delay(1000);
        }

        public async Task TIER1_1_2_Services_Button(IPage page)
        {
            /// Services
            /// 
            await page.Locator("#top-menu").GetByText("Services", new() { Exact = true }).HoverAsync(); await Task.Delay(1000);
            await page.Locator("#top-menu").GetByText("Services", new() { Exact = true }).HighlightAsync(); await Task.Delay(1000);
            await page.Locator("#top-menu").GetByText("Services", new() { Exact = true }).ClickAsync(); await Task.Delay(1000);

            await page.Locator("#top-menu").GetByRole(AriaRole.Link, new() { Name = "Lifecycle Services" }).HoverAsync();
            await page.Locator("#top-menu").GetByRole(AriaRole.Link, new() { Name = "Lifecycle Services" }).HighlightAsync();
            await page.Locator("#top-menu").GetByRole(AriaRole.Link, new() { Name = "Lifecycle Services" }).ClickAsync();


            await page.Locator("#top-menu").GetByText("Services", new() { Exact = true }).ClickAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "ITAD" }).HoverAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "ITAD" }).HighlightAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "ITAD" }).WaitForAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "ITAD" }).HideHighlightAsync(); await Task.Delay(1000);

            await page.Locator("#top-menu").GetByText("Services", new() { Exact = true }).ClickAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Data Destruction" }).HoverAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Data Destruction" }).HighlightAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Data Destruction" }).WaitForAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Data Destruction" }).HideHighlightAsync(); await Task.Delay(1000);

            await page.Locator("#top-menu").GetByText("Services", new() { Exact = true }).ClickAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Asset Resale" }).HoverAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Asset Resale" }).HighlightAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Asset Resale" }).WaitForAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Asset Resale" }).HideHighlightAsync(); await Task.Delay(1000);

            await page.Locator("#top-menu").GetByText("Services", new() { Exact = true }).ClickAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Refurbishment" }).HoverAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Refurbishment" }).HighlightAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Refurbishment" }).WaitForAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Refurbishment" }).HideHighlightAsync(); await Task.Delay(1000);

            await page.Locator("#top-menu").GetByText("Services", new() { Exact = true }).ClickAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Compliance as a Service (CaaS)" }).HoverAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Compliance as a Service (CaaS)" }).HighlightAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Compliance as a Service (CaaS)" }).WaitForAsync(); await Task.Delay(1000);
            await page.GetByRole(AriaRole.Link, new() { Name = "Compliance as a Service (CaaS)" }).HideHighlightAsync(); await Task.Delay(1000);

            await page.Locator("#top-menu").GetByText("Services", new() { Exact = true }).HideHighlightAsync(); await Task.Delay(1000);

        }

        public async Task TIER1_1_3_Circular_Image(IPage page)
        {
            await page.GetByRole(AriaRole.Link, new() { Name = "tier1", Exact = true }).ClickAsync(); //await Task.Delay(1000);

            await page.Locator(".wp-image-156890").First.HoverAsync(); await Task.Delay(1000);
            await page.Locator(".wp-image-156890").First.HighlightAsync(); await Task.Delay(1000);
            await page.Locator(".wp-image-156890").First.WaitForAsync(); await Task.Delay(1000);
            await page.Locator(".wp-image-156890").First.HideHighlightAsync(); await Task.Delay(1000);
        }

        public async Task TIER1_1_4_LoginClient(IPage page)
        {
            await page.GetByRole(AriaRole.Listitem).Filter(new() { HasText = "Client Login" }).ClickAsync(); await Task.Delay(1000);
        }
    }
}