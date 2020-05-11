# SHYE_MVVM_WPF
SHYE- "See How You Eat" is a simple food tracing application. 
We built this app as part of studing at course "Windows system engineering" at Lev Academic Center in Jerusalem (JCT).

Architecture:
This application (WPF) works with database Microsoft SQL Server through Entity Framework. 
The general modulation based on the classical layer pattern.
In addition, we use MVVM pattern and followed SOLID principles.
The display design based on a main shell screen that is divided into compartments functional which contain user controls.
The app connects cloud service in order to get a real data on the saved food and to translate it into components.

Use:
On the dairy view the user enters the food he has eaten. He can navigate between meals and days.
On the profile view the user can update his details, especially- weight, height and weekly goal.
On the dashboard view the user gets the "evaluating of his plate": 
-His current BMI
-His weight evolution and daily eaten calories through the last month (dispaly on graphs) 
-Total food components he has already eaten today (in relation to the weekly goal the user determined).
