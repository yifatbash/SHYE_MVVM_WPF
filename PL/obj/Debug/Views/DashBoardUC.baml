   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PL.ViewsPL.Views  5      clr-namespace:PLPL  5   	   #clr-namespace:PL.ViewsPL.Views  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5
   	       PL.DashBoardUC   5       Viewsclr-namespace:PL.Views  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   %ucclr-namespace:PL.Views     5   	   b ^Syncfusion.SfChart.WPF, Version=17.4460.0.43, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89h dSyncfusion.SfProgressBar.WPF, Version=17.4460.0.43, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
Syncfusion!http://schemas.syncfusion.com/wpf   5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   %BEclr-namespace:BE;assembly=BE  5
   	   l	 hSystem.Windows.Controls.DataVisualization.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nullWchartingToolkitAhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit 	 5   	   .��5      � $	��570��6   $	��820��6     � RowDefinitions  5   
   �� 5      $
��121* �6   �� 5      $
��164* �6   .+�5   
   � -   5         �Name$ firstRow��5      $��	0,0,0,289q�6!   $��2��64    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5!      � -   5        $ summaryGrid��5!      .+�5"      �� $	��200��6   $��20q�6)   
������� �� RadiusY$ 10��6I    �� RadiusX$ 10��6V   $	��Top=�6c    J� Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$         
BlurRadius$ 20Q�6+      Color$ 	#FFDEDEDE��6;      RenderingBias$ Quality=�6M   	   ShadowDepth$	 3Q�6e   5&      � 5'      $��25q�6   $	��200��6#   $	��Top=�60   .+�5(      � $��35��6   $��50��6&   ���	#FF41A43C$
��Left=�6I   $	��Top=�6d   $
��10 0q�6|    5)        5*      $ 20Q�6/   $ 	#FFECECEC��6?   $ Quality=�6Q   $	 1Q�6i   .+�5,      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 	Equaliser=�62   $��Center=�6C   $��Bottom=�6`   $��5q�6{   
�������$��20��6�   $��20��6�   5-      �� 5.      $��Summary��6    $��Right=�6/   $��Champagne & Limousines)�6K   $��5q�6s   $	��Top=�6~   
�������6�   � 50      -   5        $ 	remaining��50      $��10q�6h   .+�51      :  4Syncfusion.UI.Xaml.ProgressBar.SfCircularProgressBar  -   5          Name$ remainingProgress��51   ;   4  .Syncfusion.UI.Xaml.ProgressBar.ProgressBarBase   ProgressColor
 � �|�   
TrackColor
 �/kU�$	��200��6�      
StartAngle$	 150Q�6�      EndAngle$	 390Q�6�      ShowProgressValue .     Maximum 6V   �� *WantedCalories+6�   �� 52       �� Orientation$ Vertical=�6%   $��Center=�6<   $��Center=�6W   .+�53      �� -   5         ��Name$ remainingValue��53   (   $�� ��6@   $��30(�6H   
������� �� TextAlignment$ Center=�6h   �� 54      $��	Remaining��6)   $��14(�6:   
�������$ Center=�6Z   $��0 5 0 14q�6q   55      56      �� 59      -   5         ��Name$ nutritionProgress��59   !   $ 
Horizontal=�6<   $��Center=�6U   $��Bottom=�6r   $��5 20 5 5q�6�   .+�5:      �� -   5        $��carbs��5:   %   $ Vertical=�62   $��Bottom=�6I   $��8q�6d   .+�5;      �� $��Carbs��6(   $��12(�65   
�������$ Center=�6U   8  2Syncfusion.UI.Xaml.ProgressBar.SfLinearProgressBar  5<      -   5          Name$ crabsBar��5<   =   
 � �|�
 �/kU�$��5q�6�   $��5��6�   $��90��6     IndicatorCornerRadius$ 10Q�6     Progress 6�   ��  �� ElementName$ actualCrabs�� �� Path$
 Text� 6�   �� $ maxCrabs��$
 Text�6  �� 5=      $ 
Horizontal=�6)   $��Center=�6B   .+�5>   "   �� -	   5        $ actualCrabs��5>   ,   $��0��6A   $��8(�6J   
�������6W   �� 5?   "   $	�� / ��6,   $��8(�67   
�������6D   �� 5@   "   -
   5        $ maxCrabs��5@   ,   $��8(�6U   
���������6>   �� *Carbs+6b   �� 5A   "   $�� g��6-   $��8(�67   
�������6D   5B      5D      �� 5E      -   5        $��Protein��5E   %   $ Vertical=�64   $��Bottom=�6K   $��10q�6f   .+�5F      �� $��Protein��6(   $��12(�67   
�������$ Center=�6W     5G      -   5        $ 
ProteinBar��5G   =   
 � �|�
 �/kU�$��5q�6�   $��5��6  $��90��6  $ 10Q�6   6�   �� $ 
maxProtein��$
 Text� 6�   �� $ actualProtein��$
 Text�6  �� 5H      $ 
Horizontal=�6)   $��Center=�6B   .+�5I   "   �� -   5        $ actualProtein��5I   ,   $��0��6C   $��8(�6L   
�������6Y   �� 5J   "   $	�� / ��6,   $��8(�67   
�������6D   �� 5K   "   -   5        $ 
maxProtein��5K   ,   $��8(�6Z   
���������6@   �� *
Proteins+6g   �� 5L   "   $�� g��6-   $��8(�67   
�������6D   5M      5O      �� 5P      -   5        $	��Fat��5P   %   $ Vertical=�60   $��Bottom=�6G   $��8q�6b   .+�5Q      �� $	��Fat��6(   $��12(�63   
�������$ Center=�6S     5R      -   5        $ FatBar��5R   =   
 � �|�
 �/kU�$��5q�6�   $��5��6�   $��90��6  $ 10Q�6   6�   �� $ 	actualFat��$
 Text� 6�   �� $ maxFat��$
 Text�6  �� 5S      $ 
Horizontal=�6)   $��Center=�6B   .+�5T   "   �� -   5        $ 	actualFat��5T   ,   $��0��6?   $��8(�6H   
�������6U   �� 5U   "   $	�� / ��6,   $��8(�67   
�������6D   �� 5V   "   -   5        $ maxFat��5V   ,   $��8(�6R   
���������6<   �� *Fats+6_   �� 5W   "   $�� g��6-   $��8(�67   
�������6D   5X      5Y      5Z      5\      5]         PL.Views.BMIUC  5_      $��1��6   $	��Top=�6*    5`        5a      $ 20Q�6'   $ 	#FFDEDEDE��67   $ Quality=�6I   $	 3Q�6a   5c      5e      � 5g   
   -   5        $ 	secondRow��5g      $��1��6"   $��0,1,0,-2q�6/    5h      �� 5i      $
��193* �6#   �� 5j      $
��217* �6#   .+�5m         PL.Views.WeightGraphUC  $��
10,10,10,0q�6    5n        5o      $ 20Q�6'   $ 	#FFDEDEDE��67   $ Quality=�6I   $	 3Q�6a   5q         PL.Views.CaloriesUC  5r      $��1��6    5s        5t      $ 20Q�6'   $ 	#FFDEDEDE��67   $ Quality=�6I   $	 3Q�6a   5v      5y      5�      5�      