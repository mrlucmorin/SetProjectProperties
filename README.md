# SetProjectProperties
Script to set EPLAN project properties

At the moment of writing this script, there is no built-in way of importing project properties into an existing project. What drove me to write this was the need to set various Block properties for our projects to display information in a consistent way across projects.

This was developped as a stop gap measure until all our projects could be created from a template. In the meantime, projects already in the pipeline needed to have those Block properties assigned to them, and I didn't want to do this manually.

The idea is to simply define your project properties one by line (starting at line 17 in the script) by adding them to a list.

After that, the script loops over the list, callinbg the XEsSetProjectPropertyAction EPLAN action for each.

Please notice on line 36 how quotes are escaped. This is required, otherwise EPLAN truncates the string value.

Enjoy
