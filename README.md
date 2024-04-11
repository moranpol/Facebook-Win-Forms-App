# Facebook Win Forms App
## Overview
The Facebook app provides users with access to their Facebook profiles and the ability to modify them. Leveraging the Facebook API, the app offers a seamless experience, incorporating advanced features such as multithreading and various design patterns to ensure optimal performance and scalability.

## Design Patterns Utilized
1. Singleton
* Reason for Usage: The Singleton pattern is employed for managing the loginResult variable, ensuring it's created once upon user login and accessed from any part of the application.
* Method of Realization: Implemented with a double lock mechanism in formMain, allowing thread safety. The GetLoginResult method is used across forms to retrieve the singleton instance.
2. Observer
* Reason for Usage: Implemented for notifying users of new posts, ensuring seamless updates across the application.
* Method of Realization: An interface is implemented by listeners, managed by NewPostSubject. Upon new post publication, the notify method in formPost updates all listeners.
3. Factory Method
* Reason for Usage: Facilitates easy addition of new statistics graphs with minimal code changes.
* Method of Realization: Implemented with an abstract class ChartFactory, obligating subclasses to implement the CreateChart method. ColumnChartFactory defines the specific chart implementation.
4. Strategy
* Reason for Usage: Enables flexibility in displaying and sorting posts, facilitating future expansion.
* Method of Realization: ICompareStrategy is implemented by comparison classes (CompareByLikesCountStrategy and CompareByTimeStrategy). SortStrategy activates bubble sorting based on user-selected comparison.

## Features
* Save Photo from Album: Users can save photos from albums by selecting a photo and clicking the "Save Photo" button in FormAlbum. They are prompted to choose the destination path for the image.
* Album Opened Statistics: Accessible by clicking the "Statistics" button in FormAlbum, this feature displays statistics on the number of albums opened per month.

## Development Context
The Facebook app is built using C# and WinForms and was created as part of a design pattern course at the Academic College of Tel Aviv Yaffo.

## Installation
To install the Facebook app, follow these steps:
1. Clone the repository from GitHub.
2. Open the solution file in Visual Studio.
3. Install the required packages.
4. Build the solution and run the app.

## Usage
To use the Facebook app, follow these steps:
1. Log in to the app using your Facebook credentials.
2. Navigate to the desired feature from the app menu.
3. Enjoy the features and have fun!
