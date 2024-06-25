<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632479/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2745)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Asynchronous detail view loading

This example demonstrates how to load detail data in a background thread to avoid freezing the UI. 

![WinForms Data Grid - Asynchronous detail view loading](https://raw.githubusercontent.com/DevExpress-Examples/master-detail-how-to-load-detail-view-data-asynchronously-e2745/13.1.4%2B/media/winforms-grid-async-master-detail.gif)

> **Note**
>
> Detail views are initially empty. Detail data is loaded dynamically when a user expands a master row. The [OptionsDetail.AllowExpandEmptyDetails](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsDetail.AllowExpandEmptyDetails) property is set to **true** to allow users to expand master rows when details have no data.


## Files to Review

* [Form1.cs](./CS/WindowsFormsSample/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsSample/Form1.vb))


## Documentation

* [Master-Detail Relationships](https://docs.devexpress.com/WindowsForms/3473/controls-and-libraries/data-grid/master-detail-relationships)
* [Working with Master-Detail Relationships in Code](https://docs.devexpress.com/WindowsForms/732/controls-and-libraries/data-grid/master-detail/working-with-master-detail-relationships-in-code)
* [Large Data Sources: Server and Instant Feedback Modes](https://docs.devexpress.com/WindowsForms/8398/controls-and-libraries/data-grid/data-binding/large-data-sources-server-and-instant-feedback-modes)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-master-detail-async-load-detail-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-master-detail-async-load-detail-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
