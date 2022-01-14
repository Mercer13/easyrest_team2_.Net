﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Team2.Net.PageObjects
{
    public partial class ClientPanel
    {
        private readonly By _identificateEmail = By.XPath("//*[contains(text(), 'katherinebrennan@test.com')]");
        private readonly By _buttonCurrentOrders = By.XPath("//span[contains (text(), 'Current Orders')]");
        private readonly By _buttonHistoryOrders = By.XPath("//span[contains (text(), 'Order History')]");
        private readonly By _tabHistory = By.CssSelector("a[href='/profile/order_history/History']");
        private readonly By _buttonShowMoreHistory = By.XPath("//div[@role = 'button'][1]");
        private readonly By _buttonReorderFromHistory = By.XPath("//span[text()= 'Reorder'][1]");
        private readonly By _identificateConfirmAllert = By.XPath("//p[text()= 'Order status changed to Waiting for confirm']");
        private readonly By _buttonSubmitFromHistory = By.XPath("//span[text()= 'Submit']");
        private readonly By _tabDeclined = By.CssSelector("a[href='/profile/order_history/Declined']");
        



    }
}