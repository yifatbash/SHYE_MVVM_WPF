   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5          PL.Views.RegisterUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      "localclr-namespace:PL     5      S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �� $��20 10 20 10q�6   
�������.+�5   
   �� $ ��YOUR PERSONNAL INFORMATION��6   $��Center=�66   $��Ink Free)�6S   $
��Bold"�6i   �� 5   
   $��Load your picture��6     �� TextAlignment$  Center=�6-   $��DemiBold"�6E   $
��0 10q�6[   � 5   
   .+�5      �� -   5         ��Name$ 
image_butt��5      $	��100��6)   $	��100��66   $��Center=�6C    � Cursor$	 Pen��6�   ��6`   �� *MyOpenFileCommand+.��5      A� -   5         A�Name$ image_ellipse��5      $	��100��61   $	��100��6=   $��Center=�6J   ��5      �� 5      -   5        image_imageBrush�� �� ImageSource 5   ?   �� *	Image_Uri+5      5      5      � 5   
   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ GenderMaleFemale=�6&   $	��0 8q�6>   �� 5      -   5         ��Name$ 
genderMale��5      $
��Male��6+   $��	50,10,0,0q�6:   $	��Top=�6M   �� 5      -   5        $ genderFemale��5      $��Female��6-   $��
150,10,0,0q�6>   $	��Top=�6R   5      � 5   
   $��0 10 0 0q�6   .+�5        $ AccountOutline=�6&   $��Center=�6<   �� 5      -   5         ��Name$ FirstNameTextBox��5   )   $��	20 0 0 10q�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
First Name��6C   	   
HelperText$#	 Helper text longer than error��6o   .��6�   ��5      �� 5       
 �� Path$
 	FirstName�6    �� UpdateSourceTrigger$ PropertyChanged=�6/    �� ValidationRules 5!      %clr-namespace:PL.Domain	PL.Domain  5#   =   &   PL.Domain.NotEmptyValidationRule  5"      %domain1clr-namespace:PL.Domain  5#   =   ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 5%      .��5&       5'      5(      � 5)   
   $��0 10 0 0q�6   .+�5*        $ AccountOutline=�6&   $��Center=�6<   �� 5+      -   5        $ LastNameTextBox��5+   )   $��	20 0 0 10q�6   $ 	Last Name��6B   $#	 Helper text longer than error��6m   .��6�   ��5,      �� 5-      $
 LastName�6   $ PropertyChanged=�6.    5.      %clr-namespace:PL.Domain	PL.Domain  50   =     5/      %domain1clr-namespace:PL.Domain  50   =    . 52      .��53       54      55      � 56   
   $��0 10 0 0q�6   .+�57        $ TelephoneIncoming=�6&   $��0 8 0 0q�6?   �� 58      -   5        $ PhoneTextBox��58      $��20 0 0 0q�6-   $ 	Telephone��6?   ;  5MaterialDesignThemes.Wpf.Transitions.TransitionAssist   DisableTransitions . .��6�   ��59      �� 5:      $
 PhoneNumber�6   $ PropertyChanged=�61    5;      %clr-namespace:PL.Domain	PL.Domain  5=   =     5<      %domain1clr-namespace:PL.Domain  5=   =    . 5?      .��5@       5A      5B      � 5C   
   $��0 0 0 0q�6   .+�5D        $ CalendarMonth=�6&   $��	0 20 0 0 q�6;   (  "System.Windows.Controls.DatePicker  5E      -	   5        $��BirthdayDatePicker��5E      $��35��63   $��20 0 0 0q�6?   $ Date of birth��6Q    (  $MaterialDesignFloatingHintDatePicker#��[  6�      SelectedDate 5F      �� 5G      $
 Birthday�6   $ PropertyChanged=�6.    5H      %clr-namespace:PL.Domain	PL.Domain  5J   =     5I      %domain1clr-namespace:PL.Domain  5J   =    . 5L      5N      5O      � 5P   
   $��0 10 0 0q�6   .+�5Q        $ EnvelopeOutline=�6&   $��0 8 0 0q�6=   �� 5R      -
   5        $ EmailTextBox��5R      $��	20 0 0 10q�6,   $ Email��6@   $#	 Helper text longer than error��6g   .��6�   ��5S      �� 5T      $
 Email�6   $ PropertyChanged=�6+    5U      %clr-namespace:PL.Domain	PL.Domain  5W   =     5V      %domain1clr-namespace:PL.Domain  5W   =    . 5Y      .��5Z       5[      5\      � 5]   
   $��0 0 0 0q�6   .+�5^        $ KeyMinus=�6&   $
��0 8 q�66   G� 5_      -   5         G�Name$ PasswordBox��5_      $��20 0 0 0q�60   $ Password��6q   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . $	 At least 8 characters��6�   5`      � 5b   
   $��0 20 0 0q�6   .+�5c        $ HumanMaleHeightVariant=�6&   $	��0 5q�6D   �� 5d      -   5        $ HeightTextBox��5d      $��	20 0 0 10q�6-   $ Height��6A   $#	 Helper text longer than error��6i   .��6�   ��5e      �� 5f      $
 Height�6   $ PropertyChanged=�6,    5g      %clr-namespace:PL.Domain	PL.Domain  5i   =     5h      %domain1clr-namespace:PL.Domain  5i   =    . 5k      .��5l       5m      5n      � 5o   
   $��0 10 0 0q�6   .+�5p        $ WeightKg=�6&   $	��0 5q�66   �� 5q      -   5        $ WeightTextBox��5q      $��	20 0 0 10q�6-   $ Weight��6A   $#	 Helper text longer than error��6i   .��6�   ��5r      �� 5s      $
 Weight�6   $ PropertyChanged=�6,    5t      %clr-namespace:PL.Domain	PL.Domain  5v   =     5u      %domain1clr-namespace:PL.Domain  5v   =    . 5x      .��5y       5z      5{      � 5|   
   $��0 10 0 0q�6   .+�5}        $ FoodForkDrink=�6&   $��0 8 0 0q�6;   �� 5~      -   5        $ WantedCaloriesTextBox��5~      $��20 0 0 0q�66   $ Wanted Calories��6H    . .��6�   ��5      �� 5�      $

 Goal�6   $ PropertyChanged=�6*    �� Mode$ OneWayToSource=�6P    5�      %clr-namespace:PL.Domain	PL.Domain  5�   =     5�      %domain1clr-namespace:PL.Domain  5�   =    . 5�      .��5�       5�      5�      � 5�   
   .+�5�      �� -   5        $ Ok_butt��5�      $��Ok��6&   $��
 0 20 0 0 q�63   $��Right=�6G   ��6c   �� *MyReplaceUCCommand+��6�   �� *	Content+ �� ElementName$ Ok_butt���� 5�      -   5        $ 	Back_butt��5�      $��Login��6(   $��
 0 20 0 0 q�68   $
��Left=�6L   ��6g   �� *MyReplaceUCCommand+��6�   �� *	Content+$ 	Back_butt��5�      5�      5�      