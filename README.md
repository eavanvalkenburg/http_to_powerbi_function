# Functions: HTTP to Power BI
In order for this to work you need to create and define the the streaming dataset in Power BI. First, go to your Power BI workspace in the Power BI service (app.powerbi.com), in your workspace (or another workspace where you want to create the dataset), then:

Click the +Create button on the top right and click Streaming dataset Choose the API type Give the set a name and define the fields and their types. Decide if the dataset should keep history (up to a point, see the Power BI documentation for details on that). Finally after clicking Create, it shows you the Push URL for that dataset (you can also get this URL by clicking the information (i) icon on the Dataset view. The Push URL is in the form of https://api.powerbi.com/beta//datasets//rows?key=, but this might change in the future, store this string for later.

If you want, you can now create some streaming data tiles on a dashboard but they will be empty.

## Application settings

- **PowerBI Push Connection String** - Connection string for streaming dataset in Power BI, for more details see above or a full post [here](https://gist.github.com/eavanvalkenburg/9d2189fa5db171af4f78e768eb9466a7#power-bi-streaming-dataset).

## Quick Deploy to Azure

[![Deploy to Azure](http://azuredeploy.net/deploybutton.svg)](https://azuredeploy.net/)
