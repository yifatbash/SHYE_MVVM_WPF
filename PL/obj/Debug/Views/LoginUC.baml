   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5      #clr-namespace:PL.ViewsPL.Views  5	          PL.Views.LoginUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:PL     5      S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      #local1clr-namespace:PL.Views  5	      $	��554��5
      $	��357��6   .��5      � $��5,0,0,1q�6   .+�5   
   �� $	��553��6   $	��Top=�6!   $��-3,0,0.333,0q�69   ��5      �� 5        �� EndPoint$  0.5,1&�6&    �� 
StartPoint$ 0.5, 0&�67   .��5      �  � Color$ 	#FF2231D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $	 0.5Q�65   5      5      '  !MaterialDesignThemes.Wpf.PackIcon  5   
      Kind$ AccountCircleOutline=�6"   $	��Top=�6>   $��center=�6V   $	��100��6s   $	��100��6�   
�������$��20q�6�   ��6�   Z� ��6�   Z� 6�   �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0 150q�6U    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFBBBBBB��6#      
BlurRadius$ 15Q�65      	Direction$ 0Q�6E   	   RenderingBias$	 Quality=�6S   
   ShadowDepth$
 1Q�6k   5      � 5   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0 140q�6C   .+�5      �� $��LOGIN��6   $	��Top=�6%   $��Center=�6=   $��5q�6Z   
�������$��16(�6w   $
��Bold"�6�   �� 5      $��Center=�6   $��10q�64   .+�5      � .+�5         $ EnvelopeOutline=�6.   $
��0 25q�6E   �� 5!      -   5         ��Name$ emailTextBox��5!      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ EMAIL��64    %  !MaterialDesignFloatingHintTextBox#��[  6[   $��20 10q�6�   $��12(�6�   5"      � 5#      .+�5$        $ KeyMinus=�6.   $��0 25 q�6>   G� 5%      -   5        $��passwPasswordBox��5%   "   $ PASSWORD��6:    ) %MaterialDesignFloatingHintPasswordBox#��[ 6d   $��20 10q�6�   $��12(�6�   5&      5'      5(      �� 5*   
   -   5         ��Name$ 
login_butt��5*      $��Bottom=�6�   $��0 130q�6�   $	��150��6�   $��Login��6�   ��6%   �� *MyReplaceUCCommand+��6L   ��  �� ElementName$ 
login_butt�� �� Path$ Content�6�   �� 5+   
   -   5        $ register_butt��5+      $��Bottom=�6�   $��101,0,101.333,77q�6�   $	��150��6�   $��Register��6�   ��6(   �� *MyReplaceUCCommand+��6O   �� $ register_butt��$ Content�6�   5,      5-      