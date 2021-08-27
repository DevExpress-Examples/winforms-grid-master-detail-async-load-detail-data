<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632479/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2745)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsSample/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsSample/Form1.vb))
<!-- default file list end -->
# Master-Detail - How to load detail view data asynchronously


<p>Assume it is required to load data for the detail view from a database dynamically, and you do not want to freeze the main view while the data is being loaded. This example demonstrates how to accomplish this task. A Master-Detail relationship is built on events in it, and data for the detail view is loaded in the background thread when it is expanded. Since the detail view is initially empty, it is required to set the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridOptionsDetail_AllowExpandEmptyDetailstopic"><u>OptionsDetail.AllowExpandEmptyDetails</u></a> property to true to be able to start the loading process.</p><p>Also, please note that it is possible to enable asynchronous mode in the whole XtraGrid. This feature is called <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument8893"><u>Instant Feedback Mode</u></a>. Please refer to the corresponding help topic for additional information.</p>

<br/>


