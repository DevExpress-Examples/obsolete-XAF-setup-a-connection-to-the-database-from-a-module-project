# OBSOLETE - How to setup a connection to the database from a Module project instead of an executable application project


<p><strong>=====================================</strong><br /><strong>This example is now obsolete. Instead, refer to the <a href="https://www.devexpress.com/Support/Center/p/E4896">How to connect different ORM data models to several databases within a single application</a> one.</strong><br /><strong>=====================================</strong><br />Usually, the connection to the database is set up in the executable <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2569">application project</a>. Usually, it is performed in the configuration file or directly in the code of the application's designer or within the Main function/Global application class. To learn more, please check out this help topic: <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3155">Connect an XAF Application to a Database Provider</a><br /> In this example, you will learn how to establish a connection to the database directly from your Module project. To do this, you will have to override the Setup method of your Module class and handle the CreateCustomObjectSpaceProvider event of the XafApplication class.<br /><br /><strong>See Also:</strong></p>
<p><a href="https://www.devexpress.com/Support/Center/p/E411">How to use a custom ObjectSpaceProvider in XAF</a><strong><br /></strong></p>

<br/>


