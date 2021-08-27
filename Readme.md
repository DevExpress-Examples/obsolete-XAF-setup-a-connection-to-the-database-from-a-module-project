<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1708)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Module.cs](./CS/WinSolution.Module/Module.cs) (VB: [Module.vb](./VB/WinSolution.Module/Module.vb))
<!-- default file list end -->
# OBSOLETE - How to setup a connection to the database from a Module project instead of an executable application project


<p><strong>=====================================</strong><br /><strong>This example is now obsolete. Instead, refer to the <a href="https://www.devexpress.com/Support/Center/p/E4896">How to connect different ORM data models to several databases within a single application</a> one.</strong><br /><strong>=====================================</strong><br />Usually, the connection to the database is set up in the executable <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2569">application project</a>. Usually, it is performed in the configuration file or directly in the code of the application's designer or within the Main function/Global application class. To learn more, please check out this help topic: <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3155">Connect an XAF Application to a Database Provider</a><br /> In this example, you will learn how to establish a connection to the database directly from your Module project. To do this, you will have to override the Setup method of your Module class and handle the CreateCustomObjectSpaceProvider event of the XafApplication class.<br /><br /><strong>See Also:</strong></p>
<p><a href="https://www.devexpress.com/Support/Center/p/E411">How to use a custom ObjectSpaceProvider in XAF</a><strong><br /></strong></p>

<br/>


