   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SHYESHYE  5          SHYE.ChooseMealUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      localclr-namespace:SHYE  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��44 �6   �� 5      $	��14* �6   �� 5      $	��15* �6    � ColumnDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5   
   �� $ ��Add new meal to your dairy��6   
�������$��24(�6I   
���   � �� TextAlignment$ Center=�6j    �� Padding$ 5q�6�   $��2��6�    J� Opacity$	 0.7Q�6�      SHYE.AddMealUC  5   
   -   5          Name$ 	BreakFast��5      $��1��6-   $��8q�6:      Title$ 	Breakfast��6E      ImageUri$ ..\Images\breakfast.png��6W      
Percentage$ 30��6z   �� 5   
   -   5        	 ��Name$	 Button_BreakFast��5      $��1��6+   $
��Auto��6e   $��
86,12,83,8q�6s   $��	Breakfast��6�   ��68   Z� ��6N   Z� ��6�   �� *ReplaceViewCommand+6�     5   
   -   5        $ Lunch��5      $��1��6)   $��1��6:   $��8q�6H   $ Lunch��6S   $ ..\Images\lunch2.png��6a   $ 40��6�   �� 5   
   -   5        $	 Button_Lunch��5      $��1��6(   $��1��69   $
��Auto��6s   $��
86,12,83,8q�6�   $��Lunch��6�   ��6F   Z� ��6\   Z� ��6�   �� *ReplaceViewCommand+6�     5   
   -   5        $ Dinner��5      $��2��6*   $��8q�67   $ Dinner��6B   $ ..\Images\dinner2.png��6Q   $ 25��6r   �� 5   
   -   5        $	 Button_Dinner��5      $��2��6(   $
��Auto��6c   $��
86,12,83,8q�6q   $��Dinner��6�   ��66   Z� ��6L   Z� ��6�   �� *ReplaceViewCommand+6�     5   
   -   5        $ Snack��5      $��1��6)   $��2��69   $��8q�6F   $ Snack��6Q   $ ..\Images\snack.png��6_   $ 5��6~   �� 5    
   -   5        $	 Button_Snack��5       $��1��6'   $��2��67   $
��Auto��6q   $��
86,12,83,8q�6   $��Snacks��6�   ��6D   Z� ��6Z   Z� ��6�   �� *ReplaceViewCommand+6�   5!      5"      