# RanorexExercise
Here is example of test suite created in Ranorex Studio for WPF test application
 
# Setup
To run this test suite need to perform following steps
1.	Install Ranorex Studio 
2.	Download WPF application from 
https://demos.telerik.com/wpf/outlookinspiredapp/?_ga=2.143035004.870410431.1583315977-2074839806.1583315977
Unzip it and put it in a convenient location (by default it's user desktop).
3.	Start Ranorex  Studio and open “Ranorex exercise.rxsln”

# Test suite scenarios
Two test scenarios were implemented:

-- Reply On Email
1. Start application.
2. Click on Inbox folder
3. Enter subject to Search field ("subject" provided from Data source)
4. In email list select email by subject and click on it ("subject" provided from Data source)
5. Click button Reply 
6. Validate subject of new email (Control value provided from Data source)
7. Modify message by value from test data source.
8. Click button Send
9. Clear Search field
11. Repeat steps 3-9 for few emails (test data provided by Data source according to selection in data range, 3 rows) 
10. Close application

-- Forward Emails
1. Start application.
2. Click on Inbox folder
3. Enter subject to Search field ("subject" provided from Data source)
4. In email list select email by subject and click on it ("subject" provided from Data source)
5. Click button Forward 
6. Validate subject of new email (Control value provided from Data source)
7. Set recipient address at field TO (email provided from data source)
8. Modify message by value from test data source.
9. Click button Send
10. Clear Search field
11. Repeat steps 3-10 for few emails (test data provided by Data source according to selection in data range, 4 rows)
12. Close application.

#Please note
For current setup the test 'Reply On Email' is failed cause on third iteration the error message comes up:
    "Please make sure you enter at least one correct recipient address."
