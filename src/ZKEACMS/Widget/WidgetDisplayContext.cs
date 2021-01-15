﻿/* http://www.zkea.net/ 
 * Copyright 2020 ZKEASOFT 
 * http://www.zkea.net/licenses */


using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using ZKEACMS.Layout;
using ZKEACMS.Page;

namespace ZKEACMS.Widget
{
    public class WidgetDisplayContext
    {
        public LayoutEntity PageLayout { get; set; }
        public WidgetBase Widget { get; set; }
        public ActionContext ActionContext { get; set; }
        public object Model { get; set; }
        public WidgetViewModelPart ToWidgetViewModelPart()
        {
            return new WidgetViewModelPart
            {
                Widget = Widget,
                ViewModel = Widget
            };
        }
        public WidgetViewModelPart ToWidgetViewModelPart(object viewModel)
        {
            return new WidgetViewModelPart
            {
                Widget = Widget,
                ViewModel = viewModel
            };
        }
    }
}