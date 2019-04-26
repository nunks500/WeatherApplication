# WeatherApplication

Small Application done with C#/.NET, ReactJS and SQLITE3 in order to provide Weather Information that is provided by one administrator. The admin can insert new data, while the users can only see the data.

If you want to run this application, first you need to download the Weather Application Front-End which is located in another repository under my accoun as well. You then need to procceed with the regular command:

```sh
$ npm i
```

For the backend, you will need to use the Nuget Manager to install SQLITE3.

Just let the backend running, so when the frontend makes the requests, the backend can respond.

## Application Demonstration

![alt text](https://raw.githubusercontent.com/nunks500/WeatherApplication/master/github_readme_pics/login.PNG)

User logins in the app

![alt text](https://raw.githubusercontent.com/nunks500/WeatherApplication/master/github_readme_pics/badlogin.PNG)

If he fails do to so, the following error message appears.

![alt text](https://raw.githubusercontent.com/nunks500/WeatherApplication/master/github_readme_pics/standardview.PNG)

When a regular user makes the login, he can view the Table that has the data the admin inserted.

![alt text](https://raw.githubusercontent.com/nunks500/WeatherApplication/master/github_readme_pics/notpermissions.PNG)

If the standard user, tries to access the URL the admin uses to add the data, he is stopped because he does not have enough permissions.

![alt text](https://raw.githubusercontent.com/nunks500/WeatherApplication/master/github_readme_pics/admininsert.PNG)

When the admin needs to login he just inserts the login combination. Then he is prompted to insert data with the following fields.

![alt text](https://raw.githubusercontent.com/nunks500/WeatherApplication/master/github_readme_pics/admininsert.PNG)

However, if he does respect or fill all of the fields required the following message appears

![alt text](https://raw.githubusercontent.com/nunks500/WeatherApplication/master/github_readme_pics/adminnull.PNG)

After successful insert in the database the following message appears.Clicking the go back, takes him back to the menu that inserts new data.

![alt text](https://raw.githubusercontent.com/nunks500/WeatherApplication/master/github_readme_pics/sucessadd.PNG)

The admin can also view the table, by click the 'View Table' button available in the menu after he logs in. If he clicks there, the following scenario should resemble something like this

![alt text](https://raw.githubusercontent.com/nunks500/WeatherApplication/master/github_readme_pics/ViewTableAdmin.PNG)

Because he is the admin, besides watching the table as the standard user, he has a button, specific to him that allows him to return to the menu to add data.


