Light Out Game
==============

Built using Visual Studios 2019 Comunity Edition and MySQL

Requirements
------------

  * .Net 5
  * MySQL 8.0.16

Installation
------------

1. Clone/Download the Solution from the Repository.

2. Make sure to have a running MySQL instance and create an new database (example `lightout`)

3. Open The Solution.

4. Open the Backend `appsettings.json` and set the Data.ConnectionStrings.DefaultConnection with the MySQL server's IP, Port, Username, password and database name (example `server=127.0.0.1;port=3306;user=root;password=;database=lightout`)

5. Access the Package Manager Console and Run `update-database`. This will create the required table(s) and populate the default records

Running the Solution
--------------------

Both the BankendAPI and FrontEnd projects should be run simultaneously by using `Multiple Startup Projects`.

The BankendAPI project should open a web browser pointing to your http://localhost:xxxxx/swagger/index.html

The FrontEnd project will load a Form. Make sure the contents of the TextBox labeled Server IP:Port match the domain and port in your browser; if not update them. Click connect. The game should start afterwads. Should you wish to stop the game and start a new one; simply click on the `New Game` button or click on the Disconnect and then Connect button.


Running Tests
-------------

1. Open the FrontEndTests Project

2. From teh Test menu, click on `Run all Tests`

3. The `Test Explorer` will show the result.

