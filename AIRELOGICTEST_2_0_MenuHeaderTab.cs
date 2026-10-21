using Microsoft.AspNetCore.Mvc.RazorPages;

namespace playwright_Airelogic_Interview.Airelogic
{

    //[Reqnroll.Binding]
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    [TestClass]

    public class AIRELOGICTEST_1_0_MenuHeaderTab : NUPageTest
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
            await Task.Delay(1);
        }

        [TestCase]
        public async Task AIRELOGIC_1_1_CLICKER_01()
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
            await Task.Delay(1);

            //if (
            //      (await Page.GetByRole(AriaRole.Heading, new() { Name = "Cookie Clicker!" }).IsVisibleAsync())
            //    & (await Page.GetByRole(AriaRole.Textbox).IsVisibleAsync())
            //    & (await Page.GetByRole(AriaRole.Button).IsVisibleAsync())
            //    )
            //{
            /// Expected variables
            await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Cookie Clicker!" })).ToBeVisibleAsync(); await Task.Delay(1000);
                await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "New Game" })).ToBeVisibleAsync(new() { Timeout = 10_000 }); await Task.Delay(1000);
                await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "High Scores" })).ToBeVisibleAsync(new() { Timeout = 10_000 }); await Task.Delay(1000);
                await Expect(Page.GetByRole(AriaRole.Columnheader, new() { Name = "Player" })).ToBeVisibleAsync(new() { Timeout = 10_000 }); await Task.Delay(1000);
                await Expect(Page.GetByRole(AriaRole.Columnheader, new() { Name = "Score" })).ToBeVisibleAsync(new() { Timeout = 10_000 }); await Task.Delay(1000);

                // await Expect(page.GetByRole(AriaRole.Cell, new() { Name = "0" })).ToBeVisibleAsync(new() { Timeout = 10_000 }); await Task.Delay(1000);  /// IGC               

                await Expect(Page.GetByText("Your name:")).ToBeVisibleAsync(new() { Timeout = 10_000 }); await Task.Delay(1000);
                await Expect(Page.GetByRole(AriaRole.Button, new() { Name = "Start!" })).ToBeVisibleAsync(new() { Timeout = 10_000 }); await Task.Delay(1000);
                await Expect(Page.GetByRole(AriaRole.Textbox)).ToBeVisibleAsync(new() { Timeout = 10_000 }); await Task.Delay(1000);

                /// Main name Cookie Clicker   
                await Page.GetByRole(AriaRole.Heading, new() { Name = "Cookie Clicker!" }).HoverAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Heading, new() { Name = "Cookie Clicker!" }).HighlightAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Heading, new() { Name = "Cookie Clicker!" }).WaitForAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Heading, new() { Name = "Cookie Clicker!" }).HideHighlightAsync(); await Task.Delay(1000);


                await Page.GetByRole(AriaRole.Heading, new() { Name = "New Game" }).HoverAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Heading, new() { Name = "New Game" }).HighlightAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Heading, new() { Name = "New Game" }).WaitForAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Heading, new() { Name = "New Game" }).HideHighlightAsync(); await Task.Delay(1000);

                await Page.GetByRole(AriaRole.Heading, new() { Name = "High Scores" }).HoverAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Heading, new() { Name = "High Scores" }).HighlightAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Heading, new() { Name = "High Scores" }).WaitForAsync(new() { Timeout = 10_000 });
                await Page.GetByRole(AriaRole.Heading, new() { Name = "High Scores" }).HideHighlightAsync(); await Task.Delay(1000);

                await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Player" }).HoverAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Player" }).HighlightAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Player" }).WaitForAsync(new() { Timeout = 10_000 });
                await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Player" }).HideHighlightAsync(); await Task.Delay(1000);

                await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Score" }).HoverAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Score" }).HighlightAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Score" }).WaitForAsync(new() { Timeout = 10_000 });
                await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Score" }).HideHighlightAsync(); await Task.Delay(1000);

                /// variable name bug l
                /// 
                var ScoreValue = "0";  /// Page 
                await Page.GetByRole(AriaRole.Cell, new() { Name = ScoreValue }).HoverAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Cell, new() { Name = ScoreValue }).HighlightAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Cell, new() { Name = ScoreValue }).WaitForAsync(new() { Timeout = 10_000 });
                await Page.GetByRole(AriaRole.Cell, new() { Name = ScoreValue }).HideHighlightAsync(); await Task.Delay(1000);


                await Page.GetByText("Your Name:").HoverAsync(); await Task.Delay(1000);
                await Page.GetByText("Your Name:").HighlightAsync(); await Task.Delay(1000);
                await Page.GetByText("Your Name:").WaitForAsync(new() { Timeout = 10_000 });
                await Page.GetByText("Your Name:").HideHighlightAsync(); await Task.Delay(1000);


                await Page.GetByRole(AriaRole.Textbox).HoverAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Textbox).HighlightAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Textbox).WaitForAsync(new() { Timeout = 10_000 });
                await Page.GetByRole(AriaRole.Textbox).HideHighlightAsync(); await Task.Delay(1000);


                await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).HoverAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).HighlightAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).WaitForAsync(new() { Timeout = 10_000 });
                await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).HideHighlightAsync(); await Task.Delay(1000);

            //}
        }

        [TestCase]
        public async Task AIRELOGIC_1_2_CLICKER_02()
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
            await Task.Delay(1);

            //if (
            //      (await Page.GetByText("Your Name:").IsVisibleAsync())
            //    & (await Page.GetByRole(AriaRole.Textbox).IsVisibleAsync())
            //    & (await Page.GetByRole(AriaRole.Button).IsVisibleAsync())
            //      )
            //{
            await Page.GetByText("Your Name:").HoverAsync(); await Task.Delay(1000);
                await Page.GetByText("Your Name:").HighlightAsync(); await Task.Delay(1000);
                await Page.GetByText("Your Name:").WaitForAsync(new() { Timeout = 10_000 });
                await Page.GetByText("Your Name:").HideHighlightAsync(); await Task.Delay(1000);


                await Page.GetByRole(AriaRole.Textbox).HoverAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Textbox).HighlightAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Textbox).WaitForAsync(new() { Timeout = 10_000 });
                await Page.GetByRole(AriaRole.Textbox).HideHighlightAsync(); await Task.Delay(1000);


                await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).HoverAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).HighlightAsync(); await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).WaitForAsync(new() { Timeout = 10_000 });
                await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).HideHighlightAsync(); await Task.Delay(1000);

                /// Emter login name
                /// 
                var Loginname = "Blank entry name";
                await Page.GetByRole(AriaRole.Textbox).FillAsync(Loginname);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).ClickAsync();
            //}
        }

        [TestCase]
        public async Task AIRELOGIC_1_3_CLICKER_03()
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
            await Task.Delay(1);

            await Page.GetByRole(AriaRole.Textbox).HoverAsync(); await Task.Delay(1000);
            await Page.GetByRole(AriaRole.Textbox).HighlightAsync(); await Task.Delay(1000);
            await Page.GetByRole(AriaRole.Textbox).WaitForAsync(); await Task.Delay(1000);
            await Page.GetByRole(AriaRole.Textbox).HideHighlightAsync(); await Task.Delay(1000);
            await Page.GetByRole(AriaRole.Textbox).ClickAsync(); await Task.Delay(1000);

            await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).HoverAsync(); await Task.Delay(1000);
            await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).HighlightAsync(); await Task.Delay(1000);
            await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).WaitForAsync(); await Task.Delay(1000);
            await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).HideHighlightAsync(); await Task.Delay(1000);
            await Page.GetByRole(AriaRole.Button, new() { Name = "Start!" }).ClickAsync(); await Task.Delay(1000);

            if (
               (await Page.GetByRole(AriaRole.Link, new() { Name = "Cookie Clicker!" }).IsVisibleAsync())
               )
            {
                /// Expected variables
                /// 
                await Expect(Page.GetByRole(AriaRole.Link, new() { Name = "Cookie Clicker!" })).ToBeVisibleAsync();
                await Task.Delay(1000);
                await Expect(Page.GetByText("Hello")).ToBeVisibleAsync(); await Task.Delay(1000);

                await Expect(Page.GetByText("Cookies:")).ToBeVisibleAsync(); await Task.Delay(1000);
                await Expect(Page.Locator("#cookies")).ToBeVisibleAsync(); await Task.Delay(1000);

                await Expect(Page.GetByText("Factories:")).ToBeVisibleAsync(); await Task.Delay(1000);
                await Expect(Page.GetByText("Factories: 0")).ToBeVisibleAsync(); await Task.Delay(1000);

                await Expect(Page.GetByText("Money:")).ToBeVisibleAsync(); await Task.Delay(1000);
                await Expect(Page.Locator("#money")).ToBeVisibleAsync(); await Task.Delay(1000);

                await Expect(Page.GetByRole(AriaRole.Button, new() { Name = "Click Cookie!" })).ToBeVisibleAsync();
                await Task.Delay(1000);

                await Expect(Page.Locator("html")).ToBeVisibleAsync(); await Task.Delay(1000);
                await Expect(Page.Locator("#cookies-to-sell")).ToBeVisibleAsync(); await Task.Delay(1000);
                await Expect(Page.GetByRole(AriaRole.Button, new() { Name = "Sell Cookies!" })).ToBeVisibleAsync();
                await Task.Delay(1000);
                await Expect(Page.Locator("#factories-to-buy")).ToBeVisibleAsync(); await Task.Delay(1000);
                await Expect(Page.GetByRole(AriaRole.Button, new() { Name = "Buy Factories!" })).ToBeVisibleAsync();
                await Task.Delay(1000);

                /// Cookie Clicker Page

                // await Expect(Page.GetByRole(AriaRole.Cell, new() { Name = "0" })).ToBeVisibleAsync(new() { Timeout = 10_000 }); await Task.Delay(1000);  /// IGC               

                await Page.GetByRole(AriaRole.Link, new() { Name = "Cookie Clicker!" }).HoverAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Link, new() { Name = "Cookie Clicker!" }).HighlightAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Link, new() { Name = "Cookie Clicker!" }).WaitForAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Link, new() { Name = "Cookie Clicker!" }).HideHighlightAsync();
                await Task.Delay(1000);


                await Page.GetByText("Hello").HoverAsync(); await Task.Delay(1000);
                await Page.GetByText("Hello").HighlightAsync(); await Task.Delay(1000);
                await Page.GetByText("Hello").WaitForAsync(); await Task.Delay(1000);
                await Page.GetByText("Hello").HideHighlightAsync(); await Task.Delay(1000);

                await Page.GetByText("Cookies:").HoverAsync(); await Task.Delay(1000);
                await Page.GetByText("Cookies:").HighlightAsync(); await Task.Delay(1000);
                await Page.GetByText("Cookies:").WaitForAsync(); await Task.Delay(1000);
                await Page.GetByText("Cookies:").HideHighlightAsync(); await Task.Delay(1000);

                await Page.Locator("#cookies").HoverAsync(); await Task.Delay(1000);
                await Page.Locator("#cookies").HighlightAsync(); await Task.Delay(1000);
                await Page.Locator("#cookies").WaitForAsync(); await Task.Delay(1000);
                await Page.Locator("#cookies").HideHighlightAsync(); await Task.Delay(1000);


                await Page.GetByText("Factories:").HoverAsync(); await Task.Delay(1000);
                await Page.GetByText("Factories:").HighlightAsync(); await Task.Delay(1000);
                await Page.GetByText("Factories:").HoverAsync(); await Task.Delay(1000);
                await Page.GetByText("Factories:").HideHighlightAsync(); await Task.Delay(1000);

                await Page.GetByText("Factories: 0").HoverAsync(); await Task.Delay(1000);
                await Page.GetByText("Factories: 0").HighlightAsync(); await Task.Delay(1000);
                await Page.GetByText("Factories: 0").WaitForAsync(); await Task.Delay(1000);
                await Page.GetByText("Factories: 0").HideHighlightAsync(); await Task.Delay(1000);

                await Page.GetByText("Money:").HoverAsync(); await Task.Delay(1000);
                await Page.GetByText("Money:").HighlightAsync(); await Task.Delay(1000);
                await Page.GetByText("Money:").WaitForAsync(); await Task.Delay(1000);
                await Page.GetByText("Money:").HideHighlightAsync(); await Task.Delay(1000);

                await Page.Locator("#money").HoverAsync(); await Task.Delay(1000);
                await Page.Locator("#money").HighlightAsync(); await Task.Delay(1000);
                await Page.Locator("#money").WaitForAsync(); await Task.Delay(1000);
                await Page.Locator("#money").HideHighlightAsync(); await Task.Delay(1000);

                await Page.GetByRole(AriaRole.Button, new() { Name = "Click Cookie!" }).HoverAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Click Cookie!" }).HighlightAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Click Cookie!" }).WaitForAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Click Cookie!" }).HideHighlightAsync();
                await Task.Delay(1000);


                await Page.Locator("html").HoverAsync(); await Task.Delay(1000);
                await Page.Locator("html").HighlightAsync(); await Task.Delay(1000);
                await Page.Locator("html").WaitForAsync(); await Task.Delay(1000);
                await Page.Locator("html").HideHighlightAsync(); await Task.Delay(1000);

                await Page.Locator("#cookies-to-sell").HoverAsync(); await Task.Delay(1000);
                await Page.Locator("#cookies-to-sell").HighlightAsync(); await Task.Delay(1000);
                await Page.Locator("#cookies-to-sell").WaitForAsync(); await Task.Delay(1000);
                await Page.Locator("#cookies-to-sell").HideHighlightAsync(); await Task.Delay(1000);

                await Page.GetByRole(AriaRole.Button, new() { Name = "Sell Cookies!" }).HoverAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Sell Cookies!" }).HighlightAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Sell Cookies!" }).WaitForAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Sell Cookies!" }).HideHighlightAsync();
                await Task.Delay(1000);

                await Page.Locator("#factories-to-buy").HoverAsync(); await Task.Delay(1000);
                await Page.Locator("#factories-to-buy").HighlightAsync(); await Task.Delay(1000);
                await Page.Locator("#factories-to-buy").WaitForAsync(); await Task.Delay(1000);
                await Page.Locator("#factories-to-buy").HideHighlightAsync(); await Task.Delay(1000);

                await Page.GetByRole(AriaRole.Button, new() { Name = "Buy Factories!" }).HoverAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Buy Factories!" }).HighlightAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Buy Factories!" }).WaitForAsync();
                await Task.Delay(1000);
                await Page.GetByRole(AriaRole.Button, new() { Name = "Buy Factories!" }).HideHighlightAsync();
                await Task.Delay(1000);
            }
        }
    }
}
 