   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SHYESHYE  5      clr-namespace:SHYESHYE  5      -clr-namespace:PL.convertersPL.converters  5	          SHYE.AddFoodUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      localclr-namespace:SHYE  5      ucclr-namespace:SHYE  5      +	converterclr-namespace:PL.converters  5	      .��5      �   � 	Resources  5   
   -  'PL.converters.StringToMealTypeConverter   StringToMealTypeConverter-  'PL.converters.StringToDateTimeConverter  StringToDateTimeConverter+  %PL.converters.StringToDoubleConverter  StringToDoubleConverter  	foodItems �� DataType   SHYE.FoodTemplateUC��%�   &	        &	      &	 &     &	 9       5      62     5      62     5      60   �� 5      $ local:BE:Food��6-   .R�5        5      5       � RowDefinitions 5   
   �� 5      $	��35* �6   6+   �� 5      $	��56* �6   6+   �� 5      $
��359* �6   6,    � ColumnDefinitions 5   
   �� 5      $	��50* �6   6-   �� 5      $	��50* �6   6-   ��5    
   �� 5!       �� ImageSource$ ..\Images\fruits.jpg��6    �� Opacity$	 0.6Q�6<   .+�5#   
   �� -   5         ��Name$ mealType��5#      
�������$��24(�69   
���   � �� TextAlignment$ Center=�6Z    �� Padding$ 5q�6q   $��2��6}   	 J� Opacity$		 0.7Q�6�   $��0,0,0,0.333q�6�   (  "System.Windows.Controls.DatePicker  5$   
   -   5        $��
chosenDate��5%      $��1��5&      $��2��5'      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 	Pick Date��5(       ( $MaterialDesignFloatingHintDatePicker#��[ 5)      $��37��6S   $��250,9.667,250,9.333q�6_   5*      � 5+   
   $��2��6   $��1��6   $��0,0.667,0,0q�6,   .+�5,      �� 
���   �$		 0.5Q�6%   5-      �� 5.   
   $��2��6   $��1��6$   $��0,0.667,0,0q�64   .��50      �� $��2��6   $��2��6&   .+�51      �� -   5         ��Name$ foodListView��51      #��[ 6N   $��10q�6y   $��Center=�6�   ��60   �� *Foods+52      5>      5?      � 5A   
   $��2��6   $��0,0.667,0,0q�6    5B      �� 5C      $	��11* �6    �� 5D      $	��13* �6    .+�5F      ��  �� Orientation$ Vertical=�6   $��	0,0,0,181q�60   $��2��6C   .+�5G      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6+   $��16q�6=   .��5H      ]� .+�5I      �� $ 
Horizontal=�6%   +  %MaterialDesignThemes.Wpf.RippleAssist   
IsCentered . .+�5J        $ Standard=�67   $��8 4 8 4q�5K   3      CornerRadius$ 2��5L   3    K� ZIndex$ 1��5M   3   $��16 0 0 0q�5N   3   +	  %MaterialDesignThemes.Wpf.ShadowAssist 	  ShadowDepth$ Depth1=�5O   3   .��5P   "   �  5Q   &   �� 5R   *   $
��Auto �6;   �� 5S   *   $��* �6;   �� 5T   *   $
��Auto �6;   .+�5V   &   ��   MaterialDesignToolButton#���  6-   .��5W   *   '
  !MaterialDesignThemes.Wpf.PackIcon
   
  Kind$ Magnify=�6B   $		 .56Q�6Q   5X   '   �� 5Y   &   $��1��6.   $��8 0 0 0q�5Z   *   $
 Enter food name ��5[   *   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5\   *   $��0q�5]   *   $	��200��6>   $��Center=�6M   5^   #   5_      5`      5a      5b        5c      $ 
PrimaryMid=�6+   $��16q�6=   .��5d      ]� .+�5e      �� $ 
Horizontal=�6%    . .+�5f        $ Standard=�67   $��8 4 8 4q�5g   3   $ 2��5h   3   $ 1��5i   3   $��16 0 0 0q�5j   3   $ Depth1=�5k   3   .��5l   "   �  5m   &   �� 5n   *   $
��Auto �6;   �� 5o   *   $��* �6;   �� 5p   *   $
��Auto �6;   .+�5r   &   �� #���  6-   .��5s   *   
  $ Scale=�6B   $		 .56Q�6O   5t   '   �� 5u   &   -   5         ��Name$ 
foodAmount��5u   .   $��1��6B   $��8 0 0 0q�5v   *   $
 Enter amount   (gram)��5w   *   $ Hidden=�5x   *   $��0q�5y   *   $	��200��6>   $��Center=�6M   ��5u   R   �� *Amount+ �� 	Converter# [  �� Mode$ OneWayToSource=�5y   h   5{   #   5|      �� 5}      -   5         ��Name$ 	addButton��5}   %    & "MaterialDesignToolForegroundButton#���  68   {�.  $��30 0 0 0q�5�   %   $ 0��5�   !   ��5~   !   �� *
ApiCommand+.��5�   "   
  $
 Send=�6:   5�      5�      5�      5�      5�        5�      $ 
PrimaryMid=�6'   $��16q�69   $��72��6F   .��5�      ]� .+�5�      �� $ 
Horizontal=�6!    . .+�5�        $ Standard=�63   $��8 4 8 4q�5�   3   $ 2��5�   3   $ 1��5�   3   $��16 0 0 0q�5�   3   $ Depth1=�5�   3   .��5�      �  5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $��* �67   �� 5�   &   $
��Auto �67   .+�5�   "   �� #���  6)   .��5�   &   
  $ Magnify=�6>   $		 .56Q�6M   5�   #   �� 5�   "   $��1��6*   $��8 0 0 0q�5�   *   $
 Enter food name ��5�   *   $ Hidden=�5�   *   $��0q�5�   *   $	��200��6>   $��Center=�6M   5�      5�      5�      5�      5�        5�      $ 
PrimaryMid=�6'   $��16q�69   $��72��6F   .��5�      ]� .+�5�      �� $ 
Horizontal=�6!    . .+�5�        $ Standard=�63   $��8 4 8 4q�5�   3   $ 2��5�   3   $ 1��5�   3   $��16 0 0 0q�5�   3   $ Depth1=�5�   3   .��5�      �  5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $��* �67   �� 5�   &   $
��Auto �67   .+�5�   "   �� #���  6)   .��5�   &   
  $
 Food=�6>   $		 .56Q�6J   5�   #   �� 5�   "   -   5        $ foodName��5�   *   $��1��6<   $��8 0 0 0q�5�   *   $
 Enter food name ��5�   *   $ Hidden=�5�   *   $��0q�5�   *   $	��200��6>   $��Center=�6M   ��5�   L   �� *Name+5�   h   5�      5�      5�      5�      5�      � 5�      -   5         �Name$ showFoodDetails��5�      $��2��6,   5�      5�      �� 5�   
   $��2��6   $��Bottom=�6   $
��Left=�69   $��	10,0,0,10q�6T     MaterialDesignIconButton#��[ 5�       � ToolTip$ MaterialDesignIconButton��5�       ( $MaterialDesignTextFieldBoxBackground#���  5�      ��5�      �� *ReplaceViewCommand+.��5�      
  $ KeyboardBackspace=�5�      5�      5�      5�      