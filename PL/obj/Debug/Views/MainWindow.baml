   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SHYESHYE  5   	   clr-namespace:SHYESHYE  5   	   clr-namespace:PLPL  5	   	   #clr-namespace:PL.ViewsPL.Views  5
   	       SHYE.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:SHYE     5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ucclr-namespace:SHYE  5   	   plclr-namespace:PL  5	   	   "viewsclr-namespace:PL.Views  5
   	     � Title$  
MainWindow��5   	   $	��670��6   $
��1024��6)    � AllowsTransparency .  � WindowStyle$
 None=�6P    � WindowStartupLocation$ CenterScreen=�6c    � 
ResizeMode$ NoResize=�6�   .��5      � $
��1024��6   $	��670��6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   � $��2��6   ���	#FF612BC1.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      A� -   5         A�Name$ 	imageView��5      $��25��6-   $��25��68   $y�Hidden=�6D   ��5      �� 5      	 �� ImageSource	 6%   �� *	Image_Uri+5      �� 5      -   5        
 ��Name$
 emailTextBlock��5      $
��10 5q�65   
�������$y�Hidden=�6n   ��6V   �� *Email+6n   �� 5      -   5        $��25��5      $��25��6$    &  "MaterialDesignFloatingActionButton#��[  61   
���������6m   Z� ��6�   Z� .��5       '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�6.   5!      5"      5#      � 5$   
   -   5         �Name$ menuGrid��5$      $��1��6!   {�.  ��5%      �� 5&       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5'      �  � Color$ 	LightGray��6#    � Offset$ 1Q�65   � 5(      $ 	#FFE6E6E6��6#   5)       J� Effect 5+      3  -System.Windows.Media.Effects.DropShadowEffect  5,         Color$ White��6#      RenderingBias$ Quality=�61      ShadowDepth$ 1Q�6I    5.      �� 5/      $��50 �6    6.   �� 50      $��* �6    .+�52         PL.Views.MenuUC  $��1��6   6*   53      � 54   
   -   5        $ mainGrid��54      $��1��6!   $��1��6.   ��55      �� 56      $	 ..\Images\fruits.jpg��6    �� Opacity$	 0.7Q�6@   .+�58         PL.Views.HomeUC  $��3��6   59      5:      5;      